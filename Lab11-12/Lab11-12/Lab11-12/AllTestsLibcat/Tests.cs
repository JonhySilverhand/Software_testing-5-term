using TESTPOLAST.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.Steps;
using TESTPOLAST.Utils;
using SeleniumExtras.PageObjects;

namespace TESTPOLAST.AllTestsLibcat
{
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        private const string BookName = "Пенелопа Уорд";
        private const string keyToReview = "Крутая книга";
        private const string complaintText = "Жалоба!!!";


        [SetUp]
        public void Init()
        {
            steps.Init();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.Cleanup();
        }

        [Test]
        public void TestSearchBook()
        {
            steps.SearchBookMainPage(BookName);
        }

        [Test]
        public void TestReviewBookSend()
        {
            steps.Login();
            steps.OpenImperialVoyageBook();
            steps.SendReviewKeys(keyToReview);

        }

        [Test]
        public void TestAddFavoriteBook()
        {
            steps.Login();
            steps.addFavoriteBookButtonVoyageBook();
        }

        [Test]
        public void TestDeleteFavoriteBook()
        {
            steps.Login();
            steps.deleteFavoriteBookButtonVoyageBook();
        }

        [Test]
        public void TestBookMark()
        {
            steps.OpenImperialVoyageBook();
            steps.bookMarkClick();
        }

        [Test]
        public void TestIntervalChange()
        {
            steps.OpenImperialVoyageBook();
            steps.intervalChange();
        }

        [Test]
        public void TestAutorBooksOpen()
        {
            steps.OpenImperialVoyageBook();
            steps.openAutorBooks();
        }

        [Test]
        public void TestFantasticBooksOpen()
        {
            steps.OpenImperialVoyageBook();
            steps.fantasticBooksOpen();
        }

        [Test]
        public void TestSimilarBooksOpen()
        {
            steps.OpenImperialVoyageBook();
            steps.similarBooksOpen();

        }

        [Test]
        public void TestBadReviewSend()
        {
            steps.Login();
            steps.OpenImperialVoyageBook();
            steps.badReviewBook();
        }
    }
}
