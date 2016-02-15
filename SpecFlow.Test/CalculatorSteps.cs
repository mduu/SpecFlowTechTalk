using NUnit.Framework;
using SpecFlow.App;
using TechTalk.SpecFlow;

namespace SpecFlow.Test
{
    [Binding]
    public sealed class CalculatorSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        private readonly Calculator calculator = new Calculator();
        private int result;

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }

        [When("I press subtract")]
        public void WhenIPressSubtract()
        {
            result = calculator.Subtract();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
