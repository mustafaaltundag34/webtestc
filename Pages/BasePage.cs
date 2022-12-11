using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestProject1.Steps;

namespace TestProject1.Pages
{

    public class BasePage
    {
        public IWebDriver WebDriver { get; }   
        public BasePage(OpenQA.Selenium.IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        //UI elements
        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement txtUserName => WebDriver.FindElement(By.XPath("//*[@id='UserName']"));
        public IWebElement txtPassword => WebDriver.FindElement(By.XPath("//*[@id='Password']"));
        public IWebElement btnLogin => WebDriver.FindElement(By.CssSelector(".btn-default"));



        public void ClickLogin()
        {
            lnkLogin.Click();
        }
        public void butonatikla(string butonadi)
        {
         IWebElement tiklanacakbuton = WebDriver.FindElement(By.XPath(butonadi));
         tiklanacakbuton.Click();
        }

        public void alanatiklaveyaz(string inputalani,string yazilacaktext)
        {
            IWebElement yazilacakalan = WebDriver.FindElement(By.XPath(inputalani));
            yazilacakalan.Click();
            yazilacakalan.SendKeys(yazilacaktext);
        }

        public void Login(string UserName, string password)
        {
            txtUserName.SendKeys(UserName);
            txtPassword.SendKeys(password);

        }
        public void ClickLoginButton()
        {
            btnLogin.Submit();
        }
        public void IsEmployeeDetailsExist(string gorulecekelement,string aciklama)
        {
        IWebElement gorulenelement= WebDriver.FindElement(By.XPath(gorulecekelement));
            if (gorulenelement.Displayed)
            {
                Console.WriteLine("*** "+aciklama+" Elementi goruldu"); 
            }
            else
                Console.WriteLine("*** " + aciklama + " Elementi gorulemedi");
        }
        public void saniyesuresibeklerim(int p0)
        {
            int saniye = p0*1000;
            Thread.Sleep(saniye);
        }

        public bool isExists(string gorulecekelement) => WebDriver.FindElement(By.XPath(gorulecekelement)).Displayed;


        public void oturumukapatirim()
        {
            WebDriver.Quit(); 
        }

        [AfterTestRun]
        public void AfterTestRun()
        {
            System.Console.WriteLine("Execute AfterTestRun- StopBrowser");
            WebDriver.Quit();
        }

    }

}
