using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace GoatAppFramework
{
    public class ProductDetails
    {

        public Control control;
        public IWebDriver driver;
        public ProductDetails(IWebDriver drv)
        {
            driver = drv;
            Data.LoadData();
            control = new Control(drv);
            Reusable.Login(control.txtUserName, control.txtPassword, control.btnSignIN);



        }

        public void TC66644()
        { 
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66644QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66644DESC"));
            Console.WriteLine(Action.IsElement(control.rating_Star).GetAttribute("style"));
            Reusable.verifyImages(Data.get("66644PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"),control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66644MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66644SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66644INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66644AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66644AVLOTOP"));
            Action.verify_Text(control.productDetailsPage, Data.get("66644SPRICE"));


        }

        public void TC66645()
        {
  
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66645QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66645DESC"));
            Reusable.verifyImages(Data.get("66645PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66645MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66645SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66645INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66645AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66645AVLOTOP"));
            Action.verify_Text(control.productDetailsPage, Data.get("66645SPRICE"));
            

        }


        public void TC66646()
        {
            
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66646QRSKU1"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.waitForPage(driver);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66646DESC"));
            Reusable.verifyImages(Data.get("66646PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66646MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66646SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66646INV"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66646AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66646AVLOTOP"));
            Reusable.verifyImages(Data.get("PRICETAG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66646PRICE1"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66646QRSKU2"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Action.verify_Text(control.productDetailsPage, Data.get("66646PROMO2"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66646SALE2"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66646SAVE2"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66646WAS2"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66646QRSKU3"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Action.verify_Text(control.productDetailsPage, Data.get("66646PRICE3"));




        }
        public void TC66647()
        {
            
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66647QRSKU1"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66647DESC"));
            Reusable.verifyImages(Data.get("66647PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66647MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66647SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66647INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66647AVLBDL"));
            Reusable.verifyImages(Data.get("PRICETAG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66647PRICE1"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66647QRSKU2"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Action.verify_Text(control.productDetailsPage, Data.get("66647PROMO2"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66647SALE2"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66647SAVE2"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66647WAS2"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66647QRSKU3"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Action.verify_Text(control.productDetailsPage, Data.get("66647PRICE3"));

        }

        public void TC66648()
        {

            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66648UPCID1"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66648DESC"));
            Reusable.verifyImages(Data.get("66648PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66648MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66648SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66648INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66648AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66648AVLOTOP"));
            Action.verify_Text(control.productDetailsPage, Data.get("66648PRC1"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66648UPCID2"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Action.verify_Text(control.productDetailsPage, Data.get("66648PRC2"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66648SAVE2"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66648WAS2"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66648UPCID3"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Action.verify_Text(control.productDetailsPage, Data.get("66648PRC3"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66648UPCID4"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Action.verify_Text(control.productDetailsPage, Data.get("66648PRC4"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66648SAVE4"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66648WAS4"));
   


        }
        public void TC66649()
        {

            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66649LICPLT"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66649DESC"));
            Reusable.verifyImages(Data.get("66649PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66649MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66649SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66649INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66649AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66649AVLOTOP"));
            Action.verify_Text(control.productDetailsPage, Data.get("66649PRC"));
            Action.click_Element(control.txtBundleAvlbl);
            Action.click_Element(control.O_bundleDetails);
            Reusable.clickDesc("FINC", Data.get("66649DESC"), driver);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.click_Element(control.txtOtherOptions);
            Reusable.clickDesc("FINC",Data.get("66649R2DESC"),driver);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
           



        }
            

        public void TC66650()
        {
    
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66650UPCID"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66650DESC"));
            Reusable.verifyImages(Data.get("66650PIMGs"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66650MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66650SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66650INV"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66650AVLBDL"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66650AVLOTOP"));
            Action.verify_Text(control.productDetailsPage, Data.get("66650PRC"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66650BANNER"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66650SAVE"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66650WAS"));
            Action.verify_Text(control.productDetailsPage, Data.get("66650GC"));


        }

        public void TC66651()
        {
        
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66651QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66651DESC"));
            Reusable.verifyImages(Data.get("66651PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66651MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66651SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66651INV"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66651AVLBDL"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66651AVLOTOP"));
            Action.verify_Text(control.productDetailsPage, Data.get("66651PRC"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66651BANNER"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66651SAVE"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66651WAS"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("66651GC"));


        }

        public void TC70534()
        {
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70534QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.verify_Text(control.ratingHDR, Data.get("RTNGHDR"));
            Action.verify_Text(control.totalRVW, Data.get("70534TOT_RVW"));
            Reusable.IsCustomerRating(control.rating_Star, Data.get("70534AVG_RVW"));
            Reusable.verifyImages(Data.get("70534PIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("70534MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("70534SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("70534SPRICE"));


        }
    }

}

































