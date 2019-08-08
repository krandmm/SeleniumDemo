using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SeleniumDemo
{
    [TestFixture]
    public class SeleniumExample
    {
        private IWebDriver driver;
       

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
         
        }

        [TearDown]
        public void TeardownTest()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

            
        [Test]
        public void Car_insert()
        {
            //Navigate to www.google.com
            driver.Navigate().GoToUrl("http://localhost/form.php");

            //Find the WebElement of the input
            IWebElement element_sellername = driver.FindElement(By.Name("sellername"));
            IWebElement element_address = driver.FindElement(By.Name("address"));
            IWebElement element_city = driver.FindElement(By.Name("city"));
            IWebElement element_phone = driver.FindElement(By.Name("phone"));
            IWebElement element_email = driver.FindElement(By.Name("email"));
            IWebElement element_make = driver.FindElement(By.Name("make"));
            IWebElement element_model = driver.FindElement(By.Name("model"));
            IWebElement element_year = driver.FindElement(By.Name("year"));
            IWebElement element_signup = driver.FindElement(By.Name("signup"));

            //all of element into insert data
            element_sellername.SendKeys("tom");
            element_address.SendKeys("Waterloo");
            element_city.SendKeys("Waterloo");
            element_phone.SendKeys("3230984567");
            element_email.SendKeys("bb@gmail.com");
            element_make.SendKeys("KIA");
            element_model.SendKeys("TOSAN");
            element_year.SendKeys("2010");

            //Submit the input
            element_signup.Submit();

            //Sleep the browser
            Thread.Sleep(5000);
            
        }

        [Test]
        public void Car_list_linkClick()
        {
            //Navigate to localhost/website.php
            driver.Navigate().GoToUrl("http://localhost/website.php");

            IWebElement element_link = driver.FindElement(By.XPath("//a[text()='https://www.jdpower.com/Cars/Ford/Mustang/2012']"));
            element_link.Click();

            //Sleep the browser
            Thread.Sleep(5000);

        }

        [Test]
        public void Car_insert_invalid()
        {
            
            //Create a new ChromeDriver
            driver.Navigate().GoToUrl("http://localhost/form.php");

            //Find the WebElement of the input
            IWebElement element_sellername = driver.FindElement(By.Name("sellername"));
            IWebElement element_address = driver.FindElement(By.Name("address"));
            IWebElement element_city = driver.FindElement(By.Name("city"));
            IWebElement element_phone = driver.FindElement(By.Name("phone"));
            IWebElement element_email = driver.FindElement(By.Name("email"));
            IWebElement element_make = driver.FindElement(By.Name("make"));
            IWebElement element_model = driver.FindElement(By.Name("model"));
            IWebElement element_year = driver.FindElement(By.Name("year"));
            IWebElement element_signup = driver.FindElement(By.Name("signup"));

            //all of element into insert data
            element_sellername.SendKeys("tom");
            element_address.SendKeys("Waterloo");
            element_city.SendKeys("Waterloo");
            element_phone.SendKeys("home");
            element_email.SendKeys("to@yahoo.com");
            element_make.SendKeys("KIA");
            element_model.SendKeys("TOSAN");
            element_year.SendKeys("2010");

            //Submit the input data
            element_signup.Submit();

            //Sleep the browser
            Thread.Sleep(5000);
            
        }


        [Test]
        public void Car_insert_reset()
        {
            //Navigate to localhost/form.php
            driver.Navigate().GoToUrl("http://localhost/form.php");

            //Find the WebElement of the input
            IWebElement element_sellername = driver.FindElement(By.Name("sellername"));
            IWebElement element_address = driver.FindElement(By.Name("address"));
            IWebElement element_city = driver.FindElement(By.Name("city"));
            IWebElement element_phone = driver.FindElement(By.Name("phone"));
            IWebElement element_email = driver.FindElement(By.Name("email"));
            IWebElement element_make = driver.FindElement(By.Name("make"));
            IWebElement element_model = driver.FindElement(By.Name("model"));
            IWebElement element_year = driver.FindElement(By.Name("year"));
            IWebElement element_reset = driver.FindElement(By.Name("reset"));

            //all of element into insert data
            element_sellername.SendKeys("Steven");
            element_address.SendKeys("Waterloo");
            element_city.SendKeys("Waterloo");
            element_phone.SendKeys("0112345473");
            element_email.SendKeys("photo10004@gmail.com");
            element_make.SendKeys("KIA");
            element_model.SendKeys("TOSAN");
            element_year.SendKeys("2010");

            //Submit the input datas
            element_reset.Submit();

            //Sleep the browser
            Thread.Sleep(5000);

        }
        
        [Test]
        public void Car_search()
        {
            //Navigate to localhost/search.php
            driver.Navigate().GoToUrl("http://localhost/search.php");

            //Find the WebElement of the search bar
            IWebElement element_make = driver.FindElement(By.Name("make"));
            IWebElement element_signup = driver.FindElement(By.Name("signup"));


            //element into insert data
            element_make.SendKeys("Ford");

            //Submit the input data
            element_signup.Submit();

            //Sleep the browser
            Thread.Sleep(5000);

        }

        [Test]
        public void Car_search_invalid()
        {

            //Create a new ChromeDriver

            driver.Navigate().GoToUrl("http://localhost/search.php");

            //Find the WebElement of the input
            IWebElement element_make = driver.FindElement(By.Name("make"));
            IWebElement element_signup = driver.FindElement(By.Name("signup"));

            //all of element into insert data
            element_make.SendKeys("");
            
            //Submit the input data
            element_signup.Submit();

            //Sleep the browser
            Thread.Sleep(5000);

        }

    }
}
