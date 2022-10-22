using OpenQA.Selenium;

namespace ObjectPages
{
	public class LoginPage : BasePage
	{
		public LoginPage(IWebDriver webDriver) : base(webDriver)
		{

		}

		private IWebElement btnBankManagerLogin => driver.FindElement(By.XPath("//button[@ng-click='manager()']"));

		public void ClickLogin() => btnBankManagerLogin.Click();
	}
}