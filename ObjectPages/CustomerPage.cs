using ObjectPages;
using OpenQA.Selenium;

namespace XYZ_Bank
{
	public class CustomersPage : BasePage
	{
		public CustomersPage(IWebDriver webDriver) : base(webDriver)
		{

		}

		private IWebElement btnDeleteCustomer => driver.FindElement(By.XPath("//tr/td[5]/button"));

		private List<IWebElement> firstNameElements => driver.FindElements(By.XPath("//tr/td[1][@class='ng-binding']")).ToList<IWebElement>();


		public void ClickDeleteCustomer() => btnDeleteCustomer.Click();
		public List<string> GetFirstNames() => firstNameElements.Select(el => el.Text).ToList<string>();
	}
}