using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.Driver;
using TESTPOLAST.pages;
using TESTPOLAST.Pages;
using TESTPOLAST.Utils;

namespace TESTPOLAST.Steps
{
    public class Steps
    {
        CommonConditional commonConditional = new CommonConditional();

        [SetUp]
        public void Init()
        {
            commonConditional.Setup();
        }

        [TearDown]
        public void Cleanup()
        {
            commonConditional.logging.logstr = "Test AddBookBiblioTest Success";
            commonConditional.logging.LogText();
            DriverSingleton.CloseDriver();
        }

        public void Login()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            LibcatLoginPage libcatLoginPage = new LibcatLoginPage();


            PageFactory.InitElements(commonConditional.driver, libcatMainPage);
            libcatMainPage.guestButton.Click();
            libcatMainPage.guestMenuLoginButton.Click();


            PageFactory.InitElements(commonConditional.driver, libcatLoginPage);
            libcatLoginPage.loginInput.SendKeys("Vladosus333");
            libcatLoginPage.passwordInput.SendKeys("V1adosus#333");
            libcatLoginPage.loginButton.Click();
        }

        public void SearchBookMainPage(string BookName)
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);

            libcatMainPage.searchInput.SendKeys(BookName);
            libcatMainPage.searchButton.Click();
        }

        public void OpenImperialVoyageBook()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);

            libcatMainPage.bookLinkButton.Click();
        }

        public void SendReviewKeys(string keyToSend)
        {
            LibcatBookPage libcatBookPage = new LibcatBookPage();
            PageFactory.InitElements(commonConditional.driver, libcatBookPage);

            libcatBookPage.reviewsButton.Click();
            libcatBookPage.reviewsInput.SendKeys(keyToSend);
            libcatBookPage.sendCommentButton.Click();
        }

        public void addFavoriteBookButtonVoyageBook()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);

            libcatMainPage.bookLinkButton.Click();


            LibcatBookPage libcatBookPage = new LibcatBookPage();
            PageFactory.InitElements(commonConditional.driver, libcatBookPage);
            libcatBookPage.favoriteAddButton.Click();
        }

        public void deleteFavoriteBookButtonVoyageBook()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            LibcatLoginPage libcatLoginPage = new LibcatLoginPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);

            PageFactory.InitElements(commonConditional.driver, libcatMainPage);

            libcatMainPage.guestButton.Click();
            libcatMainPage.favoriteButton.Click();

            FavoritePage favoritePage = new FavoritePage();
            PageFactory.InitElements(commonConditional.driver, favoritePage);
            favoritePage.deleteFavoriteAddButton.Click();
        }

        public void bookMarkClick()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);

            LibcatBookPage libcatBookPage = new LibcatBookPage();
            PageFactory.InitElements(commonConditional.driver, libcatBookPage);
            libcatBookPage.secondPageOpen.Click();
            libcatBookPage.bookMarkButton.Click();


        }

        public void intervalChange()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);

            LibcatBookPage libcatBookPage = new LibcatBookPage();
            PageFactory.InitElements(commonConditional.driver, libcatBookPage);
            libcatBookPage.intervalChangeButton.Click();


        }

        public void openAutorBooks()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);

            LibcatBookPage libcatBookPage = new LibcatBookPage();
            PageFactory.InitElements(commonConditional.driver, libcatBookPage);
            libcatBookPage.autorBooks.Click();


        }

        public void fantasticBooksOpen()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);

            LibcatBookPage libcatBookPage = new LibcatBookPage();
            PageFactory.InitElements(commonConditional.driver, libcatBookPage);

            Thread.Sleep(1000);

            libcatBookPage.fantasticBooks.Click();

        }

        public void similarBooksOpen()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);

            LibcatBookPage libcatBookPage = new LibcatBookPage();
            PageFactory.InitElements(commonConditional.driver, libcatBookPage);

            libcatBookPage.similarBooksButton.Click();
            Thread.Sleep(1000);

        }

        public void complaintSend()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);


            libcatMainPage.complaintButton.Click();

            ComplaintPage complaintPage = new ComplaintPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);
            Thread.Sleep(1000);
            complaintPage.googleButton.Click();
        }

        public void badReviewBook()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            PageFactory.InitElements(commonConditional.driver, libcatMainPage);

            LibcatBookPage libcatBookPage = new LibcatBookPage();
            PageFactory.InitElements(commonConditional.driver, libcatBookPage);

            libcatBookPage.badReview.Click();
            Thread.Sleep(1000);

        }


    }
}

