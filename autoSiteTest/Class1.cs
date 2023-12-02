using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace autoSiteTest
{
    [TestFixture]
    public class Class1
    {
       IWebDriver driver=new ChromeDriver();

        [TestCase]
        public void MainTest()
        {
            driver.Url = "https://www.rudn.ru/";
            Assert.Equals("сибироязвенный скотомогильник", driver.Title);
            driver.Close();
        }
        [TestCase]
        public void MainTest2() 
        {
            driver.Url = "https://www.rudn.ru/";
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"Oval-6\"]"));
            element.Click();


            IWebElement search = driver.FindElement
                (By.XPath("//*[@id=\"app\"]/header[1]/div/div/section[1]/div/div/div/div/form/div/div/input[1]"));
                search.Click();
                search.SendKeys("образование");
        }

    }
}
