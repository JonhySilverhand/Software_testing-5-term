using OpenQA.Selenium;
using TESTPOLAST.Driver;

namespace TESTPOLAST.Utils
{
    public class CommonConditional
    {
        public log logging = new log();

        public WebDriver driver = DriverSingleton.getDriver();
        string test_url = "https://libcat.ru/";


        [SetUp]

        public void Setup()
        {
            logging.logstr = "Beggining Tests";
            logging.LogText();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(test_url);
        }
    }
}
