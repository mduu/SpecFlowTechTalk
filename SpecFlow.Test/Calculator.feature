Feature: Calculator

       In order to avoid silly mistakes
       As a math idiot
       I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
       Given I have entered 50 into the calculator
       And I have also entered 70 into the calculator
       When I press add
       Then the result should be 120 on the screen
       
@mytag
Scenario: Add two other numbers
       Given I have entered 30 into the calculator
       And I have also entered 20 into the calculator
       When I press add
       Then the result should be 50 on the screen       
    
@mytag
Scenario: Subtract two numbers
       Given I have entered 30 into the calculator
       And I have also entered 10 into the calculator
       When I press subtract
       Then the result should be 20 on the screen