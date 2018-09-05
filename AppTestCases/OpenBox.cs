using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GoatAppFramework
{
    public class OpenBox
    {

        public Control control;
        public IWebDriver driver;
        public OpenBox(IWebDriver drv)
        {
            driver = drv;
            Data.LoadData();
            control = new Control(drv);
            Reusable.Login(control.txtUserName, control.txtPassword, control.btnSignIN);


        }
        public void TC69211()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69211QRSKU"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69211DESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69211MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69211SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69211AVLOB"));
            Action.verify_Text(control.productDetailsPage, Data.get("69211PRC"));
            Action.click_Element(control.txtOpenBox);
            Action.read_Text(control.titleOpenBox, Data.get("titleOpenBox"));
            Action.verify_Text(control.headerOpenBox, Data.get("HDROPENBOX"));
            Action.verify_Text(control.openBoxPage, Data.get("69211DESC"));
            Action.verify_Text(control.openBoxPage, Data.get("69211MODEL"));
            Action.verify_Text(control.openBoxPage, Data.get("69211SKU"));
            Action.verify_Text(control.openBoxPage, Data.get("69211INV"));
            Reusable.verifyImages(Data.get("69211PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            Action.verify_Text(control.openBoxCondtns1, Data.get("69211COND1"));
            Action.verify_Text(control.openBoxCondtns1, Data.get("69211LPN"));
            Action.verify_Text(control.openBoxCondtns1, Data.get("69211OBPRC"));
            Action.verify_Text(control.openBoxCondtns1, Data.get("69211SAVE"));
            Action.verify_Text(control.openBoxCondtns1, Data.get("69211CPRC"));

            }

        public void TC69212()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69212QRSKU"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69212DESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69212MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69212SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69212AVLOB"));
            Action.verify_Text(control.productDetailsPage, Data.get("69212PRC"));
            Action.click_Element(control.txtOpenBox);
            Action.read_Text(control.titleOpenBox, Data.get("titleOpenBox"));
            Action.verify_Text(control.headerOpenBox, Data.get("HDROPENBOX"));
            Action.verify_Text(control.openBoxPage, Data.get("69212DESC"));
            Action.verify_Text(control.openBoxPage, Data.get("69212MODEL"));
            Action.verify_Text(control.openBoxPage, Data.get("69212SKU"));
            Action.verify_Text(control.openBoxPage, Data.get("69212INV"));
            Reusable.verifyImages(Data.get("69212PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            //Condition-1
            Action.verify_Text(control.openBoxCondtns1,  Data.get("69212COND1"));
            Action.verify_Text(control.openBoxCondtns1,  Data.get("69212LPN1"));
            Action.verify_Text(control.openBoxCondtns1,  Data.get("69212OBPRC1"));
            Action.verify_Text(control.openBoxCondtns1,  Data.get("69212SAVE1"));
            Action.verify_Text(control.openBoxCondtns1, Data.get("69212CPRC1"));
           // condition-1
            Action.verify_Text(control.openBoxCondtns2,  Data.get("69212COND2"));
            Action.verify_Text(control.openBoxCondtns2,  Data.get("69212LPN2"));
            Action.verify_Text(control.openBoxCondtns2,  Data.get("69212OBPRC2"));
            Action.verifyTextNotExist(control.openBoxCondtns2,  Data.get("69212SAVE2"));
            Action.verifyTextNotExist(control.openBoxCondtns2,Data.get("69212CPRC2"));

            // condition-0
            Action.verify_Text(control.openBoxCondtns3, Data.get("69212COND3"));
            Action.verify_Text(control.openBoxCondtns3, Data.get("69212LPN3"));
            Action.verify_Text(control.openBoxCondtns3, Data.get("69212OBPRC3"));
            Action.verify_Text(control.openBoxCondtns3, Data.get("69212SAVE3"));
            Action.verify_Text(control.openBoxCondtns3, Data.get("69212CPRC3"));


        }

        public void TC69213()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("69213QRCODE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("69213DESC"));
            Action.verify_Text(control.productDetailsPage, Data.get("69213MODEL"));
            Action.verify_Text(control.productDetailsPage, Data.get("69213SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("69213AVLOB"));
            Action.verify_Text(control.productDetailsPage, Data.get("69213PRC"));
            Action.click_Element(control.txtOpenBox);
            Action.read_Text(control.titleOpenBox, Data.get("titleOpenBox"));
            Action.verify_Text(control.headerOpenBox, Data.get("HDROPENBOX"));
            Action.verify_Text(control.openBoxPage, Data.get("69213DESC"));
            Action.verify_Text(control.openBoxPage, Data.get("69213MODEL"));
            Action.verify_Text(control.openBoxPage, Data.get("69213SKU"));
            Action.verify_Text(control.openBoxPage, Data.get("69213INV"));
            Reusable.verifyImages(Data.get("69213PIMG"), control.Images);
            Reusable.verifyImages(Data.get("LOCIMG"), control.Images);
            //Condition-3
            Action.verify_Text(control.openBoxCondtns1, Data.get("69213COND1"));
            Action.verify_Text(control.openBoxCondtns1, Data.get("69213LPN1"));
            Action.verify_Text(control.openBoxCondtns1, Data.get("69213OBPRC1"));
            Action.verify_Text(control.openBoxCondtns1, Data.get("69213SAVE1"));
            Action.verify_Text(control.openBoxCondtns1, Data.get("69213CPRC1"));
            // condition-2
            Action.verify_Text(control.openBoxCondtns2, Data.get("69213COND2"));
            Action.verify_Text(control.openBoxCondtns2, Data.get("69213LPN2"));
            Action.verify_Text(control.openBoxCondtns2, Data.get("69213OBPRC2"));
            Action.verify_Text(control.openBoxCondtns2, Data.get("69213SAVE2"));
            Action.verify_Text(control.openBoxCondtns2, Data.get("69213CPRC2"));
            Reusable.scroll(driver);
            // condition-1
            Action.verify_Text(control.openBoxCondtns3, Data.get("69213COND3"));
            Action.verify_Text(control.openBoxCondtns3, Data.get("69213LPN3"));
            Action.verify_Text(control.openBoxCondtns3, Data.get("69213OBPRC3"));
            Action.verify_Text(control.openBoxCondtns3, Data.get("69213SAVE3"));
            Action.verify_Text(control.openBoxCondtns3, Data.get("69213CPRC3"));

            Reusable.scroll(driver);
            // condition-0
            Action.verify_Text(control.openBoxCondtns4, Data.get("69213COND4"));
            Action.verify_Text(control.openBoxCondtns4, Data.get("69213LPN4"));
            Action.verify_Text(control.openBoxCondtns4, Data.get("69213OBPRC4"));
            Action.verify_Text(control.openBoxCondtns4, Data.get("69213SAVE4"));
            Action.verify_Text(control.openBoxCondtns4, Data.get("69213CPRC4"));


        }



    }
}
