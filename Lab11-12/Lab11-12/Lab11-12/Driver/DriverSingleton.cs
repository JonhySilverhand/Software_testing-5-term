using OpenQA.Selenium;
using OpenQA.Selenium.Edge;


namespace TESTPOLAST.Driver
{
	public class DriverSingleton
    {
        private static WebDriver driver;
        private DriverSingleton() {}
        public static WebDriver getDriver()
        {
            if (null == driver)
            {
				driver = new EdgeDriver();
				driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
				driver.Manage().Window.Maximize();
			}
            return driver;
        }
        public static void CloseDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
