namespace SpecFlowCalculator.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly Calculator calculator = new Calculator();
        private int outcome;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
           calculator.FirstNumber = number;
            
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {

            calculator.SecondNumber = number;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            outcome = calculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
           outcome.Should().Be(result);
        }

        [Then(@"the result in console printed")]
        public void ThenTheResultInConsolePrinted()
        {
            Console.WriteLine("Result is = " + outcome);
        }

        [When(@"the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            outcome = calculator.Substraction();
;        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            outcome = calculator.Multiplication();
        }

        [When(@"the two numbers are devided")]
        public void WhenTheTwoNumbersAreDevided()
        {
            outcome = calculator.Division();
        }

    }
}
