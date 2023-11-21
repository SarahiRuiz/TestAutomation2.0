﻿
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace TestAutomationSimple.PageObject
{
    public class GlobalMethods : SetUp
    {
        public bool EnterText(IWebElement element, string value, int timeOut = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            return wait.Until(d => WaitElementEnter(wait, element, value));
        }

        private bool WaitElementEnter(WebDriverWait wait, IWebElement element, string Value)
        {
            try
            {
                return wait.Until(d =>
                {
                    element.SendKeys(Value);
                    return true;
                });
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ClickOn(IWebElement element, int timeOut = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            return wait.Until(d => WaitElementClicked(wait, element));
        }

        private bool WaitElementClicked(WebDriverWait wait, IWebElement element)
        {
            try
            {
                return wait.Until(d =>
                {
                    element.Click();
                    return true;
                });
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
