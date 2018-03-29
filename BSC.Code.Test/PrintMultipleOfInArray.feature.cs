﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BSC.Code.Test
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PrintMultipleOfInArray")]
    [NUnit.Framework.CategoryAttribute("tfs:https://wservices.visualstudio.com/BSC_Case_Test")]
    public partial class PrintMultipleOfInArrayFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PrintMultipleOfInArray.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PrintMultipleOfInArray", "\tI order to run a Loop between 1 and 100\r\n\tI want to print wicht ones are multipl" +
                    "e of 3\r\n\tOr to print wicht ones are multiple of 3 and ends in 6\r\n\tOr to print wi" +
                    "cht ones only ends in 6", ProgrammingLanguage.CSharp, new string[] {
                        "tfs:https://wservices.visualstudio.com/BSC_Case_Test"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Print items of the array")]
        [NUnit.Framework.CategoryAttribute("tc:1")]
        [NUnit.Framework.CategoryAttribute("myScenarios")]
        public virtual void PrintItemsOfTheArray()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Print items of the array", new string[] {
                        "tc:1",
                        "myScenarios"});
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
 testRunner.Given("an array of integers between 1 and 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
 testRunner.When("item is multiple of 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "message"});
            table1.AddRow(new string[] {
                        "3",
                        "multiple of 3"});
            table1.AddRow(new string[] {
                        "9",
                        "multiple of 3"});
#line 13
 testRunner.And("The array have following items", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "message"});
            table2.AddRow(new string[] {
                        "3",
                        "multiple of 3"});
            table2.AddRow(new string[] {
                        "9",
                        "multiple of 3"});
#line 17
 testRunner.Then("should print item", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
