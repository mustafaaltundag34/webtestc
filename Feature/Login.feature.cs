﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestProject1.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Login")]
    public partial class LoginFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Login.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature", "Login", "A short summary of the feature", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("LoginSenaryosu")]
        public void LoginSenaryosu()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LoginSenaryosu", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.And("\"http://eaapp.somee.com/\" Chrome Internet sayfasini Acarsam", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 7
 testRunner.And("\"2\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 8
 testRunner.And("\"//*[@id=\"loginLink\"]\" xpath adresli \"Login\" Butonuna tıklarım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "UserName",
                            "Password"});
                table1.AddRow(new string[] {
                            "admin",
                            "password"});
#line 9
 testRunner.And("Kullanici Adi ve Sifresini girersem", ((string)(null)), table1, "* ");
#line hidden
#line 12
 testRunner.And("Login butonuna tiklarsam", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 13
 testRunner.And("\"2\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 14
 testRunner.And("\"//*[@id=\"logoutForm\"]/ul/li[2]/a\" xpath adresli \"Logoff\" Elementini kesinlikle g" +
                        "orurum", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 15
 testRunner.And("\"2\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 16
 testRunner.And("\"/html/body/div[1]/div/div[2]/ul/li[3]/a\" xpath adresli \"Employee List\" Butonuna " +
                        "tıklarım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 17
 testRunner.And("\"2\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 18
 testRunner.And("\"/html/body/div[2]/form/input[1]\" xpath adresli input alanina \"saranya\" değerini " +
                        "yazarim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 19
 testRunner.And("\"2\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 20
 testRunner.And("\"/html/body/div[2]/form/input[2]\" xpath adresli \"Search\" Butonuna tıklarım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 21
 testRunner.And("\"5\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 22
 testRunner.And("\"//*[@id=\"logoutForm\"]/ul/li[2]/a\" xpath adresli \"Logoff\" Butonuna tıklarım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 23
 testRunner.And("\"5\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 24
 testRunner.And("Oturumu Kapatirim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("LoginSenaryosuyanlissifre")]
        public void LoginSenaryosuyanlissifre()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LoginSenaryosuyanlissifre", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 29
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 30
 testRunner.And("\"http://eaapp.somee.com/\" Chrome Internet sayfasini Acarsam", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 31
 testRunner.And("\"2\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 32
 testRunner.And("\"//*[@id=\"loginLink\"]\" xpath adresli \"Login\" Butonuna tıklarım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "UserName",
                            "Password"});
                table2.AddRow(new string[] {
                            "admin",
                            "password1"});
#line 33
 testRunner.And("Kullanici Adi ve Sifresini girersem", ((string)(null)), table2, "* ");
#line hidden
#line 36
 testRunner.And("Login butonuna tiklarsam", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 37
 testRunner.And("\"2\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 38
 testRunner.And("\"//*[@id=\"logoutForm\"]/ul/li[2]/a\" xpath adresli \"Logoff\" Elementini kesinlikle g" +
                        "orurum", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 39
 testRunner.And("\"2\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 40
 testRunner.And("\"/html/body/div[1]/div/div[2]/ul/li[3]/a\" xpath adresli \"Employee List\" Butonuna " +
                        "tıklarım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 41
 testRunner.And("\"2\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 42
 testRunner.And("\"/html/body/div[2]/form/input[1]\" xpath adresli input alanina \"saranya\" değerini " +
                        "yazarim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 43
 testRunner.And("\"2\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 44
 testRunner.And("\"/html/body/div[2]/form/input[2]\" xpath adresli \"Search\" Butonuna tıklarım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 45
 testRunner.And("\"5\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 46
 testRunner.And("\"//*[@id=\"logoutForm\"]/ul/li[2]/a\" xpath adresli \"Logoff\" Butonuna tıklarım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 47
 testRunner.And("\"5\" saniye beklerim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 48
 testRunner.And("Oturumu Kapatirim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion