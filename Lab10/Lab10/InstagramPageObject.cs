using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace Lab10
{
	public class InstagramPageObject
	{
		private IWebDriver driver;
		private WebDriverWait wait;

		public InstagramPageObject(IWebDriver driver)
		{
			this.driver = driver;
			this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
		}

		public void AcceptCookies()
		{
			IWebElement acceptCookiesButton = FindElement(By.CssSelector("button._a9--._a9_0"));
			acceptCookiesButton.Click();
		}

		public void Login(string username, string password)
		{
			driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/");

			wait.Until(d => d.FindElement(By.CssSelector("input[name='username']")).Displayed);

			driver.FindElement(By.CssSelector("input[name='username']")).SendKeys(username);
			driver.FindElement(By.CssSelector("input[name='password']")).SendKeys(password);

			FindElement(By.CssSelector("button[type='submit']")).Click();
		}

		public void CloseSaveLoginInfoWindow()
		{
			wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Не сейчас']")));
			IWebElement notNowButton = driver.FindElement(By.XPath("//*[text()='Не сейчас']"));
			notNowButton.Click();

		}

		public void ClickNotNowForNotifications()
		{
			wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Не сейчас']")));
			IWebElement notNowButtonNotifications = FindElement(By.XPath("//*[text()='Не сейчас']"));
			notNowButtonNotifications.Click();
		}

		public void LikePost()
		{
			wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span svg[aria-label='Нравится']")));
			driver.FindElements(By.CssSelector("span svg[aria-label='Нравится']")).First().Click();
		}

		public bool IsPostLiked()
		{
			try
			{
				wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span svg[aria-label='Не нравится']")));
				return FindElement(By.CssSelector("span svg[aria-label='Не нравится']")) != null;
			}
			catch (NoSuchElementException)
			{
				return false;
			}
		}

		public void Search(string searchTerm)
		{
			IWebElement searchIcon = driver.FindElement(By.CssSelector("svg[aria-label='Поисковый запрос']"));
			searchIcon.Click();
			IWebElement searchInput = driver.FindElement(By.CssSelector("input[placeholder='Поиск']"));
			searchInput.SendKeys(searchTerm);
			
		}

		private IWebElement FindElement(By by)
		{
			return wait.Until(d => d.FindElement(by));
		}
	}
}