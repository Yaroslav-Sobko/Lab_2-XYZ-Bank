using TechTalk.SpecFlow;
using XYZ_Bank;

namespace Tests.Steps
{
	[Binding]
	public class CustomersStepDefinitions : BaseSteps
	{
		private CustomersPage customersPage;
		List<string> actualFirstNames = new List<string>();
		List<string> expectedFirstNames = new List<string>();

		[When(@"I click on the Deleting Button header")]
		public void WhenIClickOnTheFirstNameHeader()
		{
			customersPage = new CustomersPage(driver);
			Thread.Sleep(1000);
			expectedFirstNames = customersPage.GetFirstNames();
			expectedFirstNames.RemoveAt(0);
			customersPage.ClickDeleteCustomer();
			Thread.Sleep(1000);
			actualFirstNames = customersPage.GetFirstNames();
		}

		[Then(@"I should see customers list without one customer")]
		public void ThenIShouldSeeCustomerRecordsSortedInDescendingOrder()
		{
			Assert.AreEqual(actualFirstNames, expectedFirstNames);
		}
	}
}