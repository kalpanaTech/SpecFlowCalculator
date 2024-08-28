@calculator_feature
Feature: Calculator
Simple calculator for basic functions

Link to a feature: [Calculator](SpecFlowCalculator/Features/Calculator.feature)


@bvt @regression @calculator
Scenario: Add two numbers as input
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120
	And the result in console printed

	Scenario: Substract two numbers as input
	Given the first number is 80
	And the second number is 40
	When the two numbers are substracted
	Then the result should be 40
	

	Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are multiplied
	Then the result should be 3500
	And the result in console printed

	Scenario: Devide two numbers
	Given the first number is 100
	And the second number is 20
	When the two numbers are devided
	Then the result should be 5
	And the result in console printed