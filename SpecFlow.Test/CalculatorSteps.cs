using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SpecFlow.App;
using TechTalk.SpecFlow;

namespace SpecFlow.Test
{
    [Binding]
    public sealed class CalculatorSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        private Calculator _calculator = new Calculator();
        private int result;

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see http://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            result = _calculator.Add();
        }

        [When("I press subtract")]
        public void WhenIPressSubtract()
        {
            result = _calculator.Subtract();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
