using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GoatAppFramework
{
    public class ActivationProducts
    {
        public Control control;
        public IWebDriver driver;
        public ActivationProducts(IWebDriver drv)
        {
            driver = drv;
            Data.LoadData();
            control = new Control(drv);
            Reusable.Login(control.txtUserName, control.txtPassword, control.btnSignIN);


        }

        public void TC69218()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69218QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Reusable.verifyImages(Data.get("69218PIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("69218DESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69218MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69218SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69218AVLAO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69218PRC"));
            Action.click_Element(control.txtActivationProducts);
            Action.read_Text(control.titleActProducts, Data.get("titleActProducts"));
            Action.verify_Text(control.headerActProducts, Data.get("HDRACTPRDS"));
            Action.verify_Text(control.ActProdDetails, Data.get("69218DESC"));
            Action.verify_Text(control.ActProdDetails, Data.get("69218MODEL"));
            Action.verify_Text(control.ActProdDetails, Data.get("69218SKU"));
            Action.verify_Text(control.ActProdCarrier, Data.get("69218CARRIER"));
            //IBN-20
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69218N20MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69218N20TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69218N20GC"));
            Action.verify_Text(control.ActPlan1, Data.get("69218N20TOTAL"));

            //IBN-30
            Action.verify_Text(control.ActPlan2, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan2, Data.get("69218N30MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69218N30TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69218N30SAVE"));
            Action.verify_Text(control.ActPlan2, Data.get("69218N30GC"));
            Action.verify_Text(control.ActPlan2, Data.get("69218N30WAS"));
           
            //IBU-30
            Action.verify_Text(control.ActPlan3, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan3, Data.get("69218U30MTHPYMT"));
            Action.verify_Text(control.ActPlan3, Data.get("69218U30TERM"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69218U30SAVE"));
            Action.verify_Text(control.ActPlan3, Data.get("69218U30TOTAL"));

            //IBU-24
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69218U24MTHPYMT"));
            Action.verify_Text(control.ActPlan4, Data.get("69218U24TERM"));
            Action.verify_Text(control.ActPlan4, Data.get("69218U24SAVE"));
            Action.verify_Text(control.ActPlan4, Data.get("69218U24WAS"));
            Reusable.scroll(driver);
            //OMT1
            Action.verify_Text(control.ActPlan5, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan5, Data.get("69218OMT1"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69218OMT1SAVE"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69218OMT1WAS"));

            //OMT2
            Action.verify_Text(control.ActPlan6, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan6, Data.get("69218OMT2"));
            Action.verify_Text(control.ActPlan6, Data.get("69218OMT2SAVE"));
            Action.verify_Text(control.ActPlan6, Data.get("69218OMT2WAS"));

            //OMT3
            Action.verify_Text(control.ActPlan7, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan7, Data.get("69218OMT3"));
            Action.verify_Text(control.ActPlan7, Data.get("69218OMT3SAVE"));
            Action.verify_Text(control.ActPlan7, Data.get("69218OMT3WAS"));

            //Unactivated
            Action.verify_Text(control.ActPlan8, Data.get("69218UACT"));
            Reusable.actvDisclmr(control.actvDisclmr, Data.get("69218DISCLMR"));

        }

        public void TC69219()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69219QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Reusable.verifyImages(Data.get("69219PIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("69219DESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69219MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69219SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69219AVLAO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69219PRC"));
            Action.click_Element(control.txtActivationProducts);
            Action.read_Text(control.titleActProducts, Data.get("titleActProducts"));
            Action.verify_Text(control.headerActProducts, Data.get("HDRACTPRDS"));
            Action.verify_Text(control.ActProdDetails, Data.get("69219DESC"));
            Action.verify_Text(control.ActProdDetails, Data.get("69219MODEL"));
            Action.verify_Text(control.ActProdDetails, Data.get("69219SKU"));
            Action.verify_Text(control.ActProdCarrier, Data.get("69219CARRIER"));
            //IBN-24
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69219N24MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69219N24TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69219N24GC"));
            Action.verify_Text(control.ActPlan1, Data.get("69219N24TOTAL"));
            //IBU-24
            Action.verify_Text(control.ActPlan2, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan2, Data.get("69219U24MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69219U24TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69219U24SAVE"));
            Action.verify_Text(control.ActPlan2, Data.get("69219U24WAS"));
            Reusable.scroll(driver);
            //OMT1
            Action.verify_Text(control.ActPlan3, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan3, Data.get("69219OMT1"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69219OMT1SAVE"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69219OMT1WAS"));
            Reusable.scroll(driver);
            //OMT3
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69219OMT3"));
            Action.verify_Text(control.ActPlan4, Data.get("69219OMT3SAVE"));
            Action.verify_Text(control.ActPlan4, Data.get("69219OMT3WAS"));

            //Unactivated
            Action.verify_Text(control.ActPlan5, Data.get("69219UACT"));
            Reusable.actvDisclmr(control.actvDisclmr, Data.get("69219DISCLMR"));
            Action.verify_Text(control.ActPlan5, Data.get("69219SAVE"));
            Action.verify_Text(control.ActPlan5, Data.get("69219WAS"));

        }
        public void TC69220()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69220QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Reusable.verifyImages(Data.get("69220PIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("69220DESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69220MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69220SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69220AVLAO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69220PRC"));
            Action.click_Element(control.txtActivationProducts);
            Action.read_Text(control.titleActProducts, Data.get("titleActProducts"));
            Action.verify_Text(control.headerActProducts, Data.get("HDRACTPRDS"));
            Action.verify_Text(control.ActProdDetails, Data.get("69220DESC"));
            Action.verify_Text(control.ActProdDetails, Data.get("69220MODEL"));
            Action.verify_Text(control.ActProdDetails, Data.get("69220SKU"));
            Action.verify_Text(control.ActProdCarrier, Data.get("69220CARRIER"));
            //IBN-24
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69220N24MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69220N24TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69220N24GC"));
            Action.verify_Text(control.ActPlan1, Data.get("69220N24TOTAL"));
            //IBU-24
            Action.verify_Text(control.ActPlan2, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan2, Data.get("69220U24MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69220U24TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69220U24GC"));
            Action.verify_Text(control.ActPlan2, Data.get("69220U24SAVE"));
            Action.verify_Text(control.ActPlan2, Data.get("69220U24WAS"));
            //LSN-18
            Action.verify_Text(control.ActPlan3, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan3, Data.get("69220N18MTHPYMT"));
            Action.verify_Text(control.ActPlan3, Data.get("69220N18TERM"));
            Action.verify_Text(control.ActPlan3, Data.get("69220N18GC"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69220N18TOTAL"));

            Reusable.scroll(driver);
            //LSU-18
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69220U18MTHPYMT"));
            Action.verify_Text(control.ActPlan4, Data.get("69220U18TERM"));
            Action.verify_Text(control.ActPlan4, Data.get("69220U18GC"));
            Action.verify_Text(control.ActPlan4, Data.get("69220U18SAVE"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69220U18WAS"));
            //OMT1
            Action.verify_Text(control.ActPlan5, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan5, Data.get("69220OMT1"));
            Action.verify_Text(control.ActPlan5, Data.get("69220OMT1GC"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69220OMT1SAVE"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69220OMT1WAS"));
            Reusable.scroll(driver);
            //OMT3
            Action.verify_Text(control.ActPlan6, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan6, Data.get("69220OMT3"));
            Action.verify_Text(control.ActPlan6, Data.get("69220OMT3GC"));
            Action.verifyTextNotExist(control.ActPlan6, Data.get("69220OMT3SAVE"));
            Action.verifyTextNotExist(control.ActPlan6, Data.get("69220OMT3WAS"));

            //Unactivated
            Action.verify_Text(control.ActPlan7, Data.get("69220UACT"));
            Reusable.actvDisclmr(control.actvDisclmr, Data.get("69220DISCLMR"));
            Action.verify_Text(control.ActPlan7, Data.get("69220UACTGC"));
            Action.verify_Text(control.ActPlan7, Data.get("69220UACTSAVE"));
            Action.verify_Text(control.ActPlan7, Data.get("69220UACTWAS"));

        }

        public void TC69221()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69221QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Reusable.verifyImages(Data.get("69221PIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("69221DESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69221MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69221SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69221AVLAO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69221PRC"));
            Action.click_Element(control.txtActivationProducts);
            Thread.Sleep(1000);
            Action.read_Text(control.titleActProducts, Data.get("titleActProducts"));
            Action.verify_Text(control.headerActProducts, Data.get("HDRACTPRDS"));
            Action.verify_Text(control.ActProdDetails, Data.get("69221DESC"));
            Action.verify_Text(control.ActProdDetails, Data.get("69221MODEL"));
            Action.verify_Text(control.ActProdDetails, Data.get("69221SKU"));
            Action.click_Element(control.CarrierATT);
            //IBN-20
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69221N20MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69221N20TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69221N20GC"));
            Action.verify_Text(control.ActPlan1, Data.get("69221N20TOTAL"));
            //IBN-24
            Action.verify_Text(control.ActPlan2, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan2, Data.get("69221N24MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69221N24TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69221N24GC"));
            Action.verify_Text(control.ActPlan2, Data.get("69221N24TOTAL"));

            //IBN-30
            Action.verify_Text(control.ActPlan3, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan3, Data.get("69221N30MTHPYMT"));
            Action.verify_Text(control.ActPlan3, Data.get("69221N30TERM"));
            Action.verify_Text(control.ActPlan3, Data.get("69221N30GC"));
            Action.verify_Text(control.ActPlan3, Data.get("69221N30WAS"));
            Action.verify_Text(control.ActPlan3, Data.get("69221N30SAVE"));

            //IBU-30
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69221U30MTHPYMT"));
            Action.verify_Text(control.ActPlan4, Data.get("69221U30TERM"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69221U30GC"));
            Action.verify_Text(control.ActPlan4, Data.get("69221U30TOTAL"));
            //IBU-20
            Action.verify_Text(control.ActPlan5, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan5, Data.get("69221U20MTHPYMT"));
            Action.verify_Text(control.ActPlan5, Data.get("69221U20TERM"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69221U20GC"));
            Action.verify_Text(control.ActPlan5, Data.get("69221U20WAS"));
            Action.verify_Text(control.ActPlan5, Data.get("69221U20SAVE"));
            //IBU-24
            Action.verify_Text(control.ActPlan6, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan6, Data.get("69221U24MTHPYMT"));
            Action.verify_Text(control.ActPlan6, Data.get("69221U24TERM"));
            Action.verifyTextNotExist(control.ActPlan6, Data.get("69221U24GC"));
            Action.verify_Text(control.ActPlan6, Data.get("69221U24WAS"));
            Action.verify_Text(control.ActPlan6, Data.get("69221U24SAVE"));
            Reusable.scroll(driver);
         

            //OMT1
            Action.verify_Text(control.ActPlan7, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan7, Data.get("69221OMT1"));
            Action.verifyTextNotExist(control.ActPlan7, Data.get("69221OMT1GC"));
            Action.verify_Text(control.ActPlan7, Data.get("69221OMT1SAVE"));
            Action.verify_Text(control.ActPlan7, Data.get("69221OMT1WAS"));

            //OMT3
            Action.verify_Text(control.ActPlan8, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan8, Data.get("69221OMT3"));
            Action.verifyTextNotExist(control.ActPlan8, Data.get("69221OMT3GC"));
            Action.verifyTextNotExist(control.ActPlan8, Data.get("69221OMT3SAVE"));
            Action.verifyTextNotExist(control.ActPlan8, Data.get("69221OMT3WAS"));
            //Unactivated
            Action.verify_Text(control.ActPlan9, Data.get("69221UACT"));
            Reusable.actvDisclmr(control.actvDisclmr, Data.get("69221DISCLMR"));
            Action.verifyTextNotExist(control.ActPlan9, Data.get("69221UACTGC"));
            Action.verify_Text(control.ActPlan9, Data.get("69221UACTSAVE"));
            Action.verify_Text(control.ActPlan9, Data.get("69221UACTWAS"));
            Reusable.scrollUp(driver);
            Action.click_Element(control.CarrierSPRT);
            //IBN - 24
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69221NS24MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69221NS24TERM"));
            Action.verifyTextNotExist(control.ActPlan1, Data.get("69221NS24GC"));
            Action.verify_Text(control.ActPlan1, Data.get("69221NS24TOTAL"));
           // IBU - 24
            Action.verify_Text(control.ActPlan2, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan2, Data.get("69221US24MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69221US24TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69221US24SAVE"));
            Action.verify_Text(control.ActPlan2, Data.get("69221US24WAS"));
          //  LSN - 18
            Action.verify_Text(control.ActPlan3, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan3, Data.get("69221NS18MTHPYMT"));
            Action.verify_Text(control.ActPlan3, Data.get("69221NS18TERM"));
            Action.verify_Text(control.ActPlan3, Data.get("69221NS18GC"));
            Action.verify_Text(control.ActPlan3, Data.get("69221NS18SAVE"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69221NS18WAS"));

            Reusable.scroll(driver);
           // LSU - 18
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69221US18MTHPYMT"));
            Action.verify_Text(control.ActPlan4, Data.get("69221US18TERM"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69221US18GC"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69221US18TOTAL"));
            //Unactivated
            Action.verify_Text(control.ActPlan5, Data.get("69221SUACT"));
            Reusable.actvDisclmr(control.actvDisclmr, Data.get("69221SDISCLMR"));
            Action.verify_Text(control.ActPlan5, Data.get("69221SUACTGC"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69221SUACTSAVE"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69221UACTWAS"));
            Reusable.scrollUp(driver);
            Action.click_Element(control.CarrierVER);
            //IBN-24
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69221NV24MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69221NV24TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69221NV24WAS"));
            //IBU-24
            Action.verify_Text(control.ActPlan2, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan2, Data.get("69221UV24MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69221UV24TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69221UV24SAVE"));
            Action.verify_Text(control.ActPlan2, Data.get("69221UV24WAS"));
            //OMT1
            Action.verify_Text(control.ActPlan3, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan3, Data.get("69221VOMT1"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69221VOMT1SAVE"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69221VOMT1WAS"));
            Reusable.scroll(driver);
            //OMT3
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69221VOMT3"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69221VOMT3SAVE"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69221VOMT3WAS"));

            //Unactivated
            Action.verify_Text(control.ActPlan5, Data.get("69221VUACT"));
            Reusable.actvDisclmr(control.actvDisclmr, Data.get("69221VDISCLMR"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69221VSAVE"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69221VWAS"));
        }

        public void TC69222()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69222QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Reusable.verifyImages(Data.get("69222PIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("69222DESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69222MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69222SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69222AVLAO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69222PRC"));
            Action.click_Element(control.txtActivationProducts);
            Action.read_Text(control.titleActProducts, Data.get("titleActProducts"));
            Action.verify_Text(control.headerActProducts, Data.get("HDRACTPRDS"));
            Action.verify_Text(control.ActProdDetails, Data.get("69222DESC"));
            Action.verify_Text(control.ActProdDetails, Data.get("69222MODEL"));
            Action.verify_Text(control.ActProdDetails, Data.get("69222SKU"));
            Thread.Sleep(1000);
            Reusable.IsDisabled(control.CarrierATT, Data.get("69222ATT"));
            Action.click_Element(control.CarrierVER);
            //IBN-24
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69222NV24MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69222NV24TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69222NV24WAS"));
            //IBU-24
            Action.verify_Text(control.ActPlan2, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan2, Data.get("69222UV24MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69222UV24TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69222UV24SAVE"));
            Action.verify_Text(control.ActPlan2, Data.get("69222UV24WAS"));
            //Unactivated
            Action.verify_Text(control.ActPlan3, Data.get("69222VUACT"));
            Reusable.actvDisclmr(control.actvDisclmr, Data.get("69222VDISCLMR"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69222VSAVE"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69222VWAS"));
            Action.click_Element(control.CarrierSPRT);
            //IBN - 24
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69222NS24MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69222NS24TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69222NS24TOTAL"));
            // IBU - 24
            Action.verify_Text(control.ActPlan2, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan2, Data.get("69222US24MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69222US24TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69222US24TOTAL"));
            //  LSN - 18
            Action.verify_Text(control.ActPlan3, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan3, Data.get("69222NS18MTHPYMT"));
            Action.verify_Text(control.ActPlan3, Data.get("69222NS18TERM"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69222NS18TOTAL"));

            Reusable.scroll(driver);
            // LSU - 18
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69222US18MTHPYMT"));
            Action.verify_Text(control.ActPlan4, Data.get("69222US18TERM"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69222US18TOTAL"));
            //OMT1
            Action.verify_Text(control.ActPlan5, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan5, Data.get("69222SOMT1"));
            Action.verify_Text(control.ActPlan5, Data.get("69222SOMT1SAVE"));
            Action.verify_Text(control.ActPlan5, Data.get("69222SOMT1WAS"));
            //OMT3
            Action.verify_Text(control.ActPlan6, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan6, Data.get("69222SOMT3"));
            Action.verify_Text(control.ActPlan6, Data.get("69222SOMT3SAVE"));
            Action.verify_Text(control.ActPlan6, Data.get("69222SOMT3WAS"));
            //Unactivated
            Action.verify_Text(control.ActPlan7, Data.get("69222SUACT"));
            Reusable.actvDisclmr(control.actvDisclmr, Data.get("69222SDISCLMR"));
            Action.verifyTextNotExist(control.ActPlan7, Data.get("69222SUACTSAVE"));
            Action.verifyTextNotExist(control.ActPlan7, Data.get("69222SUACTWAS"));
  
        }
        public void TC69223()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69223QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Reusable.verifyImages(Data.get("69223PIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("69223DESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69223MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69223SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69223AVLAO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69223PRC"));
            Action.click_Element(control.txtActivationProducts);
            Thread.Sleep(1000);
            Action.read_Text(control.titleActProducts, Data.get("titleActProducts"));
            Action.verify_Text(control.headerActProducts, Data.get("HDRACTPRDS"));
            Action.verify_Text(control.ActProdDetails, Data.get("69223DESC"));
            Action.verify_Text(control.ActProdDetails, Data.get("69223MODEL"));
            Action.verify_Text(control.ActProdDetails, Data.get("69223SKU"));
            Action.verify_Text(control.ActProdCarrier, Data.get("69223CARRIER"));
 
            //IBN - 24
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69223NS24MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69223NS24TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69223NS24SAVE"));
            Action.verify_Text(control.ActPlan1, Data.get("69223NS24WAS"));
            // IBU - 24
            Action.verify_Text(control.ActPlan2, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan2, Data.get("69223US24MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69223US24TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69223US24SAVE"));
            Action.verify_Text(control.ActPlan2, Data.get("69223US24WAS"));
            ////OMT1
            Action.verify_Text(control.ActPlan3, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan3, Data.get("69223NSOMT1"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69223NSOMT1SAVE"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69223NSOMT1WAS"));
            //OMT3
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69223USOMT3"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69223USOMT3SAVE"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69223USOMT3WAS"));
            //Unactivated
            Action.verify_Text(control.ActPlan5, Data.get("69223SUACT"));
            Reusable.actvDisclmr(control.actvDisclmr, Data.get("69223SDISCLMR"));


        }
        public void TC69224()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69224QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Reusable.verifyImages(Data.get("69224PIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("69224DESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69224MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69224SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69224AVLAO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69224PRC"));
            Action.click_Element(control.txtActivationProducts);
            Action.read_Text(control.titleActProducts, Data.get("titleActProducts"));
            Thread.Sleep(2000);
            Action.verify_Text(control.headerActProducts, Data.get("HDRACTPRDS"));
            Action.verify_Text(control.ActProdDetails, Data.get("69224DESC"));
            Action.verify_Text(control.ActProdDetails, Data.get("69224MODEL"));
            Action.verify_Text(control.ActProdDetails, Data.get("69224SKU"));
            Action.click_Element(control.CarrierVER);
            //IBN-24
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69221NV24MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69221NV24TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69221NV24WAS"));
            //IBU-24
            Action.verify_Text(control.ActPlan2, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan2, Data.get("69224UV24MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69224UV24TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69224UV24SAVE"));
            Action.verify_Text(control.ActPlan2, Data.get("69224UV24WAS"));
            //OMT1
            Action.verify_Text(control.ActPlan3, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan3, Data.get("69224VOMT1"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69224VOMT1SAVE"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69224VOMT1WAS"));
            Reusable.scroll(driver);
            //OMT3
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69224VOMT3"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69224VOMT3SAVE"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69224VOMT3WAS"));
            //Unactivated
            Action.verify_Text(control.ActPlan5, Data.get("69224VUACT"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69224VSAVE"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69224VWAS"));
            Action.click_Element(control.CarrierATT);
            //IBN-20
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69224N20MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69224N20TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69224N20GC"));
            Action.verify_Text(control.ActPlan1, Data.get("69224N20TOTAL"));
            //IBN-24
            Action.verify_Text(control.ActPlan2, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan2, Data.get("69224N24MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69224N24TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69224N24GC"));
            Action.verify_Text(control.ActPlan2, Data.get("69224N24TOTAL"));
            //IBN-30
            Action.verify_Text(control.ActPlan3, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan3, Data.get("69224N30MTHPYMT"));
            Action.verify_Text(control.ActPlan3, Data.get("69224N30TERM"));
            Action.verify_Text(control.ActPlan3, Data.get("69224N30GC"));
            Action.verify_Text(control.ActPlan3, Data.get("69224N30WAS"));
            Action.verify_Text(control.ActPlan3, Data.get("69224N30SAVE"));

            //IBU-30
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69224U30MTHPYMT"));
            Action.verify_Text(control.ActPlan4, Data.get("69224U30TERM"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69224U30GC"));
            Action.verify_Text(control.ActPlan4, Data.get("69224U30TOTAL"));
            //IBU-20
            Action.verify_Text(control.ActPlan5, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan5, Data.get("69224U20MTHPYMT"));
            Action.verify_Text(control.ActPlan5, Data.get("69224U20TERM"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69224U20GC"));
            Action.verify_Text(control.ActPlan5, Data.get("69224U20WAS"));
            Action.verify_Text(control.ActPlan5, Data.get("69224U20SAVE"));

            //IBU-24
            Action.verify_Text(control.ActPlan6, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan6, Data.get("69224U24MTHPYMT"));
            Action.verify_Text(control.ActPlan6, Data.get("69224U24TERM"));
            Action.verifyTextNotExist(control.ActPlan6, Data.get("69224U24GC"));
            Action.verify_Text(control.ActPlan6, Data.get("69224U24WAS"));
            Action.verify_Text(control.ActPlan6, Data.get("69224U24SAVE"));
            Reusable.scroll(driver);
        
            //OMT1
            Action.verify_Text(control.ActPlan7, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan7, Data.get("69224OMT1"));
            Action.verifyTextNotExist(control.ActPlan7, Data.get("69224OMT1GC"));
            Action.verify_Text(control.ActPlan7, Data.get("69224OMT1SAVE"));
            Action.verify_Text(control.ActPlan7, Data.get("69224OMT1WAS"));

            //OMT3
            Action.verify_Text(control.ActPlan8, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan8, Data.get("69224OMT3"));
            Action.verifyTextNotExist(control.ActPlan8, Data.get("69224OMT3GC"));
            Action.verifyTextNotExist(control.ActPlan8, Data.get("69224OMT3SAVE"));
            Action.verifyTextNotExist(control.ActPlan8, Data.get("69224OMT3WAS"));
            //Unactivated
            Action.verify_Text(control.ActPlan9, Data.get("69224UACT"));
            Action.verifyTextNotExist(control.ActPlan9, Data.get("69224UACTGC"));
            Action.verify_Text(control.ActPlan9, Data.get("69224UACTSAVE"));
            Action.verify_Text(control.ActPlan9, Data.get("69224UACTWAS"));
            Reusable.scrollUp(driver);
            Action.click_Element(control.CarrierSPRT);
            //IBN - 24
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69224NS24MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69224NS24TERM"));
            Action.verifyTextNotExist(control.ActPlan1, Data.get("69224NS24GC"));
            Action.verify_Text(control.ActPlan1, Data.get("69224NS24TOTAL"));
            // IBU - 24
            Action.verify_Text(control.ActPlan2, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan2, Data.get("69224US24MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69224US24TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69224US24SAVE"));
            Action.verify_Text(control.ActPlan2, Data.get("69224US24WAS"));
            //  LSN - 18
            Action.verify_Text(control.ActPlan3, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan3, Data.get("69224NS18MTHPYMT"));
            Action.verify_Text(control.ActPlan3, Data.get("69224NS18TERM"));
            Action.verify_Text(control.ActPlan3, Data.get("69224NS18GC"));
            Action.verify_Text(control.ActPlan3, Data.get("69224NS18SAVE"));
            Action.verifyTextNotExist(control.ActPlan3, Data.get("69224NS18WAS"));
            Reusable.scroll(driver);
            // LSU - 18
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69224US18MTHPYMT"));
            Action.verify_Text(control.ActPlan4, Data.get("69224US18TERM"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69224US18GC"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69224US18TOTAL"));
            //Unactivated
            Action.verify_Text(control.ActPlan5, Data.get("69224SUACT"));
            Action.verify_Text(control.ActPlan5, Data.get("69224SUACTGC"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69224SUACTSAVE"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69224UACTWAS"));
       
            
        }

        public void TC69225()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69225QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Reusable.verifyImages(Data.get("69225PIMG"), control.Images);
            Action.verify_Text(control.productDetailsPage, Data.get("69225DESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69225MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69225SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69225AVLAO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69225PRC"));
            Action.click_Element(control.txtActivationProducts);
            Action.read_Text(control.titleActProducts, Data.get("titleActProducts"));
            Action.verify_Text(control.headerActProducts, Data.get("HDRACTPRDS"));
            Action.verify_Text(control.ActProdDetails, Data.get("69225DESC"));
            Action.verify_Text(control.ActProdDetails, Data.get("69225MODEL"));
            Action.verify_Text(control.ActProdDetails, Data.get("69225SKU"));
            Action.verify_Text(control.ActProdCarrier, Data.get("69225CARRIER"));


            //IBN-30
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69225N30MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69225N30TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69225N30SAVE"));
            Action.verify_Text(control.ActPlan1, Data.get("69225N30GC"));
            Action.verify_Text(control.ActPlan1, Data.get("69225N30WAS"));
            //IBN-20
            Action.verify_Text(control.ActPlan2, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan2, Data.get("69225N20MTHPYMT"));
            Action.verify_Text(control.ActPlan2, Data.get("69225N20TERM"));
            Action.verify_Text(control.ActPlan2, Data.get("69225N20GC"));
            Action.verify_Text(control.ActPlan2, Data.get("69225N20TOTAL"));

           
            //IBU-24
            Action.verify_Text(control.ActPlan3, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan3, Data.get("69225U24MTHPYMT"));
            Action.verify_Text(control.ActPlan3, Data.get("69225U24TERM"));
            Action.verify_Text(control.ActPlan3, Data.get("69225U24SAVE"));
            Action.verify_Text(control.ActPlan3, Data.get("69225U24WAS"));
            Reusable.scroll(driver);
            //IBU-30
            Action.verify_Text(control.ActPlan4, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan4, Data.get("69225U30MTHPYMT"));
            Action.verify_Text(control.ActPlan4, Data.get("69225U30TERM"));
            Action.verifyTextNotExist(control.ActPlan4, Data.get("69225U30SAVE"));
            Action.verify_Text(control.ActPlan4, Data.get("69225U30TOTAL"));

            //OMT1
            Action.verify_Text(control.ActPlan5, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan5, Data.get("69225OMT1"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69225OMT1SAVE"));
            Action.verifyTextNotExist(control.ActPlan5, Data.get("69225OMT1WAS"));

            //OMT2
            Action.verify_Text(control.ActPlan6, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan6, Data.get("69225OMT2"));
            Action.verify_Text(control.ActPlan6, Data.get("69225OMT2SAVE"));
            Action.verify_Text(control.ActPlan6, Data.get("69225OMT2WAS"));
            Reusable.scroll(driver);
            //OMT3
            Action.verify_Text(control.ActPlan7, Data.get("UPGRADE"));
            Action.verify_Text(control.ActPlan7, Data.get("69225OMT3"));
            Action.verify_Text(control.ActPlan7, Data.get("69225OMT3SAVE"));
            Action.verify_Text(control.ActPlan7, Data.get("69225OMT3WAS"));

            //Unactivated
            Action.verify_Text(control.ActPlan8, Data.get("69225UACT"));
    

        }

        public void TC69226()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69226QRCODE1"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69226SKU1"));
            Action.verify_Text(control.productDetailsPage, Data.get("69226AVLAO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69226AVLOO"));
            Action.click_Element(control.txtActivationProducts);
            Action.read_Text(control.titleActProducts, Data.get("titleActProducts"));
            Action.verify_Text(control.headerActProducts, Data.get("HDRACTPRDS"));
            Action.verify_Text(control.ActProdDetails, Data.get("69226SKU1"));
            Action.verify_Text(control.ActProdCarrier, Data.get("69226SCARRIER"));
            //IBN-20
            Action.verify_Text(control.ActPlan1, Data.get("NEWLINE"));
            Action.verify_Text(control.ActPlan1, Data.get("69226N24MTHPYMT"));
            Action.verify_Text(control.ActPlan1, Data.get("69226N24TERM"));
            Action.verify_Text(control.ActPlan1, Data.get("69226N24TOTAL"));
            Action.click_Element(control.leftNavigation);
            Action.click_Element(control.txtOtherOptions);
            Action.read_Text(control.titleOtherOptions, Data.get("titleOtherOptions"));
            Action.verifyText(Data.get("69226R1SKU"), Data.get("69226R1SKU"),control.actvOtherOptions);
            Action.verifyText(Data.get("69226R2SKU"), Data.get("69226R2SKU"),control.actvOtherOptions);
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69226QRCODE2"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69226SKU2"));
            Action.verify_Text(control.productDetailsPage, Data.get("69226AVLOO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69226AVLAO"));
            Action.click_Element(control.txtOtherOptions);
            Action.verifyText(Data.get("69226R2SKU"),Data.get("69226R2SKU"),control.actvOtherOptions);
            Action.verifyText(Data.get("69226R3SKU"),Data.get("69226R3SKU"),control.actvOtherOptions);
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69226QRCODE3"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69226SKU3"));
            Action.verify_Text(control.productDetailsPage, Data.get("69226AVLOO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69226AVLAO"));
            Action.click_Element(control.txtOtherOptions);
            Action.verifyText(Data.get("69226R1SKU"),Data.get("69226R1SKU"),control.actvOtherOptions);
            Action.verifyText(Data.get("69226R3SKU"),Data.get("69226R3SKU"),control.actvOtherOptions);

        }

        public void TC69227()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69227QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69227SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69227AVLAO"));
            Action.verify_Text(control.productDetailsPage, Data.get("69227AVLOO"));
            Action.click_Element(control.txtActivationProducts);
            Action.read_Text(control.titleActProducts, Data.get("titleActProducts"));
            Action.verify_Text(control.headerActProducts, Data.get("HDRACTPRDS"));
            Thread.Sleep(1000);
            Action.verify_Text(control.ActProdDetails, Data.get("69227SKU"));
            Action.click_Element(control.leftNavigation);
            Action.click_Element(control.txtOtherOptions);
            Action.read_Text(control.titleOtherOptions, Data.get("titleOtherOptions"));
            Action.verifyText(Data.get("69227R1SKU"), Data.get("69227R1SKU"),control.actvOtherOptions);
            Action.verifyText(Data.get("69227R2SKU"), Data.get("69227R2SKU"),control.actvOtherOptions);
            Action.verifyText(Data.get("69227R3SKU"), Data.get("69227R3SKU"),control.actvOtherOptions);



        }

    }
}