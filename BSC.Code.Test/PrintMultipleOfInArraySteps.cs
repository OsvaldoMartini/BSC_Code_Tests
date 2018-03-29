using System;
using TechTalk.SpecFlow;

namespace BSC.Code.Test
{
    [Binding]
    public class PrintMultipleOfInArraySteps
    {
        [Given(@"an array of integers between (.*) and (.*)")]
        public void GivenAnArrayOfIntegersBetweenAnd(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"item is multiple of (.*)")]
        public void WhenItemIsMultipleOf(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The array have following items")]
        public void WhenTheArrayHaveFollowingItems(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"should print item")]
        public void ThenShouldPrintItem(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
