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
    internal class FavoritePage
    {

        [FindsBy(How = How.Id, Using = "fav-id-392345")]
        public IWebElement deleteFavoriteAddButton { get; set; }
    }
}
