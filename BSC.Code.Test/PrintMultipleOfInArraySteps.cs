using System.Collections.Generic;
using BSC.Code.Library.Utils;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BSC.Code.Test
{
    class InputClass
    {
        public int item { get; set; }
        public string message { get; set; }
    }



    [Binding]
    public class PrintMultipleOfInArraySteps
    {
        private Dictionary<int, InputClass> _arrayInputs;
        private List<int> _arrayOfIntegers;

        public PrintMultipleOfInArraySteps()
        {
            this._arrayInputs = new Dictionary<int, InputClass>();

        }

        [Given(@"an array of integers between (.*) and (.*)")]
        public void GivenAnArrayOfIntegersBetweenAnd(int initial, int final)
        {
            _arrayOfIntegers = BDD_Result.ArrayOfInteger(initial, final);
        }
        
        [When(@"item is multiple of (.*)")]
        public void WhenItemIsMultipleOf(int multipleOf)
        {
            //Arrange
            int expected = 0;
            int input = 3;
            Assert.AreEqual(expected, input % multipleOf);
        }
        
        [When(@"The array have following items")]
        public void WhenTheArrayHaveFollowingItems(Table table)
        {
            //Arrange
            var rows = table.CreateSet<InputClass>();
            // Storing rach row/object in a dictionary
            foreach (InputClass obj in rows)
            {
                this._arrayInputs.Add(obj.item, obj);
            }
        }
        
        [Then(@"should print item")]
        public void ThenShouldPrintItem(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
