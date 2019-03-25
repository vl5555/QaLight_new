using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace QaLight_new
{
    public class OldQaLightPage
    {
        public IWebDriver driver;

        public OldQaLightPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[name = '_7c8289bf6b8e80c1749ef54ab01b92b8']")]
        public List<IWebElement> course;
        //IWebElement course = driver.FindElement(By.CssSelector("[name = '_7c8289bf6b8e80c1749ef54ab01b92b8']"));

        //[FindsBy(How = How.Id, Using = "z_sender0")]
        public IWebElement surnameField;

        public void SetTextIntoSurnameField(string text)
        {
            driver.FindElement(By.Id("z_sender0")).SendKeys(text);
        }

        //[FindsBy(How = How.Id, Using = "z_text1")]
        public IWebElement NameField
        {
            get {return driver.FindElement(By.Id("z_text1")); }
            //private set;
        }

        [FindsBy(How = How.CssSelector, Using = ("[type = submit]"))]
        public IWebElement submit;

        [FindsBy(How =How.CssSelector, Using = ".alert.alert-error")]
        public IWebElement errorRegistrationPopUp;
        

    }
}
