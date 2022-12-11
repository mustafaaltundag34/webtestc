using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject1.Pages;

namespace TestProject1.Steps
{


    [Binding]

    public sealed class LoginStepDefinitions
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        BasePage loginPage;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        [Given(@"""(.*)"" Chrome Internet sayfasini Acarsam")]
        public void GivenUygulamayiAcarsam(string url)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl(url);
            loginPage = new BasePage(webDriver);
            


        }

        [Given(@"Login Linkine tiklarsam")]
        public void GivenLoginLinkineTiklarsam()
        {
           loginPage.ClickLogin();
        }

        [Given(@"Kullanici Adi ve Sifresini girersem")]
        public void GivenKullaniciAdiVeSifresiniGirersem(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login((string)data.UserName ,(string)data.Password);
        }

        [Given(@"Login butonuna tiklarsam")]
        public void GivenLoginButonunaTiklarsam()
        {
            loginPage.ClickLoginButton();
        }

        [Given(@"""(.*)"" xpathli ""(.*)"" elementini gorurum")]
        public void Givenelementigorurum(string gorulecekelement,string aciklama)
        {
            loginPage.IsEmployeeDetailsExist(gorulecekelement,aciklama); 
        }

        [Given(@"""(.*)"" xpath adresli ""(.*)"" Elementini kesinlikle gorurum")]
        public void GivenXpathAdresliElementiniKesinlikleGorurum(string gorulecekelement, string aciklama)
        {
            try
            {
                Assert.That(loginPage.isExists(gorulecekelement), Is.True);
            }
            catch (Exception)
            {
                loginPage.AfterTestRun();
                throw;
            }


        }


        [Given(@"""(.*)"" saniye beklerim")]
        public void GivenSaniyeBeklerim(int p0)
        {
            loginPage.saniyesuresibeklerim(p0);
        }

        [Given(@"""(.*)"" xpath adresli ""(.*)"" Butonuna týklarým")]
        public void GivenButonunaTýklarým(string butonadi, string aciklama)
        {
            loginPage.butonatikla(butonadi);
        }

        [Given(@"""(.*)"" xpath adresli input alanina ""(.*)"" deðerini yazarim")]
        public void GivenAlaninaDeðeriniYazarim(string inputalani, string yazilacaktext)
        {
            loginPage.alanatiklaveyaz(inputalani,yazilacaktext);
        }


        [Given(@"Oturumu Kapatirim")]
        public void GivenOturumuKapatirim()
        {
            loginPage.oturumukapatirim();

        }



    }


}


