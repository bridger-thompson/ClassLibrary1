namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class RomanizingSteps
    {
        private readonly ScenarioContext context;
        public RomanizingSteps(ScenarioContext context)
        {
            this.context = context;
        }

        [Given(@"input of (.*)")]
        public void GivenInputOf(int p0)
        {
            context.Add("number", p0);
        }

        [When(@"converted to Roman numerals")]
        public void WhenConvertedToRomanNumerals()
        {
            ClassLibrary1.Romanizing number = new();
            try
            {
                string result = number.ToRoman(context.Get<int>("number"));
                context.Add("result", result);
            }
            catch (Exception ex)
            {
                context.Add("result", "Exception");
            }
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string p0)
        {
            context.Get<string>("result").Should().Be(p0);
        }
    }
}