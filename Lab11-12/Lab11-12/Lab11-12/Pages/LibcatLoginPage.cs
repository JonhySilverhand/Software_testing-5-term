using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TESTPOLAST.pages
{
    internal class LibcatLoginPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\'login\']")]
        public IWebElement loginInput { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'password1\']")]
        public IWebElement passwordInput { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'dle-content\']/form/div/div/div[2]/button")]
        public IWebElement loginButton { get; set; }
    }
}
