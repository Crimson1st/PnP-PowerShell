using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Management.Automation.Runspaces;

namespace SharePointPnP.PowerShell.Tests.RecycleBin
{
    [TestClass]
    public class GetRecycleBinItemsTests
    {
        #region Test Setup/CleanUp
        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            // This runs on class level once before all tests run
            //using (var ctx = TestCommon.CreateClientContext())
            //{
            //}
        }

        [ClassCleanup]
        public static void Cleanup(TestContext testContext)
        {
            // This runs on class level once
            //using (var ctx = TestCommon.CreateClientContext())
            //{
            //}
        }

        [TestInitialize]
        public void Initialize()
        {
            using (var scope = new PSTestScope())
            {
                // Example
                // scope.ExecuteCommand("cmdlet", new CommandParameter("param1", prop));
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            using (var scope = new PSTestScope())
            {
                try
                {
                    // Do Test Setup - Note, this runs PER test
                }
                catch (Exception)
                {
                    // Describe Exception
                }
            }
        }
        #endregion

        #region Scaffolded Cmdlet Tests
        //TODO: This is a scaffold of the cmdlet - complete the unit test
        //[TestMethod]
        public void GetPnPRecycleBinItemTest()
        {
            using (var scope = new PSTestScope(true))
            {
                // Complete writing cmd parameters

				// From Cmdlet Help: Returns a recycle bin item with a specific identity
				var identity = "";
				// From Cmdlet Help: Return all items in the first stage recycle bin
				var firstStage = "";
				// From Cmdlet Help: Return all items in the second stage recycle bin
				var secondStage = "";
				// From Cmdlet Help: Limits return results to specified amount
				var rowLimit = "";

                var results = scope.ExecuteCommand("Get-PnPRecycleBinItem",
					new CommandParameter("Identity", identity),
					new CommandParameter("FirstStage", firstStage),
					new CommandParameter("SecondStage", secondStage),
					new CommandParameter("RowLimit", rowLimit));
                
                Assert.IsNotNull(results);
            }
        }
        #endregion
    }
}
            