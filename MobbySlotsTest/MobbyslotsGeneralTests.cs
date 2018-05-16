using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace MobbySlotsTest
{
    [TestFixture]
    public class MobbyslotsGeneralTests : Details.GeneralDetails.Details
    {
        public static void Main()
        { }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [Test, Order(1)]
        public void ActivateAccount()
        {
            log.Info("Start testing activation account");

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = ActivationURL;

            //ENTER VERIFICATION CODE

            //validation code first number
            IWebElement number1 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[1]"));
            number1.SendKeys(Nr1);

            //validation code second number
            IWebElement number2 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[2]"));
            number2.SendKeys(Nr2);

            //validation code third number
            IWebElement number3 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[3]"));
            number3.SendKeys(Nr3);

            //validation code fourth number
            IWebElement number4 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[4]"));
            number4.SendKeys(Nr4);
            log.Info("Inserted Verification code");

            //COMPLETE YOUR ACCOUNT

            //first name
            IWebElement firstName = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[2]/div[1]/input"));
            firstName.SendKeys(FirstName);
            log.InfoFormat(FirstName);

            //last name
            IWebElement lastName = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[2]/div[2]/input"));
            lastName.SendKeys(LastName);
            log.InfoFormat(LastName);


            //DATE OF BIRTH

            //day
            IWebElement day = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[3]/div/div/input[1]"));
            day.SendKeys(Day);

            //month
            IWebElement month = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[3]/div/div/input[2]"));
            month.SendKeys(Month);

            //year
            IWebElement year = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[3]/div/div/input[3]"));
            year.SendKeys(Year);
            log.InfoFormat("Inserted Date Of Birth - " + Day + Month + Year);

            //YOUR ADDRESS

            //postcode
            IWebElement manualInsertAddress = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[2]/a"));
            manualInsertAddress.Click();

            //Insert  House Nr
            IWebElement houseNr = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[3]/input"));
            houseNr.SendKeys(HouseNr);
            log.Info("Inserted House NR - " + HouseNr);

            //Insert Address 1
            IWebElement address1 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[4]/input"));
            address1.SendKeys(Address1);
            log.Info("Inserted Address 1 - " + Address1);

            //Address2
            IWebElement address2 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[5]/input"));
            address2.SendKeys(Address2);
            log.Info(Address2);

            //Town-City
            IWebElement townOrCity = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[6]/input"));
            townOrCity.SendKeys(TownOrCity);
            log.Info("inserted user town ");
            log.Info(TownOrCity);

            //Insert Postcode
            IWebElement postcode = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[7]/input"));
            postcode.SendKeys(PostCode);
            log.Info("inserted user postcode");
            log.Info(PostCode);

            //Select Country
            IWebElement country = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[8]/select/option[2]"));
            country.Click();

            log.InfoFormat("Inserted - " + HouseNr + Address1 + Address2 + TownOrCity + PostCode);


            //activate account
            IWebElement activateAccount = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[5]/div[2]/button"));
            activateAccount.Click();
            log.Info("Hit Activate Account");

            Thread.Sleep(01 * 60 * 1000);

            driver.Quit();
            log.Info("Finish testing activation account ");
        }

        [Test, Order(2)]
        public void WrongAtivationCode()
        {
            log.Info("Start testing wrong activation code");

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = ActivationURL;

            //enter wrong activation code

            //enter code first number
            IWebElement Wrongnumber1 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[1]"));
            Wrongnumber1.SendKeys(WrongNr1);

            //enter code second number
            IWebElement Wrongnumber2 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[2]"));
            Wrongnumber2.SendKeys(WrongNr2);

            //enter code third number
            IWebElement Wrongnumber3 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[3]"));
            Wrongnumber3.SendKeys(WrongNr3);

            //enter code fourth number
            IWebElement Wrongnumber4 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[4]"));
            Wrongnumber4.SendKeys(WrongNr4);
            log.Info("Inserted Wrong Verification code" + WrongNr1 + WrongNr2 + WrongNr3 + WrongNr4);

            driver.Quit();
            log.Info("Finish testing Wrong Verification code");
        }

        [Test, Order(3)]
        public void ResetPassword()
        {
            log.Info("Start testing password resset");

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //driver.Url = BaseUrl;
            driver.Url = BaseUrl;
            log.Info(Navigate);

            //Click Forgotten Password
            IWebElement forgottenPassword = driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[1]/form/div[3]/a"));
            forgottenPassword.Click();
            log.Info("Click Forgotten Password");

            //Insert Email for Reset Passowrd
            IWebElement yesterdayEmail = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/input"));
            yesterdayEmail.SendKeys(YesterdayEmail);
            log.Info("Insert Email - " + YesterdayEmail);

            //Insert TowrnOrCity for Reset Passowrd
            IWebElement yesterdayCityOrTown = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[2]/input"));
            yesterdayCityOrTown.SendKeys(YestardayTownOrCity);

            //Reset  Password
            IWebElement resetPassword = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[3]/button"));
            resetPassword.Click();
            log.Info("Hit Reset Password");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Quit();
            log.Info("Finish testing Password Reset");
        }

        [Test, Order(4)]
        public void TopMenu()
        {
            log.Info("Start testing Top Menu links");
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Navigate to Mobbossgaming.com
            driver.Url = BaseUrl;
            log.Info(Navigate);
            
            //Click Join Now link
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[1]/a")).Click();
            log.Info("Click Join Now link");

            //Click Promotions link
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[2]/a")).Click();
            log.Info("Click Promotions link");

            //Click i Help link
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[3]/a/i")).Click();
            log.Info("Click i Help link");

            driver.Quit();
            log.Info("Finish testing TopMenu links");
        }

        [Test, Order(5)]
        public void PromotionsSectionLoggedOut()
        {
            log.Info("Start testing Promotion section logged out");

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Navigate to Mobbosgaming.com page
            driver.Url = BaseUrl;
            log.Info(Navigate);

            //Navigate to Promotions section
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[2]/a")).Click();
            log.Info("Navigate to Promotions section");

            //Click first deposit bonus terms
            driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/div[1]/div/article[1]/p[3]/a")).Click();
            log.Info("Click first deposit bonus terms");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //Go Back Promotions Section
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[2]/a")).Click();
            log.Info("Go Back Promotions Section");

            //Navigate to Loyalty Section
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[1]/ul/li[2]/a")).Click();
            log.Info("Navigate to Loyalty Section");

            //Click Start earning reward now
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[2]/section[3]/p/a")).Click();
            log.Info("Click Start earning reward now");

            //Go Back Promotions Section
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[2]/a")).Click();
            log.Info("Go Back Promotions Section");

            //Navigate to Loyalty Section
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[1]/ul/li[2]/a")).Click();
            log.Info("Navigate to Loyalty Section");

            //Click Frequently Asked Questions
            driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/p[3]/a[1]")).Click();
            log.Info("Click Frequently Asked Questions");

            //Go Back Promotions Section
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[2]/a")).Click();
            log.Info("Go Back Promotions Section");

            //Navigate to Loyalty Section
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[1]/ul/li[2]/a")).Click();
            log.Info("Navigate to Loyalty Section");

            //Click Loyalty Bonus Terms
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[2]/p[3]/a[1]")).Click();
            log.Info("Click Loyalty Bonus Terms");

            //Go Back Promotions Sections
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[2]/a")).Click();
            log.Info("Go Back Promotions Section");

            //Click Competitions
            driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[1]/ul/li[3]/a")).Click();
            log.Info("Click Competitions");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Go Back Promotions Sections
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[2]/a")).Click();
            log.Info("Go Back Promotions Section");

            //Click VIP Section
            driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[1]/ul/li[4]/a")).Click();
            log.Info("CLick VIP Section");

            //Click Frequently Asked Questions
            driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/p[9]/a")).Click();
            log.Info("Click Frequently Asked Questions");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Quit();
            log.Info("Finish testing promotion section logged out");
        }

        [Test, Order(6)]
        public void iHelpSectionLoggedOut()
        {
            log.Info("Start testing i Help section logged out");

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Navigate to Mobbosgaming.com page
            driver.Url = BaseUrl;
            log.Info(Navigate);

            //Navigate to iHelp section
            driver.FindElement(By.XPath("/html/body/div[3]/header/nav/div[4]/ul[2]/li[3]/a")).Click();
            log.Info("Navigate to Promotions section");

                //Click Click here link
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/p[5]/a")).Click();
                log.Info("Click Click here link");

                //Navigate to Support section
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[1]/ul/li[1]/a")).Click();
                log.Info("Navigate to Support section");

                //Click FAQ's link
                driver.FindElement(By.XPath("//*[@id='section15']")).Click();
                log.Info("Click FAQ's link");

                //Navigate to Support section
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[1]/ul/li[1]/a")).Click();
                log.Info("Navigate to Support section");

                //Click click here link
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/p[5]/a")).Click();
                log.Info("Click click here link");

                //Navigate to Support section
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[1]/ul/li[1]/a")).Click();
                log.Info("Navigate to Support section");

            //Click FAQ's Section
            driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[1]/ul/li[2]/a")).Click();
            log.Info("Click FAQ's Section");

                //Click FAQ#section1
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[1]/a")).Click();
                log.Info("Click FAQ#section1");

                //Click FAQ#section2
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[2]/a")).Click();
                log.Info("Click FAQ#section2");

                //Click FAQ#section3
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[3]/a")).Click();
                log.Info("Click FAQ#section3");

                //Click FAQ#section4
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[4]/a")).Click();
                log.Info("Click FAQ#section4");

                //Click FAQ#section5
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[5]/a")).Click();
                log.Info("Click FAQ#section5");

                //Click FAQ#section6
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[6]/a")).Click();
                log.Info("Click FAQ#section6");

                //Click FAQ#section7
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[7]/a")).Click();
                log.Info("Click FAQ#section7");

                //Click FAQ#section8
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[8]/a")).Click();
                log.Info("Click FAQ#section8");

                //Click FAQ#section9
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[9]/a")).Click();
                log.Info("Click FAQ#section9");

                //Click FAQ#section10
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[10]/a")).Click();
                log.Info("Click FAQ#section10");

                //Click FAQ#section11
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[11]/a")).Click();
                log.Info("Click FAQ#section11");

                //Click FAQ#section12
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[12]/a")).Click();
                log.Info("Click FAQ#section12");

                //Click FAQ#section13
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[13]/a")).Click();
                log.Info("Click FAQ#section13");

                //Click FAQ#section14
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[2]/ul[1]/li[14]/a")).Click();
                log.Info("Click FAQ#section14");

            driver.Quit();
            log.Info("Finish testing iHelp section logged out");


        }

        [Test, Order(7)]
        public void FooterLinks()
        {
            log.Info("start testing footer links");

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Navigate to mobbyslots page
            driver.Url = BaseUrl;
            log.InfoFormat(BaseUrl);

            //Help & Support
            driver.FindElement(By.XPath("/html/body/div[3]/footer/section[2]/ul/li[1]/a")).Click();
            log.Info("Help & Support link");

            //privacy policy
            driver.FindElement(By.XPath("html/body/div[3]/footer/section[2]/ul/li[2]/a")).Click();
            log.Info("privacy policy link");

            //Terms and conditions
            driver.FindElement(By.XPath("html/body/div[3]/footer/section[2]/ul/li[3]/a")).Click();
            log.Info("Terms and conditions link");

            //responsible gaming
            driver.FindElement(By.XPath("html/body/div[3]/footer/section[2]/ul/li[4]/a")).Click();
            log.Info("responsible gaming link");

            //FAQs
            driver.FindElement(By.XPath("html/body/div[3]/footer/section[2]/ul/li[5]/a")).Click();
            log.Info("FAQs link");

            //close browser
            driver.Quit();

            log.Info("Finish testing logged out links");
        }

        [Test, Order(8)]
        public void LogINLinksGeneral()
        {


            // LOG IN TEST USER
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = BaseUrl;
            log.Info(Navigate);

            IWebElement loginBox = driver.FindElement(By.Id("Username"));
            loginBox.SendKeys(Username);
            log.InfoFormat("Insert Username - " + Username);

            IWebElement pwBox = driver.FindElement(By.Id("Password"));
            pwBox.SendKeys(Password);
            log.InfoFormat("Insert password - " + Password);

            IWebElement loginBtn = driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[1]/form/div[2]/div/button"));
            loginBtn.Click();
            log.Info("Log In User");


            //CLICK LINKS 

            //LOGO
            driver.FindElement(By.XPath("/html/body/div[3]/header/nav/div[1]/form/div/a/img")).Click();
            log.Info("Click LOGO");

            //Top Menu Bar

            //all games
            driver.FindElement(By.XPath("/html/body/div[3]/header/nav/div[4]/ul[1]/li[1]/a")).Click();
            log.Info("Click All Games Section");
            
            //featured
            driver.FindElement(By.XPath("/html/body/div[3]/header/nav/div[4]/ul[1]/li[2]/a")).Click();
            log.Info("Click Featured Section");

            //slots
            driver.FindElement(By.XPath("/html/body/div[3]/header/nav/div[4]/ul[1]/li[3]/a")).Click();
            log.Info("Click Slots Section");

            //table
            driver.FindElement(By.XPath("/html/body/div[3]/header/nav/div[4]/ul[1]/li[4]/a")).Click();
            log.Info("Click Table Section");

            //promotions
            driver.FindElement(By.XPath("/html/body/div[3]/header/nav/div[4]/ul[1]/li[5]/a")).Click();
            log.Info("Click Promotion Section");

                //loyalty
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[1]/ul/li[2]/a")).Click();
                log.Info("Click Loyalty SubSection");

                //competitions
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[1]/ul/li[3]/a")).Click();
                log.Info("Click Competition SubSection");

                //vip members
                driver.FindElement(By.XPath("/html/body/div[3]/section/div[2]/div[1]/ul/li[4]/a")).Click();
                log.Info("Click VIP Memebers SubSection");


           //my account
                driver.FindElement(By.XPath("/html/body/div[3]/header/nav/div[4]/ul[2]/li[1]/a")).Click();
                log.Info("Click My Account Section");


            //i Help
            driver.FindElement(By.XPath("/html/body/div[3]/header/nav/div[4]/ul[2]/li[2]/a")).Click();
            log.Info("Click i Help Section");

            //deposit funds
            //withdraw
            //loyalty
            //back to my account
            //activity
            //transactions
            //responsible gaming
            //betting limits
            //deposit limits select hourly limits
            //deposit limits select daily limits
            //deposit limits select weekly limits
            //deposti limits select montly limits
            //wager limits select hourly limits
            //wager limits select daily limits
            //wager limits select weekly limits
            //wager limits select montly limits
            //save changes
            //back to responsible gaming
            //time alert
            //select duration
            //save changes
            //back to responsible gaming
            //take a break - just visit
            //self-exclude - just visit
            //my details



            //banners

            //view your reward

            //new game promotion Play Now

            //new game promotion terms

            //featured games

            //latest competition more info

            //footer links

            driver.Quit();
            log.Info("Finish testing LogINLinksGeneral ");
        }

        [Test, Order(9)]
        public void MyAccountMenu()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Navigate to Slotsriches page
            driver.Url = BaseUrl;
            log.Info(Navigate);


            //Log In User
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[1]/form/div[3]/a")).Click();

            IWebElement loginBox = driver.FindElement(By.Id("Username"));
            loginBox.SendKeys(Username);
            log.InfoFormat("Insert Username - " + Username);

            IWebElement pwBox = driver.FindElement(By.Id("Password"));
            pwBox.SendKeys(Password);
            log.InfoFormat("Insert password - " + Password);

            IWebElement loginBtn = driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[1]/form/div[2]/div/button"));
            loginBtn.Click();
            log.Info("Log In User");

            //Click My Accounts Menu
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[1]/a")).Click();
            log.Info("Click My Accounts Menu");

            //Click Withdraw Funds Menu
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[1]/ul/li[2]/a")).Click();
            log.Info("Click Withdraw Funds Menu");

            //Click Deposit Funds Menu
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[1]/ul/li[1]/a")).Click();
            log.Info("Click Deposit Funds Menu");

            //Click Loyalty Menu
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[1]/ul/li[3]/a")).Click();
            log.Info("Click Loyalty Menu");

            //Navigate back to My Accounts Menu
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[1]/a")).Click();
            log.Info("Back to My Accounts Menu");

            //Click Activity Menu
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[1]/ul/li[4]/a")).Click();
            log.Info("Click Activity Menu");

            //Click Transation Menu
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[1]/ul/li[5]/a")).Click();
            log.Info("Click Transaction Menu");

            //Click Responsible Gaming Menu
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[1]/ul/li[6]/a")).Click();
            log.Info("Click Responsible Gaming Menu");

            //Click My Details Menu
            driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[1]/ul/li[7]/a")).Click();
            log.Info("Click My Details Menu");

            driver.Quit();
            log.Info("Finish testing My Account Menu");
        }
    }
}
