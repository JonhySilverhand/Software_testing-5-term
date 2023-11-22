using AutoTests;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

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

    [TearDown]
    public void Teardown()
    {
        driver.Quit();
    }
}
