using OpenQA.Selenium;

namespace ObjectPages
{
	public class BasePage
	{
		protected static IWebDriver driver;

		public BasePage(IWebDriver webDriver)
		{
			driver = webDriver;
		}
	}
}