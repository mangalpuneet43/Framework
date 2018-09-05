using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace GoatAppFramework.AppTestCases
{
    public class CardMember
    {
        public Control control;
        public IWebDriver driver;
        public CardMember(IWebDriver drv)
        {
            driver = drv;
            Data.LoadData();
            control = new Control(drv);
            Reusable.Login(control.txtUserName, control.txtPassword, control.btnSignIN);


        }


        public void TC70061()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70061BELOW5"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70061SKU1"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70061PRICE1"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.PurchAmt, Data.get("70061<$5"));
            Action.verify_Text(control.RewardsBack5Per, Data.get("5%BACKMSG"));
            Action.verify_Text(control.txtOR, Data.get("ORTXT"));
            Action.verify_Text(control.txtflexblFnc, Data.get("FINANCETXT"));
            Action.verify_Text(control.RewardBack10Per, Data.get("10%BACKMSG"));
            Action.click_Element(control.seeDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70061BELOW99.99"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.verify_Text(control.productDetailsPage, Data.get("70061SKU2"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70061PRICE2"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.PurchAmt, Data.get("70061<$99.99"));
            Action.verify_Text(control.RewardsBack5Per, Data.get("5%BACKMSG"));
            Action.verify_Text(control.txtOR, Data.get("ORTXT"));
            Action.verify_Text(control.txtflexblFnc, Data.get("FINANCETXT"));
            Action.verify_Text(control.RewardBack10Per, Data.get("10%BACKMSG"));
            Action.click_Element(control.seeDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
        }
        public void TC70062()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70062BELOW5"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70062SKU1"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70062PRICE1"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.PurchAmt, Data.get("70062<$5"));
            Action.verify_Text(control.RewardsBack5Per, Data.get("5%BACKMSG"));
            Action.verify_Text(control.txtOR, Data.get("ORTXT"));
            Action.verify_Text(control.txtflexblFnc, Data.get("FINANCETXT"));
            Action.verify_Text(control.RewardBack10Per, Data.get("10%BACKMSG"));
            Action.click_Element(control.seeDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70062BELOW99.99"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Action.verify_Text(control.productDetailsPage, Data.get("70062SKU2"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70062PRICE2"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.PurchAmt, Data.get("70062<$99.99"));
            Action.verify_Text(control.RewardsBack5Per, Data.get("5%BACKMSG"));
            Action.verify_Text(control.txtOR, Data.get("ORTXT"));
            Action.verify_Text(control.txtflexblFnc, Data.get("FINANCETXT"));
            Action.verify_Text(control.RewardBack10Per, Data.get("10%BACKMSG"));
            Action.click_Element(control.seeDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
        }
        public void TC70063()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70063100-198.99"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70063SKU1"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70063PRICE1"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.IsElement(control.below199Line1);
            Action.verify_Text(control.PurchQualifies, Data.get("70063<=$198.99"));
            Action.verify_Text(control.flexblFncbelow199, Data.get("FINANCETXT"));
            Action.IsElement(control.below199Line2);
            Action.verify_Text(control.existingMember, Data.get("EXSTMEMBER"));
            Action.verify_Text(control.NewMember, Data.get("NEWMEMBER"));
            Action.verify_Text(control.existingReward, Data.get("70063EREWARD1"));
            Action.verify_Text(control.NewReward, Data.get("70063NREWARD1"));
            Action.click_Element(control.RewardDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.RewardDetailsPage, Data.get("REWARD"));
            Reusable.actvDisclmr(control.RewardDetailsInfo, Data.get("REWARDDETAILS"));
            Action.click_Element(control.menuHome);
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70063BELOW199"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            Action.verify_Text(control.productDetailsPage, Data.get("70063SKU2"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70063PRICE2"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.PurchQualifies, Data.get("70063<=$198.99"));
            Action.IsElement(control.below199Line1);
            Action.verify_Text(control.flexblFncbelow199, Data.get("FINANCETXT"));
            Action.IsElement(control.below199Line2);
            Action.verify_Text(control.existingMember, Data.get("EXSTMEMBER"));
            Action.verify_Text(control.NewMember, Data.get("NEWMEMBER"));
            Action.verify_Text(control.existingReward, Data.get("70063EREWARD2"));
            Action.verify_Text(control.NewReward, Data.get("70063NREWARD2"));
            Action.click_Element(control.RewardDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.RewardDetailsPage, Data.get("REWARD"));
            Reusable.actvDisclmr(control.RewardDetailsInfo, Data.get("REWARDDETAILS"));
        }

        public void TC70064()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70064100-198.99"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70064SKU1"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70064PRICE1"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.verify_Text(control.PurchQualifies, Data.get("70064<=$198.99"));
            Action.verify_Text(control.flexblFncbelow199, Data.get("FINANCETXT"));
            Action.verify_Text(control.existingMember, Data.get("EXSTMEMBER"));
            Action.verify_Text(control.NewMember, Data.get("NEWMEMBER"));
            Action.verify_Text(control.existingReward, Data.get("70064EREWARD1"));
            Action.verify_Text(control.NewReward, Data.get("70064NREWARD1"));
            Action.click_Element(control.RewardDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.RewardDetailsPage, Data.get("REWARD"));
            Reusable.actvDisclmr(control.RewardDetailsInfo, Data.get("REWARDDETAILS"));

        }
        public void TC70065()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70065ABOVE199"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70065SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70065PRC"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.IsElement(control.below199Line1);
            Action.verify_Text(control.PurchQualifies, Data.get("70065>$198.99"));
            Action.verify_Text(control.flexblFncbelow199, Data.get("SUGGESTEDTXT"));
            Action.verifyText(Data.get("70065NAME"), Data.get("70065MTHPYMT"),control.financeOptions);
            Action.verify_Text(control.above199Line3, Data.get("ORTXT"));
            Action.verify_Text(control.existingMember, Data.get("EXSTMEMBER"));
            Action.verify_Text(control.NewMember, Data.get("NEWMEMBER"));
            Action.verify_Text(control.existingReward, Data.get("70065EREWARD1"));
            Action.verify_Text(control.NewReward, Data.get("70065NREWARD1"));
            Action.click_Element(control.RewardDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.RewardDetailsPage, Data.get("REWARD"));
            Reusable.actvDisclmr(control.RewardDetailsInfo, Data.get("REWARDDETAILS"));
        }
        public void TC70066()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70066ABOVE199"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70066SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70066PRC"));
            Action.click_Element(control.txtCardMemberOffers);
            Reusable.clickDesc("FINC", Data.get("70066FNAME"), driver);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.finDisclosure, Data.get("FDISCLOSURE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Reusable.actvDisclmr(control.disclosureP1, Data.get("70066DISCLOSURE"));
            Reusable.actvDisclmr(control.intrestTxt, Data.get("70066INTRSTTXT"));
            Reusable.actvDisclmr(control.intrestSubTxt, Data.get("70066INTRSTSUBTXT"));
            Reusable.actvDisclmr(control.DisclosureReward, Data.get("REWARDHDR:"));
            Reusable.actvDisclmr(control.rewardSubTxt, Data.get("REWARDDETAILS"));
            Reusable.actvDisclmr(control.disclosureFnc, Data.get("FINCHDR:"));
            Reusable.actvDisclmr(control.finnaceSubTxt, Data.get("FINDETAILS"));
            Reusable.actvDisclmr(control.disclosureMPYMT, Data.get("SUGGESTEDHDR:"));
            Reusable.actvDisclmr(control.suggestedSubTxt, Data.get("SUGGESTEDSUBTXT"));
            Action.click_Element(control.leftNavigation);
            Action.verify_Text(control.above199Line3, Data.get("ORTXT"));

        }
        public void TC70067()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70067Multiple"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70067SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70067PRC"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.IsElement(control.below199Line1);
            Action.verify_Text(control.PurchQualifies, Data.get("70067>$198.99"));
            Action.verify_Text(control.flexblFncbelow199, Data.get("SUGGESTEDTXT"));
            //6 Months 
            Action.verifyText(Data.get("700676MTHFNAME1"), Data.get("700676MTHPYMT"), control.financeOptions);
            Reusable.clickDesc("FINC", Data.get("700676MTHFNAME1"), driver);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.finDisclosure, Data.get("FDISCLOSURE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Reusable.actvDisclmr(control.disclosureP1, Data.get("700676MTHDIS"));
            Reusable.actvDisclmr(control.intrestTxt, Data.get("700676MTHINTRST"));
            Reusable.actvDisclmr(control.intrestSubTxt, Data.get("700676MTHSUBTXT1"));
            Reusable.actvDisclmr(control.DisclosureReward, Data.get("REWARDHDR:"));
            Reusable.actvDisclmr(control.rewardSubTxt, Data.get("REWARDDETAILS"));
            Reusable.actvDisclmr(control.disclosureFnc, Data.get("FINCHDR:"));
            Reusable.actvDisclmr(control.finnaceSubTxt, Data.get("FINDETAILS"));
            Reusable.actvDisclmr(control.disclosureMPYMT, Data.get("SUGGESTEDHDR:"));
            Reusable.actvDisclmr(control.suggestedSubTxt, Data.get("SUGGESTEDSUBTXT"));
            Action.click_Element(control.leftNavigation);
            //6 Months
            Action.verifyText(Data.get("700676MTHFNAME2"), Data.get("700676MTHPYMT"), control.financeOptions);
            Reusable.clickDesc("FINC", Data.get("700676MTHFNAME2"), driver);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.finDisclosure, Data.get("FDISCLOSURE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Reusable.actvDisclmr(control.disclosureP1, Data.get("700676MTHDIS"));
            Reusable.actvDisclmr(control.intrestTxt, Data.get("700676MTHINTRST"));
            Reusable.actvDisclmr(control.intrestSubTxt, Data.get("700676MTHSUBTXT2"));
            Reusable.actvDisclmr(control.DisclosureReward, Data.get("REWARDHDR:"));
            Reusable.actvDisclmr(control.rewardSubTxt, Data.get("REWARDDETAILS"));
            Reusable.actvDisclmr(control.disclosureFnc, Data.get("FINCHDR:"));
            Reusable.actvDisclmr(control.finnaceSubTxt, Data.get("FINDETAILS"));
            Reusable.actvDisclmr(control.disclosureMPYMT, Data.get("SUGGESTEDHDR:"));
            Reusable.actvDisclmr(control.suggestedSubTxt, Data.get("SUGGESTEDSUBTXT"));
            Action.click_Element(control.leftNavigation);
            Action.verify_Text(control.above199Line3, Data.get("ORTXT"));
            Action.verify_Text(control.existingMember, Data.get("EXSTMEMBER"));
            Action.verify_Text(control.NewMember, Data.get("NEWMEMBER"));
            Action.verify_Text(control.existingReward, Data.get("70067EREWARD1"));
            Action.verify_Text(control.NewReward, Data.get("70067NREWARD1"));
            Action.click_Element(control.RewardDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.RewardDetailsPage, Data.get("REWARD"));
            Reusable.actvDisclmr(control.RewardDetailsInfo, Data.get("REWARDDETAILS"));

        }
            public void TC70068()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70068All"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70068SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70068PRC"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.IsElement(control.below199Line1);
            Action.verify_Text(control.PurchQualifies, Data.get("70068>$198.99"));
            Action.verify_Text(control.flexblFncbelow199, Data.get("SUGGESTEDTXT"));
            //6 Months 
            Action.verifyText(Data.get("700686MTHFNAME"), Data.get("700686MTHPYMT"), control.financeOptions);
            Reusable.clickDesc("FINC", Data.get("700686MTHFNAME"), driver);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.finDisclosure, Data.get("FDISCLOSURE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Reusable.actvDisclmr(control.disclosureP1, Data.get("700686MTHDIS"));
            Reusable.actvDisclmr(control.intrestTxt, Data.get("700686MTHINTRST"));
            Reusable.actvDisclmr(control.intrestSubTxt, Data.get("700686MTHSUBTXT"));
            Reusable.actvDisclmr(control.DisclosureReward, Data.get("REWARDHDR:"));
            Reusable.actvDisclmr(control.rewardSubTxt, Data.get("REWARDDETAILS"));
            Reusable.actvDisclmr(control.disclosureFnc, Data.get("FINCHDR:"));
            Reusable.actvDisclmr(control.finnaceSubTxt, Data.get("FINDETAILS"));
            Reusable.actvDisclmr(control.disclosureMPYMT, Data.get("SUGGESTEDHDR:"));
            Reusable.actvDisclmr(control.suggestedSubTxt, Data.get("SUGGESTEDSUBTXT"));
            Action.click_Element(control.leftNavigation);
            //12 Months
            Action.verifyText(Data.get("7006812MTHFNAME"), Data.get("7006812MTHPYMT"), control.financeOptions);
            Reusable.clickDesc("FINC", Data.get("7006812MTHFNAME"), driver);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.finDisclosure, Data.get("FDISCLOSURE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Reusable.actvDisclmr(control.disclosureP1, Data.get("7006812MTHDIS"));
            Reusable.actvDisclmr(control.intrestTxt, Data.get("7006812MTHINTRST"));
            Reusable.actvDisclmr(control.intrestSubTxt, Data.get("7006812MTHSUBTXT"));
            Reusable.actvDisclmr(control.DisclosureReward, Data.get("REWARDHDR:"));
            Reusable.actvDisclmr(control.rewardSubTxt, Data.get("REWARDDETAILS"));
            Reusable.actvDisclmr(control.disclosureFnc, Data.get("FINCHDR:"));
            Reusable.actvDisclmr(control.finnaceSubTxt, Data.get("FINDETAILS"));
            Reusable.actvDisclmr(control.disclosureMPYMT, Data.get("SUGGESTEDHDR:"));
            Reusable.actvDisclmr(control.suggestedSubTxt, Data.get("SUGGESTEDSUBTXT"));
            Action.click_Element(control.leftNavigation);
            //Do not 24 Months
            Action.verifyText(Data.get("70068D24MTHFNAME"), Data.get("70068D24MTHPYMT"), control.financeOptions);
            Reusable.clickDesc("FINC", Data.get("70068D24MTHFNAME"), driver);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.finDisclosure, Data.get("FDISCLOSURE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Reusable.actvDisclmr(control.disclosureP1, Data.get("70068D24MTHDIS"));
            Reusable.actvDisclmr(control.intrestTxt, Data.get("70068D24MTHINTRST"));
            Reusable.actvDisclmr(control.intrestSubTxt, Data.get("70068D24MTHSUBTXT"));
            Reusable.actvDisclmr(control.DisclosureReward, Data.get("REWARDHDR:"));
            Reusable.actvDisclmr(control.rewardSubTxt, Data.get("REWARDDETAILS"));
            Reusable.actvDisclmr(control.disclosureFnc, Data.get("FINCHDR:"));
            Reusable.actvDisclmr(control.finnaceSubTxt, Data.get("FINDETAILS"));
            Reusable.actvDisclmr(control.disclosureMPYMT, Data.get("SUGGESTEDHDR:"));
            Reusable.actvDisclmr(control.suggestedSubTxt, Data.get("SUGGESTEDSUBTXT"));
            Action.click_Element(control.leftNavigation);
            //18 Months
            Action.verifyText(Data.get("7006818MTHFNAME"), Data.get("7006818MTHPYMT"), control.financeOptions);
            Reusable.clickDesc("FINC", Data.get("7006818MTHFNAME"), driver);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.finDisclosure, Data.get("FDISCLOSURE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Reusable.actvDisclmr(control.disclosureP1, Data.get("7006818MTHDIS"));
            Reusable.actvDisclmr(control.intrestTxt, Data.get("7006818MTHINTRST"));
            Reusable.actvDisclmr(control.intrestSubTxt, Data.get("7006818MTHSUBTXT"));
            Reusable.actvDisclmr(control.DisclosureReward, Data.get("REWARDHDR:"));
            Reusable.actvDisclmr(control.rewardSubTxt, Data.get("REWARDDETAILS"));
            Reusable.actvDisclmr(control.disclosureFnc, Data.get("FINCHDR:"));
            Reusable.actvDisclmr(control.finnaceSubTxt, Data.get("FINDETAILS"));
            Reusable.actvDisclmr(control.disclosureMPYMT, Data.get("SUGGESTEDHDR:"));
            Reusable.actvDisclmr(control.suggestedSubTxt, Data.get("SUGGESTEDSUBTXT"));
            Action.click_Element(control.leftNavigation);
            Action.verifyText(Data.get("7006824MTHFNAME"), Data.get("7006824MTHPYMT"), control.financeOptions);
            Reusable.clickDesc("FINC", Data.get("7006824MTHFNAME"), driver);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.finDisclosure, Data.get("FDISCLOSURE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Reusable.actvDisclmr(control.disclosureP1, Data.get("7006824MTHDIS"));
            Reusable.actvDisclmr(control.intrestTxt, Data.get("7006824MTHINTRST"));
            Reusable.actvDisclmr(control.intrestSubTxt, Data.get("7006824MTHSUBTXT"));
            Reusable.actvDisclmr(control.DisclosureReward, Data.get("REWARDHDR:"));
            Reusable.actvDisclmr(control.rewardSubTxt, Data.get("REWARDDETAILS"));
            Reusable.actvDisclmr(control.disclosureFnc, Data.get("FINCHDR:"));
            Reusable.actvDisclmr(control.finnaceSubTxt, Data.get("FINDETAILS"));
            Reusable.actvDisclmr(control.disclosureMPYMT, Data.get("SUGGESTEDHDR:"));
            Reusable.actvDisclmr(control.suggestedSubTxt, Data.get("SUGGESTEDSUBTXT"));
            Action.click_Element(control.leftNavigation);
            //30 Months
            Action.verifyText(Data.get("7006830MTHFNAME"), Data.get("7006830MTHPYMT"), control.financeOptions);
            Reusable.clickDesc("FINC", Data.get("7006830MTHFNAME"), driver);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.finDisclosure, Data.get("FDISCLOSURE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Reusable.actvDisclmr(control.disclosureP1, Data.get("7006830MTHDIS"));
            Reusable.actvDisclmr(control.intrestTxt, Data.get("7006830MTHINTRST"));
            Reusable.actvDisclmr(control.intrestSubTxt, Data.get("7006830MTHSUBTXT"));
            Reusable.actvDisclmr(control.DisclosureReward, Data.get("REWARDHDR:"));
            Reusable.actvDisclmr(control.rewardSubTxt, Data.get("REWARDDETAILS"));
            Reusable.actvDisclmr(control.disclosureFnc, Data.get("FINCHDR:"));
            Reusable.actvDisclmr(control.finnaceSubTxt, Data.get("FINDETAILS"));
            Reusable.actvDisclmr(control.disclosureMPYMT, Data.get("SUGGESTEDHDR:"));
            Reusable.actvDisclmr(control.suggestedSubTxt, Data.get("SUGGESTEDSUBTXT"));
            Action.click_Element(control.leftNavigation);
            //36 Months
            Action.verifyText(Data.get("7006836MTHFNAME"), Data.get("7006836MTHPYMT"), control.financeOptions);
            Reusable.clickDesc("FINC", Data.get("7006836MTHFNAME"), driver);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.finDisclosure, Data.get("FDISCLOSURE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Reusable.actvDisclmr(control.disclosureP1, Data.get("7006836MTHDIS"));
            Reusable.actvDisclmr(control.intrestTxt, Data.get("7006836MTHINTRST"));
            Reusable.actvDisclmr(control.intrestSubTxt, Data.get("7006836MTHSUBTXT"));
            Reusable.actvDisclmr(control.DisclosureReward, Data.get("REWARDHDR:"));
            Reusable.actvDisclmr(control.rewardSubTxt, Data.get("REWARDDETAILS"));
            Reusable.actvDisclmr(control.disclosureFnc, Data.get("FINCHDR:"));
            Reusable.actvDisclmr(control.finnaceSubTxt, Data.get("FINDETAILS"));
            Reusable.actvDisclmr(control.disclosureMPYMT, Data.get("SUGGESTEDHDR:"));
            Reusable.actvDisclmr(control.suggestedSubTxt, Data.get("SUGGESTEDSUBTXT"));
            Action.click_Element(control.leftNavigation);
            Reusable.scroll(driver);
            Action.verify_Text(control.above199Line3, Data.get("ORTXT"));
            Action.verify_Text(control.existingMember, Data.get("EXSTMEMBER"));
            Action.verify_Text(control.NewMember, Data.get("NEWMEMBER"));
            Action.verify_Text(control.existingReward, Data.get("70068EREWARD1"));
            Action.verify_Text(control.NewReward, Data.get("70068NREWARD1"));
            Action.click_Element(control.RewardDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.RewardDetailsPage, Data.get("REWARD"));
            Reusable.actvDisclmr(control.RewardDetailsInfo, Data.get("REWARDDETAILS"));
        }
        public void TC70069()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70069ABOVE199"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70069SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70069PRC"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.IsElement(control.below199Line1);
            Action.verify_Text(control.PurchQualifies, Data.get("70069>$198.99"));
            Action.verify_Text(control.sExistingMember, Data.get("EXSTMEMBER"));
            Action.verify_Text(control.sNewMember, Data.get("NEWMEMBER"));
            Action.verify_Text(control.sExistingReward, Data.get("70069EREWARD1"));
            Action.verify_Text(control.sNewReward, Data.get("70069NREWARD1"));
            Action.click_Element(control.RewardDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.RewardDetailsPage, Data.get("REWARD"));
            Reusable.actvDisclmr(control.RewardDetailsInfo, Data.get("REWARDDETAILS"));
        }
        public void TC70070()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70070BFINANCE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70070SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70070PRC"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.IsElement(control.below199Line1);
            Action.verify_Text(control.PurchQualifies, Data.get("70070>$198.99"));
            Action.verify_Text(control.sExistingMember, Data.get("EXSTMEMBER"));
            Action.verify_Text(control.sNewMember, Data.get("NEWMEMBER"));
            Action.verify_Text(control.sExistingReward, Data.get("70070EREWARD1"));
            Action.verify_Text(control.sNewReward, Data.get("70070NREWARD1"));
            Action.click_Element(control.RewardDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.RewardDetailsPage, Data.get("REWARD"));
            Reusable.actvDisclmr(control.RewardDetailsInfo, Data.get("REWARDDETAILS"));
        }

        public void TC70071()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70071INTEREST"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70071SKU"));
            Action.verify_Text(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70071PRC"));
            Action.click_Element(control.txtCardMemberOffers);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.HDRCardMember, Data.get("HDRRBBYCARD"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Action.IsElement(control.below199Line1);
            Action.verify_Text(control.PurchQualifies, Data.get("70071>$198.99"));
            Action.verify_Text(control.flexblFncbelow199, Data.get("SUGGESTEDTXT"));
            Action.verifyText(Data.get("70071NAME"), Data.get("70071MTHPYMT"),control.financeOptions);
            Reusable.clickDesc("FINC", Data.get("70071FNAME"), driver);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.finDisclosure, Data.get("FDISCLOSURE"));
            Reusable.verifyImages(Data.get("BBYCARDIMG"), control.Images);
            Reusable.actvDisclmr(control.disclosureP1, Data.get("70071DISCLOSURE"));
            Reusable.actvDisclmr(control.intrestTxt, Data.get("70071INTRSTTXT"));
            Reusable.actvDisclmr(control.intrestSubTxt, Data.get("70071INTRSTSUBTXT"));
            Reusable.actvDisclmr(control.DisclosureReward, Data.get("REWARDHDR:"));
            Reusable.actvDisclmr(control.rewardSubTxt, Data.get("REWARDDETAILS"));
            Reusable.actvDisclmr(control.disclosureFnc, Data.get("FINCHDR:"));
            Reusable.actvDisclmr(control.finnaceSubTxt, Data.get("FINDETAILS"));
            Reusable.actvDisclmr(control.disclosureMPYMT, Data.get("SUGGESTEDHDR:"));
            Reusable.actvDisclmr(control.suggestedSubTxt, Data.get("SUGGESTEDSUBTXT"));
            Action.click_Element(control.leftNavigation);
            Action.verify_Text(control.above199Line3, Data.get("ORTXT"));
            Action.verify_Text(control.existingMember, Data.get("EXSTMEMBER"));
            Action.verify_Text(control.NewMember, Data.get("NEWMEMBER"));
            Action.verify_Text(control.existingReward, Data.get("70071EREWARD1"));
            Action.verify_Text(control.NewReward, Data.get("70071NREWARD1"));
            Action.click_Element(control.RewardDetails);
            Action.read_Text(control.titleCardMember, Data.get("titleCardMember"));
            Action.verify_Text(control.RewardDetailsPage, Data.get("REWARD"));
            Reusable.actvDisclmr(control.RewardDetailsInfo, Data.get("REWARDDETAILS"));
        }
        public void TC70072()
        {
            Action.Enter_Text(control.txtSkuUpcModel, Data.get("70072FREE"));
            Action.IsElement(control.txtSkuUpcModel).SendKeys(Keys.Enter);
            Reusable.storeLogin(control.txtStoreID, control.btnSetStore, Data.get("StoreID"));
            Action.read_Text(control.titleProdDetails, Data.get("titleProdDetails"));
            Action.verify_Text(control.productDetailsPage, Data.get("70072SKU"));
            Action.verifyTextNotExist(control.productDetailsPage, Data.get("CARDMEMBER"));
            Action.verify_Text(control.productDetailsPage, Data.get("70072PRC"));
        }









        }
}
