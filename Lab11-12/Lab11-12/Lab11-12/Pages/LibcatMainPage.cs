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
    internal class LibcatMainPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='tg-header']/div[2]/div/div/div/div/form/fieldset/input[1]")]
        public IWebElement searchInput { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='tg-header']/div[2]/div/div/div/div/form/fieldset/button/i")]
        public IWebElement searchButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'dle-content\']/div[1]/div/div/div[2]/div/a")]
        public IWebElement bookLinkButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'tg-header\']/div[1]/div/div/div/div/a/span")]
        public IWebElement guestButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'tg-header\']/div[1]/div/div/div/div/ul/li/a[2]")]
        public IWebElement guestMenuLoginButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'tg-header\']/div[1]/div/div/div/div/ul/li/a[1]")]
        public IWebElement favoriteButton { get; set; }


        



        [FindsBy(How = How.XPath, Using = "//*[@id=\'tg-header\']/div[1]/div/div/div/ul/li[1]/a/em")]
        public IWebElement complaintButton { get; set; }



    }
}
