using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GoatAppFramework
{
    public class OtherOptions
    {

        public Control control;
       public IWebDriver driver;
        public OtherOptions(IWebDriver drv)
        {
            driver = drv;
            Data.LoadData();
            control = new Control(drv);
            Reusable.Login(control.txtUserName, control.txtPassword, control.btnSignIN);
        }



        public void TC66903()
        {
            
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66903QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Reusable.verifyImages(Data.get("66903PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66903PDESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("66903PMODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66903PINV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66903AVLOTOP"));
            Action.verify_Text(control.productDetailsPage, Data.get("66903PPRC"));
            Action.click_Element(control.txtOtherOptions);
            Reusable.verifyImages(Data.get("66903R1IMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.otherOption1, Data.get("66903R1DESC"));
            Action.verify_Text(control.otherOption1, Data.get("66903R1MODEL"));
            Action.verify_Text(control.otherOption1, Data.get("66903R1"));
            Action.verify_Text(control.otherOption1, Data.get("66903R1INV"));
            Action.verify_Text(control.otherOption1, Data.get("66903R1PRC"));



        }

        public void TC66904()
        {
            
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66904UPCID"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66904AVLOTOP"));
            Action.verify_Text(control.productDetailsPage, Data.get("66904PPRC"));
            Action.click_Element(control.txtOtherOptions);
            Reusable.verifyImages(Data.get("66904R1IMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.otherOption1, Data.get("66904R1DESC"));
            Action.verify_Text(control.otherOption1, Data.get("66904R1MODEL"));
            Action.verify_Text(control.otherOption1, Data.get("66904R1"));
            Action.verify_Text(control.otherOption1, Data.get("66904R1INV"));
            Action.verify_Text(control.otherOption1, Data.get("66904R1PRC"));
            Action.click_Element(control.leftNavigation);
            Action.click_Element(control.rightNavigation);
            Reusable.verifyImages(Data.get("66904R2IMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.otherOption2, Data.get("66904R2DESC"));
            Action.verify_Text(control.otherOption2, Data.get("66904R2MODEL"));
            Action.verify_Text(control.otherOption2, Data.get("66904R2"));
            Action.verify_Text(control.otherOption2, Data.get("66904R2INV"));
            Action.verify_Text(control.otherOption2, Data.get("66904R2PRC"));
            Action.verifyTextNotExist(control.otherOption2, Data.get("66904R2WAS"));
            Action.verifyTextNotExist(control.otherOption2, Data.get("66904R2SAVE"));
            Action.verifyTextNotExist(control.otherOption2, Data.get("66904R2BANNER"));



        }

        public void TC66905()
        {
            Reusable.waitForPage(driver);
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66905MODELID"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            //Primary SKU
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66905AVLOTOP"));
            Action.verify_Text(control.productDetailsPage, Data.get("66905PPRC"));
            Action.click_Element(control.txtOtherOptions);
            //Related SKU 1
            Reusable.verifyImages(Data.get("66905R1IMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verifyText(Data.get("66905R1"),Data.get("66905R1DESC"),control.otherOptions);
            Action.verifyText(Data.get("66905R1"),Data.get("66905R1MODEL"),control.otherOptions);
            Action.verifyText(Data.get("66905R1"),Data.get("66905R1"),control.otherOptions);
            Action.verifyText(Data.get("66905R1"),Data.get("66905R1INV"),control.otherOptions);
            Action.verifyText(Data.get("66905R1"),Data.get("66905R1PRC"),control.otherOptions);
            //Related SKU 2
            Reusable.verifyImages(Data.get("66905R2IMG"), control.Images);
            Action.verifyText(Data.get("66905R2"),Data.get("66905R2DESC"),control.otherOptions);
            Action.verifyText(Data.get("66905R2"), Data.get("66905R2MODEL"),control.otherOptions);
            Action.verifyText(Data.get("66905R2"),Data.get("66905R2"), control.otherOptions);
            Action.verifyText(Data.get("66905R2"), Data.get("66905R2INV"),control.otherOptions);
            Action.verifyText(Data.get("66905R2"), Data.get("66905R2PRC"),control.otherOptions);
            Action.verifyTextNotExist(control.otherOption2, Data.get("66905R2WAS"));
            Action.verifyTextNotExist(control.otherOption2, Data.get("66905R2SAVE"));
           // Action.verifyTextNotExist(control.otherOption2, Data.get("66905R2BANNER"));
            //Related SKU 3
            Reusable.verifyImages(Data.get("66905R3IMG"), control.Images);
            Action.verifyText(Data.get("66905R3"), Data.get("66905R3DESC"),control.otherOptions);
            Action.verifyText(Data.get("66905R3"), Data.get("66905R3MODEL"), control.otherOptions);
            Action.verifyText(Data.get("66905R3"),Data.get("66905R3"), control.otherOptions);
            Action.verifyText(Data.get("66905R3"),Data.get("66905R3INV"), control.otherOptions);
            Action.verifyText(Data.get("66905R3"),Data.get("66905R3PRC"), control.otherOptions);
        }

      

        public void TC66906()
        {
            Reusable.waitForPage(driver);
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66906QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            //Primary SKU
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66906AVLOTOP"));
            Reusable.verifyImages(Data.get("66906PIMG"), control.Images);
            Action.click_Element(control.txtOtherOptions);
            //Related SKU 1
            Reusable.verifyImages(Data.get("66906R1IMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verifyText(Data.get("66906R1"), Data.get("66906R1DESC"), control.otherOptions);
            Action.verifyText(Data.get("66906R1"), Data.get("66906R1MODEL"), control.otherOptions);
            Action.verifyText(Data.get("66906R1"), Data.get("66906R1"), control.otherOptions);
            Action.verifyText(Data.get("66906R1"), Data.get("66906R1INV"), control.otherOptions);
            Action.verifyText(Data.get("66906R1"), Data.get("66906R1PRC"), control.otherOptions);
            //Related SKU 2
            Reusable.verifyImages(Data.get("66906R2IMG"), control.Images);
            Action.verifyText(Data.get("66906R2"), Data.get("66906R2DESC"), control.otherOptions);
            Action.verifyText(Data.get("66906R2"), Data.get("66906R2MODEL"), control.otherOptions);
            Action.verifyText(Data.get("66906R2"), Data.get("66906R2"), control.otherOptions);
            Action.verifyText(Data.get("66906R2"), Data.get("66906R2INV"), control.otherOptions);
            Action.verifyText(Data.get("66906R2"), Data.get("66906R2PRC"), control.otherOptions);
            Action.verifyTextNotExist(control.otherOption2, Data.get("66906R2WAS"));
            Action.verifyTextNotExist(control.otherOption2, Data.get("66906R2SAVE"));
            Action.verifyText(Data.get("66906R2"), Data.get("66906R2BANNER"), control.otherOptions);
            //Related SKU3
            Reusable.verifyImages(Data.get("66906R3IMG"), control.Images);
            Action.verifyText(Data.get("66906R3"), Data.get("66906R3DESC"), control.otherOptions);
            Action.verifyText(Data.get("66906R3"), Data.get("66906R3MODEL"), control.otherOptions);
            Action.verifyText(Data.get("66906R3"), Data.get("66906R3"), control.otherOptions);
            Action.verifyText(Data.get("66906R3"), Data.get("66906R3INV"), control.otherOptions);
            Action.verifyText(Data.get("66906R3"), Data.get("66906R3PRC"), control.otherOptions);
            Reusable.scroll(driver);
            //Related SKU4
            Reusable.verifyImages(Data.get("66906R4IMG"), control.Images);
            Action.verifyText(Data.get("66906R4"),Data.get("66906R4DESC"),control.otherOptions);
            Action.verifyText(Data.get("66906R4"),Data.get("66906R4MODEL"),control.otherOptions);
            Action.verifyText(Data.get("66906R4"),Data.get("66906R4"),control.otherOptions);
            Action.verifyText(Data.get("66906R4"),Data.get("66906R4INV"),control.otherOptions);
            Action.verifyText(Data.get("66906R4"),Data.get("66906R4PRC"),control.otherOptions);
        }

        public void TC66907()
        {
       
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66907QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            //Primary SKU
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66907AVLOTOP"));
            Reusable.verifyImages(Data.get("66907PIMG"), control.Images);
            Action.click_Element(control.txtOtherOptions);
            //Related SKU 1
            Reusable.verifyImages(Data.get("66907R1IMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verifyText(Data.get("66907R1SKU"), Data.get("66907R1DESC"), control.otherOptions);
            Action.verifyText(Data.get("66907R1SKU"), Data.get("66907R1MODEL"), control.otherOptions);
            Action.verifyText(Data.get("66907R1SKU"), Data.get("66907R1SKU"), control.otherOptions);
            Action.verifyText(Data.get("66907R1SKU"), Data.get("66907R1INV"), control.otherOptions);
            Action.verifyText(Data.get("66907R1SKU"), Data.get("66907R1PRC"), control.otherOptions);
            //Related SKU 2
            Reusable.verifyImages(Data.get("66907R2IMG"), control.Images);
            Action.verifyText(Data.get("66907R2SKU"), Data.get("66907R2DESC"), control.otherOptions);
            Action.verifyText(Data.get("66907R2SKU"), Data.get("66907R2MODEL"), control.otherOptions);
            Action.verifyText(Data.get("66907R2SKU"), Data.get("66907R2SKU"), control.otherOptions);
            Action.verifyText(Data.get("66907R2SKU"), Data.get("66907R2INV"), control.otherOptions);
            Action.verifyText(Data.get("66907R2SKU"), Data.get("66907R2PRC"), control.otherOptions);
            Action.verifyTextNotExist(control.otherOption2, Data.get("66907R2WAS"));
            Action.verifyTextNotExist(control.otherOption2, Data.get("66907R2SAVE"));
            Action.verifyTextNotExist(control.otherOption2, Data.get("66907R2BANNER"));
            //Related SKU3
            Reusable.verifyImages(Data.get("66907R3IMG"), control.Images);
            Action.verifyText(Data.get("66907R3SKU"), Data.get("66907R3DESC"), control.otherOptions);
            Action.verifyText(Data.get("66907R3SKU"), Data.get("66907R3MODEL"), control.otherOptions);
            Action.verifyText(Data.get("66907R3SKU"), Data.get("66907R3SKU"), control.otherOptions);
            Action.verifyText(Data.get("66907R3SKU"), Data.get("66907R3INV"), control.otherOptions);
            Action.verifyText(Data.get("66907R3SKU"), Data.get("66907R3PRC"), control.otherOptions);
            Reusable.scroll(driver);
            //Related SKU4
            Reusable.verifyImages(Data.get("66907R4IMG"), control.Images);
            Action.verifyText(Data.get("66907R4SKU"), Data.get("66907R4DESC"), control.otherOptions);
            Action.verifyText(Data.get("66907R4SKU"), Data.get("66907R4MODEL"), control.otherOptions);
            Action.verifyText(Data.get("66907R4SKU"), Data.get("66907R4SKU"), control.otherOptions);
            Action.verifyText(Data.get("66907R4SKU"), Data.get("66907R4INV"), control.otherOptions);
            Action.verifyText(Data.get("66907R4SKU"), Data.get("66907R4PRC"), control.otherOptions);
            ////Related SKU5

            Reusable.verifyImages(Data.get("66907R5IMG"), control.Images);
            Action.verifyText(Data.get("66907R5SKU"),Data.get("66907R5DESC"),control.otherOptions);
            Action.verifyText(Data.get("66907R5SKU"),Data.get("66907R5MODEL"),control.otherOptions);
            Action.verifyText(Data.get("66907R5SKU"),Data.get("66907R5SKU"),control.otherOptions);
            Action.verifyText(Data.get("66907R5SKU"),Data.get("66907R5INV"),control.otherOptions);
            Action.verifyText(Data.get("66907R5SKU"),Data.get("66907R5PRC"),control.otherOptions);
        }

        public void TC66908()
        {
            Reusable.waitForPage(driver);
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66908QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            //Primary SKU
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66908AVLOTOP"));
            Reusable.verifyImages(Data.get("66908PIMG"), control.Images);
            Action.click_Element(control.txtOtherOptions);
            Action.verifyText(Data.get("66908R1SKU"),Data.get("66908R1SKU"), control.otherOptions);
            Action.verifyText(Data.get("66908R2SKU"), Data.get("66908R2SKU"),control.otherOptions);
            Action.verifyText(Data.get("66908R3SKU"),Data.get("66908R3SKU"),control.otherOptions);
            Action.verifyText(Data.get("66908R4SKU"),Data.get("66908R4SKU"),control.otherOptions);
            Action.verifyText(Data.get("66908R5SKU"),Data.get("66908R5SKU"),control.otherOptions);
            Reusable.scroll(driver);
            Action.verifyText(Data.get("66908R6SKU"),Data.get("66908R6SKU"),control.otherOptions);
            Action.verifyText(Data.get("66908R7SKU"),Data.get("66908R7SKU"),control.otherOptions);


        }


        public void TC66909()
        {

            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66909QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66909DESC"));
            Reusable.verifyImages(Data.get("66909PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66909MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66909SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66909INV"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66909AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66909AVLOTOP"));
            Action.verify_Text(control.productDetailsPage, Data.get("66909PRC"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66909BANNER"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66909SAVE"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66909WAS"));
            Action.click_Element(control.txtOtherOptions);
            Action.verifyText(Data.get("66909RSKU"), Data.get("66909RSKU"),control.otherOptions);
            Reusable.clickDesc("FINC", Data.get("66909R1DESC"), driver);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66909AVLOTOP"));
            Action.verify_Text(control.productDetailsPage, Data.get("66909RPRC"));



        }
    }
}
