using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace GoatAppFramework
{
    public class BundleAndSave
    {

       public Control control;
       public  IWebDriver driver;
        public BundleAndSave(IWebDriver drv)
        {
            driver = drv;
            Data.LoadData();
            control = new Control(drv);
            Reusable.Login(control.txtUserName, control.txtPassword, control.btnSignIN);

        
        }

        public void TC66880()
        {

            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66880QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66880DESC"));
            Reusable.verifyImages(Data.get("66880PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66880INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66880AVLBDL"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66880BSAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66880BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66880QTY"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66880BPRICE"));
            Action.click_Element(control.O_bundleDetails);
            Action.read_Text(control.titleBundleDetails, Data.get("titleBundleDetails"));
            Action.verify_Text(control.bundleDetails, Data.get("66880BPRICE"));
            Action.verify_Text(control.bundleDetails, Data.get("66880BSAVEDESC"));
            Action.verify_Text(control.bundleDetails, Data.get("66880QTY"));
            Action.verify_Text(control.bundleDetails, Data.get("66880DESC"));
            Action.verify_Text(control.bundleDetails, Data.get("66880MODEL"));
            Action.verify_Text(control.bundleDetails, Data.get("66880SKU"));
            Reusable.verifyImages(Data.get("66880PIMG"),control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"),control.Images);
            Action.verify_Text(control.bundleDetails, Data.get("66880INV"));
            Action.verify_Text(control.bundleDetails, Data.get("66880BSPRICE"));
            Action.verify_Text(control.bundleDetails, Data.get("66880BSAVEAMT"));



        }

        public void TC66881()
        {

            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66881SKU"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66881DESC"));
            Reusable.verifyImages(Data.get("66881PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66881INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66881AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66881SPRICE"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66881BSAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66881BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66881QTY"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66881BPRICE"));
            Action.click_Element(control.O_bundleDetails);
            Action.read_Text(control.titleBundleDetails, Data.get("titleBundleDetails"));
            Action.verify_Text(control.bundleDetails, Data.get("66881BPRICE"));
            Action.verify_Text(control.bundleDetails, Data.get("66881BSAVEAMT"));
            Action.verify_Text(control.bundleDetails, Data.get("66881BSAVEDESC"));
            Action.verify_Text(control.bundleDetails, Data.get("66881QTY"));
            Action.verify_Text(control.bundleDetails, Data.get("66881DESC"));
            Reusable.verifyImages(Data.get("66881PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"),control.Images);
            Action.verify_Text(control.bundleDetails, Data.get("66881INV"));
            Action.verify_Text(control.bundleDetails, Data.get("66881BSPRICE"));


        }

        public void TC66882()
        {
            Reusable.waitForPage(driver);
            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66882QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Reusable.IsEnabled(control.menuHome);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66882DESC"));
            Reusable.verifyImages(Data.get("66882PIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66882MODEL"));
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66882INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66882AVLBDL"));
            Action.click_Element(control.txtBundleSave);
            Reusable.waitForPage(driver);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66882BSAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66882BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66882QTY"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66882BPRICE"));
            Action.click_Element(control.O_bundleDetails);
            Reusable.waitForPage(driver);
            Action.read_Text(control.titleBundleDetails, Data.get("titleBundleDetails"));
            Action.verify_Text(control.bundleDetails, Data.get("66882BSAVEDESC"));
            Action.verify_Text(control.bundleDetails, Data.get("66882BPRICE"));
            Action.verify_Text(control.bundleDetails, Data.get("66882BSAVEAMT"));
            Action.verify_Text(control.bundleDetails, Data.get("66882QTY"));
            Action.verify_Text(control.bundleDetails, Data.get("66882DESC"));
            Action.verify_Text(control.bundleDetails, Data.get("66882SKU"));
            Reusable.verifyImages(Data.get("66882PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.bundleDetails, Data.get("66882INV"));
            Action.verify_Text(control.bundleDetails, Data.get("66882BSKUPRC"));
        }


        public void TC66884()
        {

            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66884P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66884P1DESC"));
            Reusable.verifyImages(Data.get("66884P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66884P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66884P1SKU"));
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66884P1INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66884P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66884P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66884BSAVEPRC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66884BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66884SELECTTXT"));
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails, Data.get("66884BSAVEOFFDESC"));
           // Buy Group2-SKU1
            Action.verifyText(Data.get("66884S1SKU"), Data.get("66884S1BPRC"), control.bundleDetail);
            Action.verifyText(Data.get("66884S1SKU"), Data.get("66884S1BSAVE"), control.bundleDetail);
            Action.verifyText(Data.get("66884S1SKU"), Data.get("66884S1DESC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("66884P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66884S1IMG"), control.Images);
            Action.verifyText(Data.get("66884S1SKU"), Data.get("66884S1MODEL"), control.bundleDetail);
            Action.verifyText(Data.get("66884S1SKU"), Data.get("66884S1INV"), control.bundleDetail);
            Action.verifyText(Data.get("66884S1SKU"), Data.get("66884S1PRC"), control.bundleDetail);
            Reusable.scroll(driver);

           // BuyGroup2 - SKU2
              Action.verifyText(Data.get("66884S2SKU"), Data.get("66884S2BPRC"), control.bundleDetail);
            Action.verifyText(Data.get("66884S2SKU"), Data.get("66884S2BSAVE"), control.bundleDetail);
            Action.verifyText(Data.get("66884S2SKU"), Data.get("66884S2DESC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("66884P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66884S2IMG"), control.Images);
            Action.verifyText(Data.get("66884S2SKU"), Data.get("66884S2MODEL"), control.bundleDetail);
            Action.verifyText(Data.get("66884S2SKU"), Data.get("66884S2INV"), control.bundleDetail);
            Action.verifyText( Data.get("66884S2SKU"), Data.get("66884S2PRC"), control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup2 - SKU3
            Action.verifyText(Data.get("66884S3SKU"), Data.get("66884S3BPRC"), control.bundleDetail);
            Action.verifyText(Data.get("66884S3SKU"), Data.get("66884S3BSAVE"), control.bundleDetail);
            Action.verifyText(Data.get("66884S3SKU"), Data.get("66884S3DESC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("66884P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66884S3IMG"), control.Images);
            Action.verifyText(Data.get("66884S3SKU"), Data.get("66884S3MODEL"),control.bundleDetail);
            Action.verifyText( Data.get("66884S3SKU"), Data.get("66884S3INV"), control.bundleDetail);
            Action.verifyText(Data.get("66884S3SKU"), Data.get("66884S3PRC"), control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup2 - SKU4
            Action.verifyText(Data.get("66884S4SKU"), Data.get("66884S4BPRC"), control.bundleDetail);
            Action.verifyText(Data.get("66884S4SKU"), Data.get("66884S4BSAVE"), control.bundleDetail);
            Action.verifyText(Data.get("66884S4SKU"), Data.get("66884S4DESC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("66884P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66884S4IMG"), control.Images);
            Action.verifyText(Data.get("66884S4SKU"), Data.get("66884S4MODEL"),control.bundleDetail);
            Action.verifyText(Data.get("66884S4SKU"), Data.get("66884S4INV"),control.bundleDetail);
            Action.verifyText(Data.get("66884S4SKU"), Data.get("66884S4PRC"),control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup2 - SKU5
            Action.verifyText(Data.get("66884S5SKU"), Data.get("66884S5BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66884S5SKU"), Data.get("66884S5BSAVE"), control.bundleDetail);
            Action.verifyText(Data.get("66884S5SKU"), Data.get("66884S5DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66884P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66884S5IMG"), control.Images);
            Action.verifyText(Data.get("66884S5SKU"), Data.get("66884S5MODEL"),control.bundleDetail);
            Action.verifyText(Data.get("66884S5SKU"), Data.get("66884S5INV"),control.bundleDetail);
            Action.verifyText(Data.get("66884S5SKU"), Data.get("66884S5PRC"),control.bundleDetail);
        }




        public void TC66885()
        {
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66885P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66885P1DESC"));
            Reusable.verifyImages(Data.get("66885P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66885P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66885P1SKU"));
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66885P1INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66885P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66885P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66885BSAVEPRC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66885BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66885SELECTTXT"));
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails0, Data.get("66885BSAVEDESC"));
            //Buy Group1
            Action.verifyText(Data.get("66885S1SKU"), Data.get("66885S1BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66885S1SKU"), Data.get("66885S1BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66885S1SKU"), Data.get("66885S1DESC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("66885P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66885S1IMG"), control.Images);
            Action.verifyText(Data.get("66885S1SKU"), Data.get("66885S1MODEL"),control.bundleDetail);
            Action.verifyText(Data.get("66885S1SKU"), Data.get("66885S1INV"),control.bundleDetail);
            Action.verifyText(Data.get("66885S1SKU"), Data.get("66885S1PRC"),control.bundleDetail);
            Reusable.scroll(driver);

            //BuyGroup2
            Action.verifyText(Data.get("66885S2SKU"), Data.get("66885S2BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66885S2SKU"), Data.get("66885S2BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66885S2SKU"), Data.get("66885S2DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66885P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66885S2IMG"), control.Images);
            Action.verifyText(Data.get("66885S2SKU"), Data.get("66885S2MODEL"),control.bundleDetail);
            Action.verifyText(Data.get("66885S2SKU"), Data.get("66885S2INV"),control.bundleDetail);
            Action.verifyText(Data.get("66885S2SKU"), Data.get("66885S2PRC"),control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup3
            Action.verifyText(Data.get("66885S3SKU"), Data.get("66885S3BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66885S3SKU"), Data.get("66885S3BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66885S3SKU"), Data.get("66885S3DESC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("66885P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66885S3IMG"), control.Images);
            Action.verifyText(Data.get("66885S3SKU"), Data.get("66885S3MODEL"),control.bundleDetail);
            Action.verifyText(Data.get("66885S3SKU"), Data.get("66885S3INV"),control.bundleDetail);
            Action.verifyText(Data.get("66885S3SKU"), Data.get("66885S3PRC"),control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup4
            Action.verifyText(Data.get("66885S4SKU"), Data.get("66885S4BPRC"), control.bundleDetail);
            Action.verifyText(Data.get("66885S4SKU"), Data.get("66885S4BSAVE"), control.bundleDetail);
            Action.verifyText(Data.get("66885S4SKU"), Data.get("66885S4DESC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("66885P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66885S4IMG"), control.Images);
            Action.verifyText(Data.get("66885S4SKU"), Data.get("66885S4MODEL"), control.bundleDetail);
            Action.verifyText(Data.get("66885S4SKU"), Data.get("66885S4INV"), control.bundleDetail);
            Action.verifyText(Data.get("66885S4SKU"), Data.get("66885S4PRC"), control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup5
            Action.verifyText(Data.get("66885S5SKU"), Data.get("66885S5BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66885S5SKU"), Data.get("66885S5BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66885S5SKU"), Data.get("66885S5DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66885P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66885S5IMG"), control.Images);
            Action.verifyText(Data.get("66885S5SKU"), Data.get("66885S5MODEL"),control.bundleDetail);
            Action.verifyText(Data.get("66885S5SKU"), Data.get("66885S5INV"), control.bundleDetail);
            Action.verifyText(Data.get("66885S5SKU"), Data.get("66885S5PRC"),control.bundleDetail);
            Reusable.clickDesc("FINC",Data.get("66885S1DESC"), driver);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));


        }
        public void TC66886()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66886P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66886P1DESC"));
            Reusable.verifyImages(Data.get("66886P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66886P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66886P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66886P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66886P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66886BSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66886BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66886QTYTXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66886BPRC"));
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails, Data.get("66886BPRC"));
            Action.verify_Text(control.bundleDetails, Data.get("66886BSAVEOFF"));
            Action.verify_Text(control.bundleDetails, Data.get("66886BSAVEDESC"));

            // Buy Group1

            Action.verify_Text(control.anyBundle, Data.get("66886P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66886P1DESC"));
            Reusable.verifyImages(Data.get("66886P1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66886P1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66886P1INV"));
            Action.verify_Text(control.anyBundle, Data.get("66886P1PRC"));

            //  BuyGroup2
            Action.verify_Text(control.anyBundle, Data.get("66886S1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66886S1DESC"));
            Reusable.verifyImages(Data.get("66886S1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66886S1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66886S1INV"));
            Action.verify_Text(control.anyBundle, Data.get("66886S1PRC"));

            Reusable.clickDesc("FINC",Data.get("66886S1DESC"), driver);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66886S1SKU"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66886S2"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.click_Element(control.txtBundleSave);
            Action.click_Element(control.O_bundleDetails);      
            Action.verify_Text(control.anyBundle, Data.get("66886S2PRC"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66886S3"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.click_Element(control.txtBundleSave);
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.anyBundle, Data.get("66886S3PRC"));

        }


        public void TC66887()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66887P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66887P1DESC"));
            Reusable.verifyImages(Data.get("66887P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66887P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66887P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66887P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66887P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66887BSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66887BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66887QTYTXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66887BPRC"));
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails, Data.get("66887BPRC"));
            Action.verify_Text(control.bundleDetails, Data.get("66887BSAVEOFFDESC"));

            // Buy Group1

            Action.verify_Text(control.anyBundle, Data.get("66887P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66887P1DESC"));
            Reusable.verifyImages(Data.get("66887P1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66887P1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66887P1INV"));
            Action.verify_Text(control.anyBundle, Data.get("66887P1PRC"));

            //  BuyGroup2
            Action.verify_Text(control.anyBundle, Data.get("66887S1DESC"));
            Reusable.verifyImages(Data.get("66887S1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66887S1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66887S1INV"));
            Action.verify_Text(control.anyBundle, Data.get("66887S1PRC"));
        }

          

       
        public void TC66888()
        {
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66888P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66888P1DESC"));
            Reusable.verifyImages(Data.get("66888P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66888P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66888P1SKU"));
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66888P1INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66888P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66888P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66888BSAVEPRC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66888BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66888SELECTTXT"));
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails0, Data.get("66888BSAVEOFFDESC"));
            //Buy Group1
            Action.verifyText(Data.get("66888S1SKU"), Data.get("66888S1BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66888S1SKU"), Data.get("66888S1BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66888S1SKU"), Data.get("66888S1DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66888P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66888S1IMG"), control.Images);
            Action.verifyText(Data.get("66888S1SKU"), Data.get("66888S1MODEL"),control.bundleDetail);
            Action.verifyText(Data.get("66888S1SKU"), Data.get("66888S1INV"), control.bundleDetail);
            Action.verifyText(Data.get("66888S1SKU"), Data.get("66888S1PRC"),control.bundleDetail);
            Reusable.scroll(driver);

            //BuyGroup2
            Action.verifyText(Data.get("66888S2SKU"), Data.get("66888S2BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66888S2SKU"), Data.get("66888S2BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66888S2SKU"), Data.get("66888S2DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66888P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66888S2IMG"), control.Images);
            Action.verifyText( Data.get("66888S2SKU"), Data.get("66888S2MODEL"),control.bundleDetail);
            Action.verifyText( Data.get("66888S2SKU"), Data.get("66888S2INV"),control.bundleDetail);
            Action.verifyText( Data.get("66888S2SKU"), Data.get("66888S2PRC"),control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup3
            Action.verifyText(Data.get("66888S3SKU"), Data.get("66888S3BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66888S3SKU"), Data.get("66888S3BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66888S3SKU"), Data.get("66888S3DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66888P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66888S3IMG"), control.Images);
            Action.verifyText(Data.get("66888S3SKU"), Data.get("66888S3MODEL"),control.bundleDetail);
            Action.verifyText(Data.get("66888S3SKU"), Data.get("66888S3INV"), control.bundleDetail);
            Action.verifyText(Data.get("66888S3SKU"), Data.get("66888S3PRC"), control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup4
            Action.verifyText(Data.get("66888S4SKU"), Data.get("66888S4BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66888S4SKU"), Data.get("66888S4BSAVE"), control.bundleDetail);
            Action.verifyText( Data.get("66888S4SKU"), Data.get("66888S4DESC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("66888P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66888S4IMG"), control.Images);
            Action.verifyText(Data.get("66888S4SKU"), Data.get("66888S4MODEL"), control.bundleDetail);
            Action.verifyText( Data.get("66888S4SKU"), Data.get("66888S4INV"), control.bundleDetail);
            Action.verifyText(Data.get("66888S4SKU"), Data.get("66888S4PRC"), control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup5
            Action.verifyText(Data.get("66888S5SKU"), Data.get("66888S5BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66888S5SKU"), Data.get("66888S5BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66888S5SKU"), Data.get("66888S5DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66888P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66888S5IMG"), control.Images);
            Action.verifyText(Data.get("66888S5SKU"), Data.get("66888S5MODEL"),control.bundleDetail);
            Action.verifyText(Data.get("66888S5SKU"), Data.get("66888S5INV"),control.bundleDetail);
            Action.verifyText(Data.get("66888S5SKU"), Data.get("66888S5PRC"),control.bundleDetail);

            Reusable.clickDesc("FINC", Data.get("66888S4DESC"), driver);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));


        }

        public void TC66889()
        {
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66889P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66889P1DESC"));
            Reusable.verifyImages(Data.get("66889P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66889P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66889P1SKU"));
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66889P1INV"));
            Action.verify_Text(control.productDetailsPage, Data.get("66889P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66889P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66889BSAVEPRC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66889BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66889SELECTTXT"));
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails0, Data.get("66889BSAVEOFFDESC"));
            //Buy Group1
            Action.verifyText(Data.get("66889S1SKU"), Data.get("66889S1BPRC"),control.bundleDetail);
            Action.verifyText( Data.get("66889S1SKU"), Data.get("66889S1BSAVE"),control.bundleDetail);
            Action.verifyText( Data.get("66889S1SKU"), Data.get("66889S1DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66889P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66889S1IMG"), control.Images);
            Action.verifyText(Data.get("66889S1SKU"), Data.get("66889S1MODEL"),control.bundleDetail);
            Action.verifyText( Data.get("66889S1SKU"), Data.get("66889S1INV"),control.bundleDetail);
            Action.verifyText(Data.get("66889S1SKU"), Data.get("66889S1PRC"),control.bundleDetail);
            Reusable.scroll(driver);

            //BuyGroup2
            Action.verifyText(Data.get("66889S2SKU"), Data.get("66889S2BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66889S2SKU"), Data.get("66889S2BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66889S2SKU"), Data.get("66889S2DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66889P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66889S2IMG"), control.Images);
            Action.verifyText( Data.get("66889S2SKU"), Data.get("66889S2MODEL"),control.bundleDetail);
            Action.verifyText(Data.get("66889S2SKU"), Data.get("66889S2INV"),control.bundleDetail);
            Action.verifyText(Data.get("66889S2SKU"), Data.get("66889S2PRC"),control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup3
            Action.verifyText(Data.get("66889S3SKU"), Data.get("66889S3BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66889S3SKU"), Data.get("66889S3BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66889S3SKU"), Data.get("66889S3DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66889P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66889S3IMG"), control.Images);
            Action.verifyText( Data.get("66889S3SKU"), Data.get("66889S3MODEL"),control.bundleDetail);
            Action.verifyText(Data.get("66889S3SKU"), Data.get("66889S3INV"),control.bundleDetail);
            Action.verifyText( Data.get("66889S3SKU"), Data.get("66889S3PRC"),control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup4
            Action.verifyText(Data.get("66889S4SKU"), Data.get("66889S4BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66889S4SKU"), Data.get("66889S4BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66889S4SKU"), Data.get("66889S4DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66889P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66889S4IMG"), control.Images);
            Action.verifyText(Data.get("66889S4SKU"), Data.get("66889S4MODEL"),control.bundleDetail);
            Action.verifyText( Data.get("66889S4SKU"), Data.get("66889S4INV"),control.bundleDetail);
            Action.verifyText( Data.get("66889S4SKU"), Data.get("66889S4PRC"),control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup5
            Action.verifyText(Data.get("66889S5SKU"), Data.get("66889S5BPRC"),control.bundleDetail);
            Action.verifyText(Data.get("66889S5SKU"), Data.get("66889S5BSAVE"),control.bundleDetail);
            Action.verifyText(Data.get("66889S5SKU"), Data.get("66889S5DESC"),control.bundleDetail);
            Reusable.verifyImages(Data.get("66889P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66889S5IMG"), control.Images);
            Action.verifyText( Data.get("66889S5SKU"), Data.get("66889S5MODEL"),control.bundleDetail);
            Action.verifyText( Data.get("66889S5SKU"), Data.get("66889S5INV"),control.bundleDetail);
            Action.verifyText( Data.get("66889S5SKU"), Data.get("66889S5PRC"),control.bundleDetail);
            Reusable.scrollUp(driver);
            Reusable.clickDesc("FINC", Data.get("66888S3DESC"), driver);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));


        }

        public void TC66890()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66890P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66890P1DESC"));
            Reusable.verifyImages(Data.get("66890P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66890P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66890P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66890P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66890P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66890BSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66890BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66890QTYTXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66890BPRC"));
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails, Data.get("66890BPRC"));
            Action.verify_Text(control.bundleDetails, Data.get("66890BSAVEOFFDESC"));
            Action.verify_Text(control.anyBundle, Data.get("66890BSAVE"));

            // Buy Group1

            Action.verifyTextNotExist(control.anyBundle, Data.get("66890P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66890P1DESC"));
            Reusable.verifyImages(Data.get("66890P1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66890P1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66890P1INV"));
            Action.verify_Text(control.anyBundle, Data.get("66890P1PRC"));

            //  BuyGroup2
            Action.verify_Text(control.anyBundle, Data.get("66890S1DESC"));
            Reusable.verifyImages(Data.get("66890S1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66890S1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66890S1SKU"));
            Action.verify_Text(control.anyBundle, Data.get("66890S1INV"));
            Action.verify_Text(control.anyBundle, Data.get("66890S1PRC"));
            //  BuyGroup3
            Action.verify_Text(control.anyBundle, Data.get("66890S2DESC"));
            Reusable.verifyImages(Data.get("66890S2IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66890S2MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66890S2SKU"));
            Action.verify_Text(control.anyBundle, Data.get("66890S2INV"));
            Action.verify_Text(control.anyBundle, Data.get("66890S2PRC"));
        }
        public void TC66891()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66891P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66891P1DESC"));
            Reusable.verifyImages(Data.get("66891P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66891P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66891P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66891P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66891P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66891BSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66891BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66891QTYTXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66891BPRC"));
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails, Data.get("66891BPRC"));
            Action.verify_Text(control.bundleDetails, Data.get("66891BSAVEOFFDESC"));
        

            // Buy Group1

            Action.verifyTextNotExist(control.anyBundle, Data.get("66891P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66891P1DESC"));
            Reusable.verifyImages(Data.get("66891P1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66891P1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66891P1INV"));
            Action.verify_Text(control.anyBundle, Data.get("66891P1PRC"));

            //  BuyGroup2
            Action.verifyTextNotExist(control.anyBundle, Data.get("66891P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66891S1DESC"));
            Reusable.verifyImages(Data.get("66891S1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66891S1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66891S1SKU"));
            Action.verify_Text(control.anyBundle, Data.get("66891S1INV"));
            Action.verify_Text(control.anyBundle, Data.get("66891S1PRC"));
            //  BuyGroup3
            Reusable.scroll(driver);
            Action.verifyTextNotExist(control.anyBundle, Data.get("66891P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66891S2DESC"));
            Reusable.verifyImages(Data.get("66891S2IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66891S2MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66891S2SKU"));
            Action.verify_Text(control.anyBundle, Data.get("66891S2INV"));
            Action.verify_Text(control.anyBundle, Data.get("66891S2PRC"));
        }

        public void TC66892()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66892P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66892P1DESC"));
            Reusable.verifyImages(Data.get("66892P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66892P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66892P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66892P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66892P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66892BSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66892BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66892QTYTXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66892BPRC"));
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails, Data.get("66892BPRC"));
            Action.verify_Text(control.bundleDetails, Data.get("66892BSAVEOFFDESC"));
            Action.verify_Text(control.bundleDetails, Data.get("66892BSAVE"));


            // Buy Group1

            Action.verifyTextNotExist(control.anyBundle, Data.get("66892P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66892P1DESC"));
            Reusable.verifyImages(Data.get("66892P1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66892P1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66892P1PRC"));

            //  BuyGroup2
            Action.verifyTextNotExist(control.anyBundle, Data.get("66892P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66892S1DESC"));
            Reusable.verifyImages(Data.get("66892S1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66892S1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66892S1SKU"));
            Action.verify_Text(control.anyBundle, Data.get("66892S1PRC"));
            //  BuyGroup3
            Reusable.scroll(driver);
            Action.verifyTextNotExist(control.anyBundle, Data.get("66892P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66892S2DESC"));
            Reusable.verifyImages(Data.get("66892S2IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66892S2MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66892S2SKU"));
            Action.verify_Text(control.anyBundle, Data.get("66892S2PRC"));
            //  BuyGroup4
            Reusable.scroll(driver);
            Action.verifyTextNotExist(control.anyBundle, Data.get("66892P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66892S3DESC"));
            Reusable.verifyImages(Data.get("66892S3IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66892S3MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66892S3SKU"));
            Action.verify_Text(control.anyBundle, Data.get("66892S3PRC"));
        }



        public void TC66893()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66893P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66893P1DESC"));
            Reusable.verifyImages(Data.get("66893P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66893P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66893P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66893P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66893P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66893BSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66893BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66893QTYTXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66893BPRC"));

            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails, Data.get("66893BPRC"));
            Action.verify_Text(control.bundleDetails, Data.get("66893BSAVEOFFDESC"));
            Action.verify_Text(control.bundleDetails, Data.get("66893BSAVE"));

            // Buy Group1

            Action.verify_Text(control.anyBundle,Data.get("66893P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66893P1DESC"));
            Reusable.verifyImages(Data.get("66893P1IMG"), control.Images);
            Action.verify_Text(control.anyBundle,Data.get("66893P1MODEL"));
            Action.verify_Text(control.anyBundle,Data.get("66893P1INV"));
            Action.verify_Text(control.anyBundle,Data.get("66893P1PRC"));

           // BuyGroup2
            Action.verify_Text(control.anyBundle, Data.get("66893S1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("66893S1DESC"));
            Reusable.verifyImages(Data.get("66893S1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66893S1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66893S1INV"));
            Action.verify_Text(control.anyBundle, Data.get("66893S1PRC"));

           // BuyGroup3


            Action.verify_Text(control.anyBundle, Data.get("66893S2DESC"));
            Reusable.verifyImages(Data.get("66893S2IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66893S2MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66893S2INV"));
            Action.verify_Text(control.anyBundle, Data.get("66893S2PRC"));

        }

        public void TC66894()
        {
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66894P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("66894P1DESC"));
            Reusable.verifyImages(Data.get("66894P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("66894P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66894P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("66894P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66894P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66894BSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66894BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66894QTYTXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66894BPRC"));
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails, Data.get("66894BPRC"));
            Action.verify_Text(control.bundleDetails, Data.get("66894BSAVEOFFDESC"));
            Action.verify_Text(control.bundleDetails, Data.get("66894BSAVE"));

            //Buy Group1
            Action.verify_Text(control.anyBundle,Data.get("66894P1DESC"));
            Reusable.verifyImages(Data.get("66894P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66894S1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("66894P1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("66894P1INV"));
            Action.verify_Text(control.anyBundle, Data.get("66894P1PRC"));

            //BuyGroup2
            Action.verify_Text(control.anyBundle, Data.get("66894S1QTYTXT"));
            Action.verify_Text(control.anyBundle,Data.get("66894S1DESC"));
            Reusable.verifyImages(Data.get("66894P1IMG"), control.Images);
            Reusable.verifyImages(Data.get("66894S1IMG"), control.Images);
            Action.verify_Text(control.anyBundle,Data.get("66894S1MODEL"));
            Action.verify_Text(control.anyBundle,Data.get("66894S1INV"));
            Action.verify_Text(control.anyBundle, Data.get("66894S1PRC"));


        }

        public void TC66897()
        {
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("66897P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.verify_Text(control.productDetailsPage, Data.get("66897P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("66897P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B1DESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B1SAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897QTYTXT1"));

            Action.verify_Text(control.bundleOffersPage, Data.get("66897B2DESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B2SAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897QTYTXT2"));

            Action.verify_Text(control.bundleOffersPage, Data.get("66897B3DESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B3SAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897QTYTXT3"));

            Action.verify_Text(control.bundleOffersPage, Data.get("66897B4DESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B4SAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897QTYTXT4"));

            Action.verify_Text(control.bundleOffersPage, Data.get("66897B5DESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B5SAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897QTYTXT5"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B5PRC"));
           
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B6DESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B6SAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897QTYTXT6"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B6PRC"));

            Action.verify_Text(control.bundleOffersPage, Data.get("66897B7DESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B7SAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897QTYTXT7"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B7PRC"));
           
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B8DESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B8SAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897QTYTXT8"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B8PRC"));

            Action.verify_Text(control.bundleOffersPage, Data.get("66897B9DESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B9SAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897QTYTXT9"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B9PRC"));

            Action.verify_Text(control.bundleOffersPage, Data.get("66897B10DESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B10SAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897QTYTXT10"));
            Action.verify_Text(control.bundleOffersPage, Data.get("66897B10PRC"));

            //Action.click_Element(control.iconBDetail1);
            //Action.verify_Text(control.bundleDetails0, Data.get("66897B1SAVEDESC"));
            //Action.click_Element(control.leftNavigation);
            //Action.click_Element(control.iconBDetail2);
            //Action.verify_Text(control.bundleDetails0, Data.get("66897B2SAVEDESC"));
            //Action.click_Element(control.leftNavigation);
            //Action.click_Element(control.iconBDetail3);
            //Action.verify_Text(control.bundleDetails, Data.get("66897B3SAVEDESC"));
            //Action.click_Element(control.leftNavigation);
            //Action.click_Element(control.iconBDetail4);
            //Action.verify_Text(control.bundleDetails, Data.get("66897B4SAVEDESC"));
            //Action.click_Element(control.leftNavigation);
            //Action.click_Element(control.iconBDetail5);
            //Action.verify_Text(control.bundleDetails, Data.get("66897B5SAVEDESC"));
            //Action.click_Element(control.leftNavigation);

            ////Reusable.scroll(driver);
            ////Reusable.scrollUp(driver);
            ////Action.click_Element(control.iconBDetail6);
            ////Action.verify_Text(control.bundleDetails, Data.get("66897B9SAVEDESC"));
            ////Action.click_Element(control.leftNavigation);
            ////Reusable.scrollToElement(driver, control.iconBDetail7);
            ////Action.click_Element(control.iconBDetail7);
            ////Action.verify_Text(control.bundleDetails, Data.get("66897B10SAVEDESC"));
            ////Action.click_Element(control.leftNavigation);
            ////Action.click_Element(control.iconBDetail8);
            ////Action.verify_Text(control.bundleDetails, Data.get("66897B6SAVEDESC"));
            ////Action.click_Element(control.leftNavigation);
            ////Action.click_Element(control.iconBDetail9);
            ////Action.verify_Text(control.bundleDetails, Data.get("66897B7SAVEDESC"));
            ////Action.click_Element(control.leftNavigation);
            ////Reusable.scroll(driver);
            ////Action.click_Element(control.iconBDetail10);
            ////Action.verify_Text(control.bundleDetails, Data.get("66897B8SAVEDESC"));
            ////Action.click_Element(control.leftNavigation);
        }

        public void TC70082()
        {

            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70082P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70082P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("70082P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("70082P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70082BSAVEPRC"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"),control.Images);
            Action.verify_Text(control.bundleOffersPage, Data.get("70082BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70082SELECTTXT"));
            Action.click_Element(control.O_bundleDetails);
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.bundleDetails, Data.get("70082BSAVEOFFDESC"));
          
            // Buy Group2-SKU1

            Action.verifyText(Data.get("70082S1SKU"), Data.get("70082S1BPRC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verifyText(Data.get("70082S1SKU"), Data.get("70082S1ASAVE"), control.bundleDetail);
            Action.verifyText(Data.get("70082S1SKU"), Data.get("70082S1DESC"), control.bundleDetail);
            Action.verifyText(Data.get("70082S1SKU"), Data.get("70082S1PRC"), control.bundleDetail);
            Reusable.scroll(driver);

            // BuyGroup2 - SKU2
            Action.verifyText(Data.get("70082S2SKU"), Data.get("70082S2BPRC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verifyText(Data.get("70082S2SKU"), Data.get("70082S2ASAVE"), control.bundleDetail);
            Action.verifyText(Data.get("70082S2SKU"), Data.get("70082S2DESC"), control.bundleDetail);
            Action.verifyText(Data.get("70082S2SKU"), Data.get("70082S2PRC"), control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup2 - SKU3
            Action.verifyText(Data.get("70082S3SKU"), Data.get("70082S3BPRC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verifyText(Data.get("70082S3SKU"), Data.get("70082S3ASAVE"), control.bundleDetail);
            Action.verifyText(Data.get("70082S3SKU"), Data.get("70082S3MODEL"), control.bundleDetail);
            Action.verifyText(Data.get("70082S3SKU"), Data.get("70082S3PRC"), control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup2 - SKU4
            Action.verifyText(Data.get("70082S4SKU"), Data.get("70082S4BPRC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verifyText(Data.get("70082S4SKU"), Data.get("70082S4ASAVE"), control.bundleDetail);
            Action.verifyText(Data.get("70082S4SKU"), Data.get("70082S4PRC"), control.bundleDetail);
            Reusable.scroll(driver);
            //BuyGroup2 - SKU5
            Action.verifyText(Data.get("70082S5SKU"), Data.get("70082S5BPRC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verifyText(Data.get("70082S5SKU"), Data.get("70082S5ASAVE"), control.bundleDetail);
            Action.verifyText(Data.get("70082S5SKU"), Data.get("70082S5PRC"), control.bundleDetail);
        }

        public void TC70083()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70083P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70083P1DESC"));
            Reusable.verifyImages(Data.get("70083P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("70083P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("70083P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("70083P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("70083P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70083BSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70083BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70083ASAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70083QTYTXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70083BPRC"));
            Action.click_Element(control.O_bundleDetails);
            Action.verify_Text(control.bundleDetails, Data.get("70083BPRC"));
            Action.verify_Text(control.bundleDetails, Data.get("70083BSAVEOFFDESC"));

            // Buy Group1
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("70083P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("70083P1DESC"));
            Reusable.verifyImages(Data.get("70083P1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("70083P1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("70083P1PRC"));

            //  BuyGroup2
            Action.verify_Text(control.anyBundle, Data.get("70083S1DESC"));
            Reusable.verifyImages(Data.get("70083S1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("70083S1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("70083S1PRC"));
        }

        public void TC70084()
        {

            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70084P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70084P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("70084P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("70084P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70084BSAVEPRC"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.bundleOffersPage, Data.get("70084BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70084SELECTTXT"));
            Reusable.clickDesc("BundleDetails", Data.get("70084BDESC"), driver);
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.bundleDetails, Data.get("70084BSAVEOFFDESC"));
            Console.WriteLine(Data.get("70084BSAVEOFFDESC"));

            // Buy Group2-SKU1

            Action.verifyText(Data.get("70084S1SKU"), Data.get("70084S1BPRC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verifyText(Data.get("70084S1SKU"), Data.get("70084S1ASAVE"), control.bundleDetail);
            Action.verifyText(Data.get("70084S1SKU"), Data.get("70084S1BSAVE"), control.bundleDetail);
            Action.verifyText(Data.get("70084S1SKU"), Data.get("70084S1DESC"), control.bundleDetail);
            Action.verifyText(Data.get("70084S1SKU"), Data.get("70084S1PRC"), control.bundleDetail);
            Reusable.scroll(driver);
            
            // BuyGroup2 - SKU2
            Action.verifyText(Data.get("70084S2SKU"), Data.get("70084S2BPRC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verifyText(Data.get("70084S2SKU"), Data.get("70084S2ASAVE"), control.bundleDetail);
            Action.verifyText(Data.get("70084S2SKU"), Data.get("70084S2BSAVE"), control.bundleDetail);
            Action.verifyText(Data.get("70084S2SKU"), Data.get("70084S2DESC"), control.bundleDetail);
            Action.verifyText(Data.get("70084S2SKU"), Data.get("70084S2PRC"), control.bundleDetail);
         
            //BuyGroup2 - SKU3
            Action.verifyText(Data.get("70084S3SKU"), Data.get("70084S3BPRC"), control.bundleDetail);
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verifyText(Data.get("70084S3SKU"), Data.get("70084S3ASAVE"), control.bundleDetail);
            Action.verifyText(Data.get("70084S3SKU"), Data.get("70084S3BSAVE"), control.bundleDetail);
            Action.verifyText(Data.get("70084S3SKU"), Data.get("70084S3MODEL"), control.bundleDetail);
            Action.verifyText(Data.get("70084S3SKU"), Data.get("70084S3PRC"), control.bundleDetail);
           
        }
        public void TC70085()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70085P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70085P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("70085P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("70085P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70085ASAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.bundleOffersPage, Data.get("70085BSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70085BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70085QTYTXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70085BPRC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70085ASAVE"));
            Reusable.clickDesc("BundleDetails", Data.get("70085BDESC"), driver);
            Action.verify_Text(control.bundleDetails, Data.get("70085BPRC"));
            Action.verify_Text(control.bundleDetails, Data.get("70085BSAVEOFFDESC"));
            // Buy Group1
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("70085P1PRC"));
            Action.verify_Text(control.anyBundle, Data.get("70085ASAVE"));

            //  BuyGroup2
            Action.verifyTextNotExist(control.anyBundle, Data.get("70085P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("70085S1SKU"));
            Action.verify_Text(control.anyBundle, Data.get("70085S1PRC"));
            //  BuyGroup3
            Reusable.scroll(driver);
            Action.verify_Text(control.anyBundle, Data.get("70085S2SKU"));
            Action.verify_Text(control.anyBundle, Data.get("70085S2PRC"));
        }



        public void TC70087()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70087P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70087P1DESC"));
            Reusable.verifyImages(Data.get("70087P1IMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("70087P1MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("70087P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("70087P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("70087P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.bundleOffersPage, Data.get("70087ASAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70087BSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70087BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70087QTYTXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70087BPRC"));
            Reusable.clickDesc("BundleDetails", Data.get("70087BDESC"), driver);
            Action.verify_Text(control.bundleDetails, Data.get("70087BPRC"));
            Action.verify_Text(control.bundleDetails, Data.get("70087BSAVEOFFDESC"));
       

            // Buy Group1

            Action.verifyTextNotExist(control.anyBundle, Data.get("70087P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("70087P1DESC"));
            Reusable.verifyImages(Data.get("70087P1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("70087P1MODEL"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("70087P1PRC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70087ASAVE"));

            //  BuyGroup2
            Action.verifyTextNotExist(control.anyBundle, Data.get("70087P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("70087S1DESC"));
            Reusable.verifyImages(Data.get("70087S1IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("70087S1MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("70087S1SKU"));
            Action.verify_Text(control.anyBundle, Data.get("70087S1PRC"));
            //  BuyGroup3
            Reusable.scroll(driver);
            Action.verifyTextNotExist(control.anyBundle, Data.get("70087P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("70087S2DESC"));
            Reusable.verifyImages(Data.get("70087S2IMG"), control.Images);
            Action.verify_Text(control.anyBundle, Data.get("70087S2MODEL"));
            Action.verify_Text(control.anyBundle, Data.get("70087S2SKU"));
            Action.verify_Text(control.anyBundle, Data.get("70087S2PRC"));
        }
        public void TC70090()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70090P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70090P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("70090P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("70090P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70090BGC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70090BSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70090BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70090QTYTXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70090BPRC"));
            Reusable.clickDesc("BundleDetails", Data.get("70090BDESC"), driver);
            Action.verify_Text(control.bundleDetails, Data.get("70090BSAVEOFFDESC"));
            Action.verify_Text(control.bundleDetails, Data.get("70090BPRC"));
            Action.verify_Text(control.bundleDetails, Data.get("70090BSAVE"));
            Action.verify_Text(control.anyBundle, Data.get("70090BGC"));
            // Buy Group1
            Action.verify_Text(control.anyBundle, Data.get("70090P1PRC"));
            Action.verify_Text(control.anyBundle, Data.get("70090P1SKU"));
            //  BuyGroup2
            Action.verify_Text(control.anyBundle, Data.get("70090P1QTYTXT"));
            Action.verify_Text(control.anyBundle, Data.get("70090S1SKU"));
            Action.verify_Text(control.anyBundle, Data.get("70090S1PRC"));
            //  BuyGroup3
            Reusable.scroll(driver);
            Action.verify_Text(control.anyBundle, Data.get("70090S2SKU"));
            Action.verify_Text(control.anyBundle, Data.get("70090S2PRC"));
        }


        public void TC70088()
        {

            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70088QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70088DESC"));
            Reusable.verifyImages(Data.get("70088PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("70088AVLBDL"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70088BSAVE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.bundleOffersPage, Data.get("70088BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70088QTY"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70088ASAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70088BPRICE"));
            Reusable.clickDesc("BundleDetails", Data.get("70088BDESC"), driver);
            Action.read_Text(control.titleBundleDetails, Data.get("titleBundleDetails"));
            Action.verify_Text(control.bundleDetails, Data.get("70088BPRICE"));
            Action.verify_Text(control.bundleDetails, Data.get("70088BSAVEDESC"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.bundleDetails, Data.get("70088QTY"));
            Action.verify_Text(control.bundleDetails, Data.get("70088DESC"));
            Action.verify_Text(control.bundleDetails, Data.get("70088MODEL"));
            Action.verify_Text(control.bundleDetails, Data.get("70088SKU"));
            Reusable.verifyImages(Data.get("70088PIMG"), control.Images);
            Action.verify_Text(control.bundleDetails, Data.get("70088BSPRICE"));
            Action.verify_Text(control.bundleDetails, Data.get("70088BSAVEAMT"));
            Action.verify_Text(control.bundleDetails, Data.get("70088ASAVE"));



        }
        public void TC70089()
        {

            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70089P1QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70089P1SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("70089P1AVLBDL"));
            Action.verify_Text(control.productDetailsPage, Data.get("70089P1PRC"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70089BSAVEPRC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70089BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70089SELECTTXT"));
            Reusable.clickDesc("BundleDetails", Data.get("70089BDESC"), driver);
            Action.verify_Text(control.bundleDetails, Data.get("70089BSAVEOFFDESC"));

            // Buy Group2-SKU1

            Action.verifyText(Data.get("70089S1SKU"), Data.get("70089S1BPRC"), control.bundleDetail);
            Action.verifyText(Data.get("70089S1SKU"), Data.get("70089S1DESC"), control.bundleDetail);
            Action.verifyText(Data.get("70089S1SKU"), Data.get("70089S1PRC"), control.bundleDetail);
            Reusable.scroll(driver);

            // BuyGroup2 - SKU2
            Action.verifyText(Data.get("70089S2SKU"), Data.get("70089S2BPRC"), control.bundleDetail);
            Action.verifyText(Data.get("70089S2SKU"), Data.get("70089S2DESC"), control.bundleDetail);
            Action.verifyText(Data.get("70089S2SKU"), Data.get("70089S2PRC"), control.bundleDetail);

            //BuyGroup2 - SKU3
            Action.verifyText(Data.get("70089S3SKU"), Data.get("70089S3BPRC"), control.bundleDetail);
            Action.verifyText(Data.get("70089S3SKU"), Data.get("70089S3MODEL"), control.bundleDetail);
            Action.verifyText(Data.get("70089S3SKU"), Data.get("70089S3PRC"), control.bundleDetail);

        }


        public void TC70091()
        {

            Reusable.IsDisplayed(control.imgScanQrCode);
            Action.read_Text(control.labelSkuUpcModel, Data.get("SKUUPCLABEL"));
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70091QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70091DESC"));
            Reusable.verifyImages(Data.get("70091PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("70091AVLBDL"));
            Action.click_Element(control.txtBundleSave);
            Action.read_Text(control.titleBundleOffers, Data.get("titleBundleOffers"));
            Action.verify_Text(control.bundleOffersPage, Data.get("OFFRBDLSAVETXT"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70091BSAVE"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70091BDESC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70091QTY"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70091BGC"));
            Action.verify_Text(control.bundleOffersPage, Data.get("70091BPRICE"));
            Reusable.clickDesc("BundleDetails", Data.get("70091BDESC"), driver);
            Action.read_Text(control.titleBundleDetails, Data.get("titleBundleDetails"));
            Action.verify_Text(control.bundleDetails, Data.get("70091BPRICE"));
            Action.verify_Text(control.bundleDetails, Data.get("70091BSAVEDESC"));
            Action.verify_Text(control.bundleDetails, Data.get("70091BSPRICE"));
            Action.verify_Text(control.bundleDetails, Data.get("70091BSAVEAMT"));
            Action.verify_Text(control.bundleDetails, Data.get("70091BGC"));
            Action.verify_Text(control.bundleDetails, Data.get("70091QTY"));
            Action.verify_Text(control.bundleDetails, Data.get("70091DESC"));
            Action.verify_Text(control.bundleDetails, Data.get("70091MODEL"));
            Action.verify_Text(control.bundleDetails, Data.get("70091SKU"));
            Reusable.verifyImages(Data.get("70091PIMG"), control.Images);




        }


      





















    }
}











            

            

       
    
