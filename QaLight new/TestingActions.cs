using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaLight_new
{
    class TestingActions
    {
        [Test]
        public void TestingActionsAndAction()
        {
            IWebDriver driver = null;
            IWebElement element = null;
            IWebElement targetElement = null;

            Actions actions = new Actions(driver);
            actions.MoveToElement(element).ClickAndHold().MoveToElement(targetElement).Release().Perform();

            IAction action = actions.Click().MoveByOffset(5, 5).Click().Build();

        }
    }
}
