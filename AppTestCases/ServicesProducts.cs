using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GoatAppFramework
{
    public class ServicesProducts
    {
        public Control control;
        public IWebDriver driver;
        public ServicesProducts(IWebDriver drv)
        {
            driver = drv;
            Data.LoadData();
            control = new Control(drv);
            Reusable.Login(control.txtUserName, control.txtPassword, control.btnSignIN);


        }

        public void TC69791()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69791QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69791SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69791AVLSER"));
            Action.verify_Text(control.productDetailsPage, Data.get("69791PRC"));
            Action.click_Element(control.txtServices);
            Action.read_Text(control.titleServices, Data.get("titleSerProducts"));
            Action.verify_Text(control.headerServicesProducts, Data.get("HDRSERPRDS"));
            Action.verifyText(Data.get("HDRSERPRDS"), Data.get("69791SUBGROUPS"), control.GSPAVLBL);
            Reusable.IsRelatedSubGroup(Data.get("69791AFRNTR"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69791AFRNTR"));
            Action.verifyText(Data.get("69791F1SKU"), Data.get("69791F1DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791F2SKU"), Data.get("69791F2DETAILS"), control.servicesDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69791AAUDIO"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69791AAUDIO"));
            Action.verifyText(Data.get("69791A1SKU"), Data.get("69791A1DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791A2SKU"), Data.get("69791A2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791A3SKU"), Data.get("69791A3DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791A4SKU"), Data.get("69791A4DETAILS"), control.servicesDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69791ATVCONNECT"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69791ATVCONNECT"));
            Action.verifyText(Data.get("69791T1SKU"), Data.get("69791T1DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791T2SKU"), Data.get("69791T2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791T3SKU"), Data.get("69791T3DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791T4SKU"), Data.get("69791T4DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791T5SKU"), Data.get("69791T5DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791T6SKU"), Data.get("69791T6DETAILS"), control.servicesDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69791ANETWORKING"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69791ANETWORKING"));
            Action.verifyText(Data.get("69791N1SKU"), Data.get("69791N1DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791N2SKU"), Data.get("69791N2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791N3SKU"), Data.get("69791N3DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69791N4SKU"), Data.get("69791N4DETAILS"), control.servicesDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69791AREMOTE"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69791AREMOTE"));
            Action.verifyText(Data.get("69791R1SKU"), Data.get("69791R1DETAILS"), control.servicesDetails);

        }
        public void TC69792()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69792QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69792SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69792AVLSER"));
            Action.verify_Text(control.productDetailsPage, Data.get("69792PRC"));
            Action.click_Element(control.txtServices);
            Action.read_Text(control.titleServices, Data.get("titleSerProducts"));
            Action.verify_Text(control.headerServicesProducts, Data.get("HDRSERPRDS"));
            Action.verifyText(Data.get("HDRSERPRDS"), Data.get("69792SUBGROUPS"), control.GSPAVLBL);
            Reusable.IsRelatedSubGroup(Data.get("69792AMOUNT"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69792AMOUNT"));
            Action.verifyText(Data.get("69792M1SKU"), Data.get("69792M1DETAILS"), control.servicesDetails);
            Reusable.verifyImages(Data.get("69792M1IMG"), control.Images);
            Action.verifyText(Data.get("69792M2SKU"), Data.get("69792M2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69792M3SKU"), Data.get("69792M3DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69792M4SKU"), Data.get("69792M4DETAILS"), control.servicesDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69792M5SKU"), Data.get("69792M5DETAILS"), control.servicesDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69792TVCONNECT"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69792TVCONNECT"));
            Action.verifyText(Data.get("69792M1SKU"), Data.get("69792M1DETAILS"), control.servicesDetails);
            Reusable.verifyImages(Data.get("69792M2IMG"), control.Images);
            Action.verifyText(Data.get("69792M2SKU"), Data.get("69792M2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69792M3SKU"), Data.get("69792M3DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69792M4SKU"), Data.get("69792M4DETAILS"), control.servicesDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69792M5SKU"), Data.get("69792M5DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69792M6SKU"), Data.get("69792M6DETAILS"), control.servicesDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69792OTHER"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69792OTHER"));
            Action.verifyText(Data.get("69792T1SKU"), Data.get("69792T1DETAILS"), control.servicesDetails);
            Reusable.verifyImages(Data.get("69792T9IMG"), control.Images);
            Action.verifyText(Data.get("69792T2SKU"), Data.get("69792T2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69792T3SKU"), Data.get("69792T3SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T4SKU"), Data.get("69792T4SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T5SKU"), Data.get("69792T5SKU"), control.servicesDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69792T6SKU"), Data.get("69792T6SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T7SKU"), Data.get("69792T7SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T8SKU"), Data.get("69792T8SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T9SKU"), Data.get("69792T9SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T10SKU"), Data.get("69792T10SKU"), control.servicesDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69792T11SKU"), Data.get("69792T11SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T12SKU"), Data.get("69792T12SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T13SKU"), Data.get("69792T13SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T14SKU"), Data.get("69792T14SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T15SKU"), Data.get("69792T15SKU"), control.servicesDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69792T16SKU"), Data.get("69792T16SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T17SKU"), Data.get("69792T17SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T18SKU"), Data.get("69792T18SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T19SKU"), Data.get("69792T19SKU"), control.servicesDetails);
            Action.verifyText(Data.get("69792T20SKU"), Data.get("69792T20SKU"), control.servicesDetails);

        }
        public void TC69793()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69793QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69793SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69793AVLSER"));
            Action.verify_Text(control.productDetailsPage, Data.get("69793PRC"));
            Action.click_Element(control.txtServices);
            Action.read_Text(control.titleServices, Data.get("titleSerProducts"));
            Action.verify_Text(control.headerServicesProducts, Data.get("HDRSERPRDS"));
            Action.verifyText(Data.get("HDRSERPRDS"), Data.get("69793SUBGROUPS"), control.GSPAVLBL);
            Reusable.IsRelatedSubGroup(Data.get("69793HAWAY"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69793HAWAY"));
            Action.verifyText(Data.get("69793H1SKU"), Data.get("69793H1DETAILS"), control.servicesDetails);
            Reusable.verifyImages(Data.get("69793H1IMG"), control.Images);
            Reusable.verifyImages(Data.get("69793H2IMG"), control.Images);
            Action.verifyText(Data.get("69793H2SKU"), Data.get("69793H2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69793H3SKU"), Data.get("69793H3DETAILS"), control.servicesDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69793ADSERVICES"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69793ADSERVICES"));
            Action.verifyText(Data.get("69793A1SKU"), Data.get("69793A1DETAILS"), control.servicesDetails);
            Reusable.verifyImages(Data.get("69793A1IMG"), control.Images);
            Reusable.verifyImages(Data.get("69793A2IMG"), control.Images);
            Action.verifyText(Data.get("69793A2SKU"), Data.get("69793A2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69793A3SKU"), Data.get("69793A3DETAILS"), control.servicesDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69793CREADY"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69793CREADY"));
            Action.verifyText(Data.get("69793C1SKU"), Data.get("69793C1DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69793C2SKU"), Data.get("69793C2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69793C3SKU"), Data.get("69793C3DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69793C4SKU"), Data.get("69793C4DETAILS"), control.servicesDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69793RELOCATE"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69793RELOCATE"));
            Action.verifyText(Data.get("69793R1SKU"), Data.get("69793R1DETAILS"), control.servicesDetails);

        }

        public void TC69795()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69795QRCODE1"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69795SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69795AVLSER1"));
            Action.verify_Text(control.productDetailsPage, Data.get("69795PRC1"));
            Action.click_Element(control.txtServices);
            Action.read_Text(control.titleServices, Data.get("titleSerProducts"));
            Action.verify_Text(control.headerServicesProducts, Data.get("HDRSERPRDS"));
            Action.verifyText(Data.get("69795GSP"), Data.get("69795GSPAVL1"), control.GSPAVLBL);
            Reusable.IsRelatedSubGroup(Data.get("69795GSP"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69795GSP"));
            Action.verifyText(Data.get("69795G1SKU"), Data.get("69795G1DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69795G2SKU"), Data.get("69795G2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69795G3SKU"), Data.get("69795G3DETAILS"), control.servicesDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69795G4SKU"), Data.get("69795G4DETAILS"), control.servicesDetails);
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69795QRCODE2"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            Action.verify_Text(control.productDetailsPage, Data.get("69795AVLSER2"));
            Action.verify_Text(control.productDetailsPage, Data.get("69795PRC2"));
            Action.click_Element(control.txtServices);
            Action.verifyText(Data.get("69795GSP"), Data.get("69795GSPAVL2"), control.GSPAVLBL);
            Reusable.IsRelatedSubGroup(Data.get("69795GSP"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69795GSP"));
            Action.verifyText(Data.get("69795G5SKU"), Data.get("69795G5DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69795G6SKU"), Data.get("69795G6DETAILS"), control.servicesDetails);
            Reusable.verifyImages(Data.get("69795G6IMG"), control.Images);
        }

        public void TC69796()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69796QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69796SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69796AVLSER"));
            Action.verify_Text(control.productDetailsPage, Data.get("69796PRC"));
            Action.click_Element(control.txtServices);
            Action.read_Text(control.titleServices, Data.get("titleSerProducts"));
            Action.verify_Text(control.headerServicesProducts, Data.get("HDRSERPRDS"));
            Action.verifyText(Data.get("69796TBS"), Data.get("69796TBSAVL"), control.GSPAVLBL);
            Reusable.IsRelatedSubGroup(Data.get("69796TBS"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69796TBS"));
            Action.verifyText(Data.get("69796T1SKU"), Data.get("69796T1DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69796T2SKU"), Data.get("69796T2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69796T3SKU"), Data.get("69796T3DETAILS"), control.servicesDetails);


        }
        public void TC69797()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69797QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69797SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69797AVLSER"));
            Action.verify_Text(control.productDetailsPage, Data.get("69797PRC"));
            Action.click_Element(control.txtServices);
            Action.read_Text(control.titleServices, Data.get("titleSerProducts"));
            Action.verify_Text(control.headerServicesProducts, Data.get("HDRSERPRDS"));
            Action.verifyText(Data.get("69797S"), Data.get("69797SAVL"), control.GSPAVLBL);
            Reusable.IsRelatedSubGroup(Data.get("69797S"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69797S"));
            Action.verifyText(Data.get("69797S1SKU"), Data.get("69797S1DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69797S2SKU"), Data.get("69797S2DETAILS"), control.servicesDetails);

        }
        public void TC69798()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69798QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69798SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69798AVLSER"));
            Action.verify_Text(control.productDetailsPage, Data.get("69798PRC"));
            Action.click_Element(control.txtServices);
            Action.read_Text(control.titleServices, Data.get("titleSerProducts"));
            Action.verify_Text(control.headerServicesProducts, Data.get("HDRSERPRDS"));
            Action.verifyText(Data.get("69798TBS"), Data.get("69798TBSAVL"), control.GSPAVLBL);
            Reusable.IsRelatedSubGroup(Data.get("69798TBS"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69798TBS"));
            Action.verifyText(Data.get("69798T1SKU"), Data.get("69798T1DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69798T2SKU"), Data.get("69798T2DETAILS"), control.servicesDetails);
            Action.verifyText(Data.get("69798T3SKU"), Data.get("69798T3DETAILS"), control.servicesDetails);


        }
        public void TC69799()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69799QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69799SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69799AVLSER"));
            Action.verify_Text(control.productDetailsPage, Data.get("69799PRC"));
            Action.click_Element(control.txtServices);
            Action.read_Text(control.titleServices, Data.get("titleSerProducts"));
            Action.verify_Text(control.headerServicesProducts, Data.get("HDRSERPRDS"));
            Action.verifyTextNotExist(control.GSPAVLBL, Data.get("69799TBSAVL"));
            Action.verifyTextNotExist(control.GSPAVLBL, Data.get("69799SAVL"));
            Reusable.IsRelatedSubGroup(Data.get("69799GSP"), driver);

        }

        public void TC69844()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69844QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69844SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69844AVLSER"));
            Action.verify_Text(control.productDetailsPage, Data.get("69844PRC"));
            Action.click_Element(control.txtServices);
            Action.read_Text(control.titleServices, Data.get("titleSerProducts"));
            Action.verify_Text(control.headerServicesProducts, Data.get("HDRSERPRDS"));
            Action.verifyText(Data.get("HDRSERPRDS"), Data.get("69792SUBGROUPS"), control.GSPAVLBL);
            Reusable.IsRelatedSubGroup(Data.get("69844AMOUNT"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69844AMOUNT"));
            Action.verifyText(Data.get("69792M1SKU"), Data.get("69792M1DETAILS"), control.servicesDetails);
            Reusable.clickDesc(Data.get("HDRSERPRDS"), Data.get("69844TTSDESC"), driver);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69844TTSDESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69844M1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69844TTSPRC"));
        }
        public void TC69845()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69845QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69845SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69845AVLSER"));
            Action.verify_Text(control.productDetailsPage, Data.get("69845PRC"));
            Action.click_Element(control.txtServices);
            Action.read_Text(control.titleServices, Data.get("titleSerProducts"));
            Action.verify_Text(control.headerServicesProducts, Data.get("HDRSERPRDS"));
            Action.verifyText(Data.get("HDRSERPRDS"), Data.get("69845SUBGROUPS"), control.GSPAVLBL);
            Reusable.IsRelatedSubGroup(Data.get("69845CONNECTEDHOME"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69845CONNECTEDHOME"));
            Action.verifyText(Data.get("69845H1SKU"), Data.get("69845H1DETAILS"), control.servicesDetails);
            Reusable.clickDesc(Data.get("HDRSERPRDS"), Data.get("69845TTSDESC"), driver);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69845TTSDESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69845H1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69845TTSPRC"));


        }
        public void TC69794()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69794QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69794SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69794AVLSER"));
            Action.verify_Text(control.productDetailsPage, Data.get("69794PRC"));
            Action.click_Element(control.txtServices);
            Action.read_Text(control.titleServices, Data.get("titleSerProducts"));
            Action.verify_Text(control.headerServicesProducts, Data.get("HDRSERPRDS"));
            Action.verifyText(Data.get("HDRSERPRDS"), Data.get("69794SUBGROUPS"), control.GSPAVLBL);
            Reusable.IsRelatedSubGroup(Data.get("69794ADSERVICES"), driver);
            Action.verify_Text(control.InGSPSubgroup, Data.get("69794ADSERVICES"));
            Action.verifyText(Data.get("69794A1SKU"), Data.get("69794A1DETAILS"), control.servicesDetails);
            Reusable.clickDesc(Data.get("HDRSERPRDS"), Data.get("69794TTSDESC"), driver);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69794TTSDESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69794A1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69794TTSPRC"));
        }
    }
}
