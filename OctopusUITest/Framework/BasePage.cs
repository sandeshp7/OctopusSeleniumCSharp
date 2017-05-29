	using OpenQA.Selenium;
	using OpenQA.Selenium.Chrome;
	using NUnit.Framework;
	using System;

	namespace OctopusUITest.Framework
	{

	    public class BasePage
	    {
			//This the WebDrive instance
	        private IWebDriver driver;

			//Getter method for the webDriver
			public IWebDriver GetDriver()
			{
				return this.driver;
			}

			/*
		     * This method will always be executed before every test method.
		     * The browser will be launched for each test. 
		     */
			[SetUp]
			public void BeforeMethod()
			{
                // Runs on Chrome.
                //Specify the path of the chrome driver.
                driver = new ChromeDriver("/Users/Sandesh/Desktop"); 
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.octopusinvestments.com/adviser/about-us/our-people");
			}

			/*
		     * This method will always be executed after every test method.
		     * The browser will be closed after each test. 
		     */
			[TearDown]
			public void AfterMethod()
			{
	            driver.Quit();
			}
	    }
	}
