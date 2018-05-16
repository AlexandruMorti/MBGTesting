using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace MobbySlotsTest
{
    [TestFixture]
    class MobbyslotsLoginTests : Details.GeneralDetails.Details
    {
        //public static void Main()
        //{ }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        [Test]
        public void CreateLoginNewUser()
        {
            log.Info("Start testing the creation of a new user");

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = BaseUrl;
            log.Info(Navigate);

            //click join now
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[1]/a")).Click();
            log.Info("Click Join Now");


            //Create new User   
            IWebElement username = driver.FindElement(By.XPath("//*[@title='Your username must be between 6 and 16 characters with no spaces or special characters.']"));
            username.SendKeys(Username);
            log.Info("Insert Username - " + Username);

            //Create password
            IWebElement pswBox = driver.FindElement(By.XPath(".//*[@title='Your password needs to be between 6 and 16 characters long and for security it MUST contain at least 1 letter and 1 number.']"));
            pswBox.SendKeys(Password);
            log.InfoFormat("Insert Password - " + Password);

            //confirm password
            IWebElement confPsw = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[3]/input"));
            confPsw.SendKeys(ConfirmPassword);
            log.InfoFormat("Confirm Password - " +  ConfirmPassword);

            //insert email address
            IWebElement email = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[2]/div[1]/input"));
            email.SendKeys(Email);
            log.InfoFormat("Insert Email - " + Email);

            //insert mobile phone
            IWebElement phone = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[2]/div[2]/input"));
            phone.SendKeys(Phone);
            log.InfoFormat("Insert Phone Number - " + Phone);


            //Hit Continue Button
            IWebElement continueBtn = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[3]/div/button"));
            continueBtn.Click();
            log.Info("Log In User");

            Thread.Sleep(01 * 60 * 1000);

            driver.Quit();
            log.Info("Finish testing creation of a new user");
        }
    }
}
