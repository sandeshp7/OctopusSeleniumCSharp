	using OpenQA.Selenium;
	namespace OctopusUITest.Framework
	{
	    public class CommonComponents
	    {
			private IWebDriver driver;
			//This is to initialize the WebDrive
			public CommonComponents(IWebDriver driver)
			{
				this.driver = driver;
			}

			//To verify if the element having the text is present on the UI or not
			public bool VerifyTextContains(string text)
			{
				return this.driver.FindElements(By.XPath("//*[contains(text(),'" + text + "')]")).Count > 0;
			}

			//This is the method to perform click action
			public void Click(IWebElement element)
			{
	            element.Click();
			}

			//This is the method to find the elements by the text of the link using the string
			public IWebElement FindByLinkText(string linkText)
			{
				return this.driver.FindElement(By.LinkText(linkText));
			}

			//This is the method to input the string
			public void InputSearch(IWebElement element, string searchTerm)
			{
				element.SendKeys(searchTerm);
			}
			

	    }
	}
