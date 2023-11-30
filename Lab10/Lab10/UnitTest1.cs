using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace Lab10
{
	[TestFixture]
	public class InstagramTests
	{
		private IWebDriver driver;
		private InstagramPageObject instagramPage;

		[SetUp]
		public void Setup()
		{
			driver = new EdgeDriver();
			driver.Navigate().GoToUrl("https://www.instagram.com/");
			instagramPage = new InstagramPageObject(driver);
		}

		[Test]
		public void TestLoginAndLike()
		{
			driver.Navigate().GoToUrl("https://www.instagram.com/");
			instagramPage.Login("username", "password");
			instagramPage.CloseSaveLoginInfoWindow();
			instagramPage.ClickNotNowForNotifications();
			instagramPage.LikePost();
			Assert.IsTrue(instagramPage.IsPostLiked());
		}

		[Test]
		public void TestLoginAndSearch()
		{
			driver.Navigate().GoToUrl("https://www.instagram.com/");
			instagramPage.Login("username", "password");
			instagramPage.CloseSaveLoginInfoWindow();
			instagramPage.ClickNotNowForNotifications();
			instagramPage.Search("other_username");
			string expectedUsername = "other_username";
			Assert.IsTrue(driver.PageSource.Contains(expectedUsername), $"User with username '{expectedUsername}' not found in search results.");
		}

		[TearDown]
		public void Teardown()
		{
			driver.Quit();
		}
	}
}