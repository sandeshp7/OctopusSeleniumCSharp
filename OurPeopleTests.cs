    using OctopusUITest.Framework;
    using OctopusUITest.Pages;
    using NUnit.Framework;
    using OpenQA.Selenium.Support.PageObjects;
    namespace OctopusUITest.Tests
    {
        public class OurPeopleTests : BasePage
        {
            [Test]
            public void TestValidPeopleSearch()
            {
                var ourPeoplePage = new OurPeoplePage(GetDriver());
                //Creating an instance of the page component class using PageFactory
                PageFactory.InitElements(GetDriver(),ourPeoplePage);

                //This is where the action is performed
                //Close Pop Up
                ourPeoplePage.Click(ourPeoplePage.FindByLinkText("Continue"));
                ourPeoplePage.InputSearch("Andy");

                Assert.IsTrue(ourPeoplePage.VerifyTextContains("Andy"));

            }

            [Test]
            public void TestInvalidPeopleSearch()
            {
                var ourPeoplePage = new OurPeoplePage(GetDriver());
                //Creating an instance of the page component class using PageFactory
                PageFactory.InitElements(GetDriver(), ourPeoplePage);

                //This is where the action is performed
                //Close Pop Up
                ourPeoplePage.Click(ourPeoplePage.FindByLinkText("Continue"));
                ourPeoplePage.InputSearch("Invalid String");

                Assert.IsTrue(ourPeoplePage.VerifyTextContains("No results found"));

            }

            [Test]
            public void TestNavigateToPeopleIntroPage()
            {
                var ourPeoplePage = new OurPeoplePage(GetDriver());
                //Creating an instance of the page component class using PageFactory
                PageFactory.InitElements(GetDriver(), ourPeoplePage);

                //This is where the action is performed
                //Close Pop Up
                ourPeoplePage.Click(ourPeoplePage.FindByLinkText("Continue"));
                ourPeoplePage.InputSearch("Andy");

                Assert.IsTrue(ourPeoplePage.VerifyTextContains("Andy"));

                ourPeoplePage.ClickResult();

                Assert.IsTrue(ourPeoplePage.VerifyTextContains("Andy"));

            }
        }
    }
