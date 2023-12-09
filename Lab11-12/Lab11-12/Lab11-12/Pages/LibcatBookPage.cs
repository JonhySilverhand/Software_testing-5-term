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
    internal class LibcatBookPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\'tg-content\']/div/div/div[4]/div/ul/li[5]/a")]
        public IWebElement reviewsButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'comment-editor\']/div/textarea")]
        public IWebElement reviewsInput { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'dle-comments-form\']/div/div/div/div/button")]
        public IWebElement sendCommentButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'fav-id-392345\']")]
        public IWebElement favoriteAddButton { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id=\'tg-content\']/div/div/div[5]/div/div[1]/div[1]/div[3]/div")]
        public IWebElement bookMarkButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\'text\']/div[1]/div/a[1]")]
        public IWebElement secondPageOpen { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'tg-content\']/div/div/div[5]/div/div[1]/div[1]/div[2]/div[3]")]
        public IWebElement intervalChangeButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'tg-content\']/div/div/div[3]/div/ul/li[2]/div[2]/a")]
        public IWebElement autorBooks { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'tg-content\']/div/div/div[3]/div/ul/li[4]/div[2]/a[1]")]
        public IWebElement fantasticBooks { get; set; }




        [FindsBy(How = How.XPath, Using = "//*[@id=\'tg-content\']/div/div/div[4]/div/ul/li[4]/a")]
        public IWebElement similarBooksButton { get; set; }

        

        [FindsBy(How = How.XPath, Using = "//*[@id=\'ratig-layer-392345\']/div/ul/li[2]/b")]
        public IWebElement badReview { get; set; }

    }
}
