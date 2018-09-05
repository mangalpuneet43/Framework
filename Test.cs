using System;
using GoatAppFramework.AppTestCases;
using log4net.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoatAppFramework
{
    [TestClass]
    public class Test
    {

        public IWebDriver driver = null;

        [TestInitialize()]
        public void TestInitialize()
        {
            driver = Action.AppLaunch("chrome");
            TestLog.setContext(this.TestContext);
            TestLog.InitializeResults();


        }

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        
        private TestContext testContextInstance;
       

        [TestMethod]
        public void TC66644()
        {
            new ProductDetails(driver).TC66644();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66645()
        {
            new ProductDetails(driver).TC66645();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66646()
        {
            new ProductDetails(driver).TC66646();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC66647()
        {
            new ProductDetails(driver).TC66647();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66648()
        {
            new ProductDetails(driver).TC66648();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }


        [TestMethod]
        public void TC66649()
        {
            new ProductDetails(driver).TC66649();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66650()
        {
            new ProductDetails(driver).TC66650();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66651()
        {
            new ProductDetails(driver).TC66651();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70534()
        {
            new ProductDetails(driver).TC70534();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66880()
        {
            new BundleAndSave(driver).TC66880();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC66881()
        {
            new BundleAndSave(driver).TC66881();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66882()
        {
            new BundleAndSave(driver).TC66882();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC66884()
        {
            new BundleAndSave(driver).TC66884();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());

        }
        [TestMethod]
        public void TC66885()
        {
            new BundleAndSave(driver).TC66885();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66886()
        {
            new BundleAndSave(driver).TC66886();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());

        }
        [TestMethod]
        public void TC66887()
        {
            new BundleAndSave(driver).TC66887();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());

        }
        [TestMethod]
        public void TC66888()
        {
            new BundleAndSave(driver).TC66888();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC66889()
        {
            new BundleAndSave(driver).TC66889();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
       

      

        [TestMethod]
        public void TC66890()
        {
            new BundleAndSave(driver).TC66890();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());

        }

        
        [TestMethod]
        public void TC66891()
        {
            new BundleAndSave(driver).TC66891();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());

        }
        [TestMethod]
        public void TC66892()
        {
            new BundleAndSave(driver).TC66892();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());

        }
        [TestMethod]
        public void TC66893()
        {
            new BundleAndSave(driver).TC66893();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());

        }

        [TestMethod]
        public void TC66894()
        {
            new BundleAndSave(driver).TC66894();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());

        }
        [TestMethod]
        public void TC66897()
        {
            new BundleAndSave(driver).TC66897();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());

        }


        [TestMethod]
        public void TC66903()
        {
            new OtherOptions(driver).TC66903();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66904()
        {
            new OtherOptions(driver).TC66904();
            TestLog.WriteResults();
            // Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66905()
        {
            new OtherOptions(driver).TC66905();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66906()
        {
            new OtherOptions(driver).TC66906();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC66907()
        {
            new OtherOptions(driver).TC66907();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66908()
        {
            new OtherOptions(driver).TC66908();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC66909()
        {
            new OtherOptions(driver).TC66909();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69211()
        {
            new OpenBox(driver).TC69211();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC69212()
        {
            new OpenBox(driver).TC69212();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC69213()
        {
            new OpenBox(driver).TC69213();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69218()
        {
            new ActivationProducts(driver).TC69218();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC69219()
        {
            new ActivationProducts(driver).TC69219();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69220()
        {
            new ActivationProducts(driver).TC69220();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC69221()
        {
            new ActivationProducts(driver).TC69221();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC69222()
        {
            new ActivationProducts(driver).TC69222();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69223()
        {
            new ActivationProducts(driver).TC69223();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69224()
        {
            new ActivationProducts(driver).TC69224();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69225()
        {
            new ActivationProducts(driver).TC69225();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69226()
        {
            new ActivationProducts(driver).TC69226();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69227()
        {
            new ActivationProducts(driver).TC69227();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69228()
        {
            new RelatedProducts(driver).TC69228();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69229()
        {
            new RelatedProducts(driver).TC69229();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }


        [TestMethod]
        public void TC69230()
        {
            new RelatedProducts(driver).TC69230();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69231()
        {
            new RelatedProducts(driver).TC69231();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69791()
        {
            new ServicesProducts(driver).TC69791();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69792()
        {
            new ServicesProducts(driver).TC69792();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69793()
        {
            new ServicesProducts(driver).TC69793();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69794()
        {
            new ServicesProducts(driver).TC69794();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC69795()
        {
            new ServicesProducts(driver).TC69795();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC69796()
        {
            new ServicesProducts(driver).TC69796();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69797()
        {
            new ServicesProducts(driver).TC69797();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69798()
        {
            new ServicesProducts(driver).TC69798();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69799()
        {
            new ServicesProducts(driver).TC69799();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69844()
        {
            new ServicesProducts(driver).TC69844();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC69845()
        {
            new ServicesProducts(driver).TC69845();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70061()
        {
            new CardMember(driver).TC70061();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70062()
        {
            new CardMember(driver).TC70062();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70063()
        {
            new CardMember(driver).TC70063();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70064()
        {
            new CardMember(driver).TC70064();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70065()
        {
            new CardMember(driver).TC70065();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70066()
        {
            new CardMember(driver).TC70066();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70068()
        {
            new CardMember(driver).TC70068();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70067()
        {
            new CardMember(driver).TC70067();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70069()
        {
            new CardMember(driver).TC70069();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70070()
        {
            new CardMember(driver).TC70070();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70071()
        {
            new CardMember(driver).TC70071();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]
        public void TC70072()
        {
            new CardMember(driver).TC70072();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }

        [TestMethod]

        public void TC70082()
        {
            new BundleAndSave(driver).TC70082();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70083()
        {
            new BundleAndSave(driver).TC70083();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70084()
        {
            new BundleAndSave(driver).TC70084();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70085()
        {
            new BundleAndSave(driver).TC70085();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70087()
        {
            new BundleAndSave(driver).TC70087();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70088()
        {
            new BundleAndSave(driver).TC70088();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70089()
        {
            new BundleAndSave(driver).TC70089();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70090()
        {
            new BundleAndSave(driver).TC70090();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }
        [TestMethod]
        public void TC70091()
        {
            new BundleAndSave(driver).TC70091();
            TestLog.WriteResults();
            Assert.IsFalse(TestLog.returnFinalResult());
        }


        [TestCleanup()]
        public void TestCleanUp()
        {
            Action.closeBrowser(driver);

        }













    }
}
