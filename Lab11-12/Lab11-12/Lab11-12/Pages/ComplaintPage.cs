using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;
namespace TESTPOLAST.Pages
{
    internal class ComplaintPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\'recaptcha-anchor\']/div[1]")]
        public IWebElement googleButton { get; set; }
    }
}
