using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GoatAppFramework
{
    public class RelatedProducts
    {
        public Control control;
        public IWebDriver driver;
        public RelatedProducts(IWebDriver drv)
        {
            driver = drv;
            Data.LoadData();
            control = new Control(drv);
            Reusable.Login(control.txtUserName, control.txtPassword, control.btnSignIN);


        }
        public void TC69228()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69228QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69228SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69228AVLREL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69228PRC"));
            Action.click_Element(control.txtRelatedProducts);
            Action.read_Text(control.titleRelProducts, Data.get("titleRelProducts"));
            Action.verify_Text(control.headerRelProducts, Data.get("HDRRELPRDS"));
            Action.verify_Text(control.txtConsumable, Data.get("CONSUMABLE"));
            Action.verifyText(Data.get("CONSUMABLE"),Data.get("69228Subgroup1"),control.relatedSubGroups);
            Reusable.IsRelatedSubGroup(Data.get("69228UNDEFINED"), driver);
            //AVSATNDS
            Action.verify_Text(control.InRelSubgroup, Data.get("69228UNDEFINED"));
            Action.verifyText(Data.get("69228S1SKU"), Data.get("69228S1DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S2SKU"), Data.get("69228S2DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S3SKU"), Data.get("69228S3DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S4SKU"), Data.get("69228S4DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69228S5SKU"), Data.get("69228S5DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S6SKU"), Data.get("69228S6DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S7SKU"), Data.get("69228S7DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S8SKU"), Data.get("69228S8DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S9SKU"), Data.get("69228S9DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69228S10SKU"), Data.get("69228S10DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S11SKU"), Data.get("69228S11DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S12SKU"), Data.get("69228S12DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S13SKU"), Data.get("69228S13DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S14SKU"), Data.get("69228S14DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69228S15SKU"), Data.get("69228S15DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S16SKU"), Data.get("69228S16DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S17SKU"), Data.get("69228S17DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S18SKU"), Data.get("69228S18DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69228S19SKU"), Data.get("69228S19DETAILS"), control.relatedDetails);

        }
        public void TC69229()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69229QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69229SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69229AVLREL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69229PRC"));
            Action.click_Element(control.txtRelatedProducts);
            Action.read_Text(control.titleRelProducts, Data.get("titleRelProducts"));
            Action.verify_Text(control.headerRelProducts, Data.get("HDRRELPRDS"));
            Action.verify_Text(control.txtCrossSell, Data.get("CROSSSELL"));
            Action.verifyText(Data.get("CROSSSELL"), Data.get("69229Subgroup1"),control.relatedSubGroups);
            Reusable.IsRelatedSubGroup(Data.get("69229AVSTANDS"), driver);
            //AVSATNDS
            Action.verify_Text(control.InRelSubgroup, Data.get("69229AVSTANDS"));
            Action.verifyText(Data.get("69229S1SKU"), Data.get("69229S1DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S2SKU"), Data.get("69229S2DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S3SKU"), Data.get("69229S3DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S4SKU"), Data.get("69229S4DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69229S5SKU"), Data.get("69229S5DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S6SKU"), Data.get("69229S6DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S7SKU"), Data.get("69229S7DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S8SKU"), Data.get("69229S8DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S9SKU"), Data.get("69229S9DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69229S10SKU"), Data.get("69229S10DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S11SKU"), Data.get("69229S11DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S12SKU"), Data.get("69229S12DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S13SKU"), Data.get("69229S13DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S14SKU"), Data.get("69229S14DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69229S15SKU"), Data.get("69229S15DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S16SKU"), Data.get("69229S16DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S17SKU"), Data.get("69229S17DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S18SKU"), Data.get("69229S18DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S19SKU"), Data.get("69229S19DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69229S20SKU"), Data.get("69229S20DETAILS"), control.relatedDetails);
        }
            public void TC69230()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69230QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69230SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69230AVLREL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69230PRC"));
            Action.click_Element(control.txtRelatedProducts);
            Action.read_Text(control.titleRelProducts, Data.get("titleRelProducts"));
            Action.verify_Text(control.headerRelProducts, Data.get("HDRRELPRDS"));
            Action.verify_Text(control.txtAccessories, Data.get("ACCESSORIES"));
            Action.verifyText(Data.get("ACCESSORIES"),Data.get("69230Subgroup1"),control.relatedSubGroups);
            Action.verifyText(Data.get("ACCESSORIES"), Data.get("69230Subgroup2"), control.relatedSubGroups);
            Reusable.scrollToElement(driver,Data.get("69230UNDEFINED"));
            Reusable.IsRelatedSubGroup(Data.get("69230UNDEFINED"), driver);
            Thread.Sleep(2000);
            //Undefined
            Action.verify_Text(control.InRelSubgroup, Data.get("69230UNDEFINED"));
            Action.verifyText(Data.get("69230S1SKU"), Data.get("69230S1DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S2SKU"), Data.get("69230S2DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S3SKU"), Data.get("69230S3DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S4SKU"), Data.get("69230S4DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69230S5SKU"), Data.get("69230S5DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S6SKU"), Data.get("69230S6DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S7SKU"), Data.get("69230S7DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S8SKU"), Data.get("69230S8DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S9SKU"), Data.get("69230S9DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69230S10SKU"), Data.get("69230S10DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S11SKU"), Data.get("69230S11DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S12SKU"), Data.get("69230S12DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S13SKU"), Data.get("69230S13DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S14SKU"), Data.get("69230S14DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69230S15SKU"), Data.get("69230S15DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S16SKU"), Data.get("69230S16DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S17SKU"), Data.get("69230S17DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S18SKU"), Data.get("69230S18DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S19SKU"), Data.get("69230S19DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230S20SKU"), Data.get("69230S20DETAILS"), control.relatedDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69230OPRSYSTEM"), driver);
            Thread.Sleep(2000);
            ///Operating System SubGroup
            Action.verifyText(Data.get("69230O1SKU"), Data.get("69230O1DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O2SKU"), Data.get("69230O2DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O3SKU"), Data.get("69230O3DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O4SKU"), Data.get("69230O4DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O5SKU"), Data.get("69230O5DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69230O6SKU"), Data.get("69230O6DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O7SKU"), Data.get("69230O7DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O8SKU"), Data.get("69230O8DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O9SKU"), Data.get("69230O9DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O10SKU"), Data.get("69230O10DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69230O11SKU"), Data.get("69230O11DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O12SKU"), Data.get("69230O12DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O13SKU"), Data.get("69230O13DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O14SKU"), Data.get("69230O14DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O15SKU"), Data.get("69230O15DETAILS"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69230O16SKU"), Data.get("69230O16DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O17SKU"), Data.get("69230O17DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O18SKU"), Data.get("69230O18DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O19SKU"), Data.get("69230O19DETAILS"), control.relatedDetails);
            Action.verifyText(Data.get("69230O20SKU"), Data.get("69230O20DETAILS"), control.relatedDetails);




        }

        public void TC69231()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69231QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69231SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69231AVLREL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69231PRC"));
            Action.click_Element(control.txtRelatedProducts);
            Action.read_Text(control.titleRelProducts, Data.get("titleRelProducts"));
            Action.verify_Text(control.headerRelProducts, Data.get("HDRRELPRDS"));
            Action.verify_Text(control.txtAccessories, Data.get("ACCESSORIES"));
            Action.verify_Text(control.txtConsumable, Data.get("CONSUMABLE"));
            Action.verify_Text(control.txtCrossSell, Data.get("CROSSSELL"));
            Action.verifyText(Data.get("CROSSSELL"), Data.get("69231CSSUBGROUP"), control.relatedSubGroups);
            Action.verifyText(Data.get("ACCESSORIES"), Data.get("69231ACSUBGROUP"), control.relatedSubGroups);
            Action.verifyText(Data.get("CONSUMABLE"), Data.get("69231CBSUBGROUP"), control.relatedSubGroups);
            Reusable.IsRelatedSubGroup(Data.get("69231OPTICAL"), driver);
            Action.verify_Text(control.InRelSubgroup, Data.get("69231OPTICAL"));
            Action.verifyText(Data.get("69231L1SKU"), Data.get("69231L1SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L2SKU"), Data.get("69231L2SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L3SKU"), Data.get("69231L3SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L4SKU"), Data.get("69231L4SKU"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69231L5SKU"), Data.get("69231L5SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L6SKU"), Data.get("69231L6SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L7SKU"), Data.get("69231L7SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L8SKU"), Data.get("69231L8SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L9SKU"), Data.get("69231L9SKU"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69231L10SKU"), Data.get("69231L10SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L11SKU"), Data.get("69231L11SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L12SKU"), Data.get("69231L12SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L13SKU"), Data.get("69231L13SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L14SKU"), Data.get("69231L14SKU"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69231L15SKU"), Data.get("69231L15SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L16SKU"), Data.get("69231L16SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L17SKU"), Data.get("69231L17SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L18SKU"), Data.get("69231L18SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L19SKU"), Data.get("69231L19SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231L20SKU"), Data.get("69231L20SKU"), control.relatedDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69231LENSES"), driver);
            Action.verify_Text(control.InRelSubgroup, Data.get("69231LENSES"));
            Action.verifyText(Data.get("69231M1SKU"), Data.get("69231M1SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M2SKU"), Data.get("69231M2SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M3SKU"), Data.get("69231M3SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M4SKU"), Data.get("69231M4SKU"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69231M5SKU"), Data.get("69231M5SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M6SKU"), Data.get("69231M6SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M7SKU"), Data.get("69231M7SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M8SKU"), Data.get("69231M8SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M9SKU"), Data.get("69231M9SKU"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69231M10SKU"), Data.get("69231M10SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M11SKU"), Data.get("69231M11SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M12SKU"), Data.get("69231M12SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M13SKU"), Data.get("69231M13SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M14SKU"), Data.get("69231M14SKU"), control.relatedDetails);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("69231M15SKU"), Data.get("69231M15SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M16SKU"), Data.get("69231M16SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M17SKU"), Data.get("69231M17SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M18SKU"), Data.get("69231M18SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M19SKU"), Data.get("69231M19SKU"), control.relatedDetails);
            Action.verifyText(Data.get("69231M20SKU"), Data.get("69231M20SKU"), control.relatedDetails);
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69231BAGS&CASES"), driver);
            Action.verify_Text(control.InRelSubgroup, Data.get("69231BAGS&CASES"));
            Action.click_Element(control.leftNavigation);
            Reusable.IsRelatedSubGroup(Data.get("69231INSTANT"), driver);
            Action.verify_Text(control.InRelSubgroup, Data.get("69231INSTANT"));

        }
    }
}
