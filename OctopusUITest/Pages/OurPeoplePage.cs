	using System;
	using OpenQA.Selenium;
	using OpenQA.Selenium.Support.PageObjects;
	using OctopusUITest.Framework;
	namespace OctopusUITest.Pages
	{
	/*
	 * This will have all the page specific components.
	 * Page Object Model is used to define the elements
	 */
		public class OurPeoplePage : CommonComponents
	    {
	        /*
		     * WebElements on the search page are defined here.
		     * FindsBy is used to locate the element.
		     */
	        [FindsBy(How = How.XPath, Using = "//input[contains(@class,'string-search')]")]
	        private IWebElement searchTextBox;

	        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'searchResults')]/a")]
			private IWebElement searchResult;

			//This is to initialize the WebDrive
			public OurPeoplePage(IWebDriver driver) : base(driver)
			{
				
			}

			//This is the method which performs an action on the element
			public void InputSearch(String searchTerm)
			{
	            InputSearch(searchTextBox,searchTerm);
			}

			//This is the method which performs an action on the element
			public void ClickResult()
			{
				Click(searchResult);
			}

		}
	}
