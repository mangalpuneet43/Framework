using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GoatAppFramework
{
    public class Control
    {
        public IWebDriver driver;
        //Login Page Object

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement btnSignIN { get; set; }

        //Store Page Object
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Store Number')]")]
        public IWebElement labelStoreNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='number']")]
        public IWebElement txtStoreID { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Set Store')]")]
        public IWebElement btnSetStore { get; set; }
        [FindsBy(How = How.XPath, Using = "//img[@src='assets/images/BBY_SignSystem.png']")]
        public IWebElement imgStorLogo { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'OAT')]")]
        public IWebElement labelGoat { get; set; }





        //Scan Page Object
        [FindsBy(How = How.XPath, Using = "//img[@src='assets/images/scan.png']")]
        public IWebElement imgScanQrCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'SKU, UPC, or Model #')]")]
        public IWebElement labelSkuUpcModel { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='query']")]
        public IWebElement txtSkuUpcModel { get; set; }


        //Product Details Object

        [FindsBy(How = How.XPath, Using = "//div[2][contains(.,'PRODUCT DETAILS')]")]
        public IWebElement titleProdDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@src='assets/images/grid.png']")]
        public IWebElement menuHome { get; set; }



        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Bundle & Save')]")]
        public IWebElement txtBundleSave { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Other Options')]")]
        public IWebElement txtOtherOptions { get; set; }


        [FindsBy(How = How.XPath, Using = "//div/div[1]/div/div/div[2]")]
        public IWebElement txtBundleAvlbl { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/div[2]/div/div/div[2]")]
        public IWebElement txtOtherAvlbl { get; set; }


        [FindsBy(How = How.XPath, Using = "//app-root/div[2]")]
        public IWebElement productDetailsPage { get; set; }

        [FindsBy(How = How.TagName, Using = "img")]
        public IList<IWebElement> Images { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[3]/app-footer/div/div/div[1]")]
        public IWebElement leftNavigation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[3]/app-footer/div/div/div[2]")]
        public IWebElement rightNavigation { get; set; }

        //Customer rating:
        [FindsBy(How = How.XPath, Using = "//product-details/div/div[1]/div[2]/div[2]/div/div/div/div")]
        public IWebElement rating_Star{get;set;}

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Rating')]")]
        public IWebElement ratingHDR { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='totalReview']")]
        public IWebElement totalRVW { get; set; }

       
        //Bundle Offers Object
        [FindsBy(How = How.XPath, Using = "//div[2][contains(text(),'BUNDLE OFFERS')]")]
        public IWebElement titleBundleOffers { get; set; }
       
   
     
        [FindsBy(How = How.XPath, Using = "//bundles-offer/div[2]/div/div/div[2]/span")]
        public IWebElement O_bundleDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//bundles-offer/div[2]/div[1]/div/div[2]/span")]
        public IWebElement iconBDetail1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//bundles-offer/div[2]/div[2]/div/div[2]/span")]
        public IWebElement iconBDetail2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//bundles-offer/div[2]/div[3]/div/div[2]/span")]
        public IWebElement iconBDetail3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//bundles-offer/div[2]/div[4]/div/div[2]/span")]
        public IWebElement iconBDetail4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//bundles-offer/div[3]/div/div/div[2]/span")]
        public IWebElement iconBDetail5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//bundles-offer/div[4]/div[1]/div/div[2]/span")]
        public IWebElement iconBDetail6 { get; set; }

        [FindsBy(How = How.XPath, Using = "//bundles-offer/div[4]/div[2]/div/div[2]/span")]
        public IWebElement iconBDetail7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//bundles-offer/div[5]/div[1]/div/div[2]/span")]
        public IWebElement iconBDetail8 { get; set; }
        [FindsBy(How = How.XPath, Using = "//bundles-offer/div[5]/div[2]/div/div[2]/span")]
        public IWebElement iconBDetail9 { get; set; }
        [FindsBy(How = How.XPath, Using = "//bundles-offer/div[5]/div[3]/div/div[2]/span")]
        public IWebElement iconBDetail10 { get; set; }

        [FindsBy(How = How.XPath, Using = "//app-root/div[2]")]
        public IWebElement bundleOffersPage { get; set; }

        //Bundle Details Object

        [FindsBy(How = How.XPath, Using = "//div[2][contains(text(),'BUNDLE DETAILS')]")]
        public IWebElement titleBundleDetails { get; set; }




        [FindsBy(How = How.XPath, Using = "//offer-details/div/div")]
        public IWebElement bundleDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//offer-details/div/div/div[1]/div")]
        public IWebElement bundleDetails0 { get; set; }

       
        [FindsBy(How = How.XPath, Using = "//offer-details/div/div/div[2]/div[@class='ng-star-inserted']")]
        public IList<IWebElement> bundleDetail { get; set; }

        [FindsBy(How = How.XPath, Using = "//offer-details/div/div")]
        public IWebElement anyBundle { get; set; }

        //Other Options
        [FindsBy(How = How.XPath, Using = "//div[2][contains(.,'OTHER OPTIONS')]")]
        public IWebElement titleOtherOptions { get; set; }
        [FindsBy(How = How.XPath, Using = "//related-sku/div/div[@class='ng-star-inserted']")]
        public IList<IWebElement> otherOptions { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[2]/ng-component/div/related-sku/div/div[1]")]
        public IWebElement otherOption1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/related-sku/div/div[2]")]
        public IWebElement otherOption2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/related-sku/div/div[3]")]
        public IWebElement otherOption3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/related-sku/div/div[4]")]
        public IWebElement otherOption4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/related-sku/div/div[5]")]
        public IWebElement otherOption5 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div/related-sku/div/div[6]")]
        public IWebElement otherOption6 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div/related-sku/div/div[7]")]
        public IWebElement otherOption7 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div/related-sku/div/div[7]")]
        public IWebElement otherOption10 { get; set; }

    

        //Open Box Objects

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Open Box')]")]
        public IWebElement txtOpenBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[2][contains(.,'OPEN BOX')]")]
        public IWebElement titleOpenBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Open Box')]")]
        public IWebElement headerOpenBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//open-box/div[2]")]
        public IWebElement openBoxPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//open-box/div[3]/div[1]")]
        public IWebElement openBoxCondtns1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//open-box/div[3]/div[2]")]
        public IWebElement openBoxCondtns2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//open-box/div[3]/div[3]")]
        public IWebElement openBoxCondtns3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//open-box/div[3]/div[4]")]
        public IWebElement openBoxCondtns4 { get; set; }

        //Activation Products Objects

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Activation Offers')]")]
        public IWebElement txtActivationProducts { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2][contains(.,'ACTIVATION OFFER')]")]
        public IWebElement titleActProducts { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Activation Offers')]")]
        public IWebElement headerActProducts { get; set; }

        [FindsBy(How = How.XPath, Using = "//activation-offer/div[2]")]
        public IWebElement ActProdDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//activation-offer/div[3]")]
        public IWebElement ActProdCarrier { get; set; }

        [FindsBy(How = How.XPath, Using = "//activation-offer/div[4]")]
        public IWebElement ActPlan1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//activation-offer/div[5]")]
        public IWebElement ActPlan2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//activation-offer/div[6]")]
        public IWebElement ActPlan3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//activation-offer/div[7]")]
        public IWebElement ActPlan4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//activation-offer/div[8]")]
        public IWebElement ActPlan5 { get; set; }

        [FindsBy(How = How.XPath, Using = "//activation-offer/div[9]")]
        public IWebElement ActPlan6 { get; set; }


        [FindsBy(How = How.XPath, Using = "//activation-offer/div[10]")]
        public IWebElement ActPlan7 { get; set; }

        [FindsBy(How = How.XPath, Using = "//activation-offer/div[11]")]
        public IWebElement ActPlan8 { get; set; }

        [FindsBy(How = How.XPath, Using = "//activation-offer/div[12]")]
        public IWebElement ActPlan9 { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'AT&T')]")]
        public IWebElement CarrierATT { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Verizon')]")]
        public IWebElement CarrierVER { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Sprint')]")]
        public IWebElement CarrierSPRT { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Manufacturer')]")]
        public IWebElement actvDisclmr { get; set; }
        [FindsBy(How = How.XPath, Using = "//related-sku/div/div[@class='ng-star-inserted']")]
        public IList<IWebElement> actvOtherOptions { get; set; }


     


        //Related Products
        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Related Products')]")]
        public IWebElement txtRelatedProducts { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[2][contains(.,'RELATED PRODUCTS')]")]
        public IWebElement titleRelProducts { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Related Products')]")]
        public IWebElement headerRelProducts { get; set; }
        [FindsBy(How = How.XPath, Using = "//div/related-sm/div/div[2]/div[@class='ng-star-inserted']")]
        public IList<IWebElement> relatedSubGroups { get; set; }
        [FindsBy(How = How.XPath, Using = "//related-sm/div/div[2]/div")]
        public IWebElement relatedSubGroups1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/related-sm/div/div[2]/div[1]/div[2]/div[1]/div/div/div[1]/span")]
        public IWebElement Group1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/related-sm/div/div[2]/div[2]/div[2]/div[3]/div/div/div[1]/span")]
        public IWebElement Group2 { get; set; }
      

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Accessories')]")]
        public IWebElement txtAccessories { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Consumable')]")]
        public IWebElement txtConsumable { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Cross-sell')]")]
        public IWebElement txtCrossSell { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2][contains(.,'RELATED')]")]
        public IWebElement titleRelated { get; set; }
        [FindsBy(How = How.XPath, Using = "//related-skus-sm/div[1]")]
        public IWebElement InRelSubgroup{ get; set; }
        [FindsBy(How = How.XPath, Using = "//div/related-skus-sm/div[@class='ng-star-inserted']")]
        public IList<IWebElement> relatedDetails{ get; set; }


        //Services
        [FindsBy(How = How.XPath, Using = ".//div[contains(text(),'Services')]")]
        public IWebElement txtServices { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[2][contains(.,'SERVICES')]")]
        public IWebElement titleServices { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Services')]")]
        public IWebElement headerServicesProducts { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/service-skus/div[1]")]
        public IWebElement InGSPSubgroup { get; set; }
        [FindsBy(How = How.XPath, Using = "//services/div/div[2]/div[@class='ng-star-inserted']")]
        public IList<IWebElement> GSPAVLBL { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/service-skus/div[@class='ng-star-inserted']")]
        public IList<IWebElement> servicesDetails { get; set; }

        //Card Members
        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Cardmember Offers')]")]
        public IWebElement txtCardMemberOffers { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2][contains(.,'CARDMEMBER')]")]
        public IWebElement titleCardMember { get; set; }
        [FindsBy(How = How.XPath, Using = "//div/finance/div/div[1]/div[2]/span")]
        public IWebElement HDRCardMember { get; set; }


        [FindsBy(How = How.XPath, Using = "//finance/div/div[2]/div[1]/span")]
        public IWebElement PurchAmt { get; set; }
        [FindsBy(How = How.XPath, Using = "//finance/div/div[2]/div[2]/div[1]/div[1]")]
        public IWebElement RewardsBack5Per { get; set; }
        [FindsBy(How = How.XPath, Using = "//finance/div/div[2]/div[2]/div[1]/div[2]")]
        public IWebElement txtOR{ get; set; }

        [FindsBy(How = How.XPath, Using = "//finance/div/div[2]/div[2]/div[1]/div[3]")]
        public IWebElement txtflexblFnc { get; set; }
        [FindsBy(How = How.XPath, Using = "//finance/div/div[2]/div[2]/div[2]")]
        public IWebElement RewardBack10Per { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'See Details')]")]
        public IWebElement seeDetails { get; set; }
        [FindsBy(How = How.XPath, Using = "//span/b[contains(text(),'This purchase qualifies for :')]")]
        public IWebElement PurchQualifies { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div[1]/div")]
        public IWebElement flexblFncbelow199 { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div[2]/div[1]/div[1]")]
        public IWebElement existingMember { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div[2]/div[1]/div[2]")]
        public IWebElement NewMember { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div[2]/div[2]/div[1]")]
        public IWebElement existingReward { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div[2]/div[2]/div[2]")]
        public IWebElement NewReward { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Reward Details')]")]
        public IWebElement RewardDetails { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Reward Details')]")]
        public IWebElement RewardDetailsPage { get; set; }
        [FindsBy(How = How.XPath, Using = "//reward-details/div/div[2]")]
        public IWebElement RewardDetailsInfo{ get; set; }


        [FindsBy(How = How.XPath, Using = "//finance/div/hr")]
        public IWebElement below199Line1 { get; set; }


        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div[1]/hr")]
        public IWebElement below199Line2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div[1]/h4")]
        public IWebElement above199Line3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div[1]/div[2]/div[@class='row financedetails ng-star-inserted']")]
        public IList<IWebElement> financeOptions { get; set; }
        [FindsBy(How = How.XPath, Using = "//finance-offer-detail/div/div[1]")]
        public IWebElement finDisclosure { get; set; }
        [FindsBy(How = How.XPath, Using = "//finance-offer-detail/div/div[2]/div[2]/span")]
        public IWebElement disclosureP1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance-offer-detail/div/div[3]")]
        public IWebElement intrestTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance-offer-detail/div/div[4]")]
        public IWebElement intrestSubTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Reward Details:')]")]
        public IWebElement DisclosureReward{ get; set; }
        [FindsBy(How = How.XPath, Using = "//finance-offer-detail/div/div[6]")]
        public IWebElement rewardSubTxt { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Financing Details:')]")]
        public IWebElement disclosureFnc { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance-offer-detail/div/div[8]")]
        public IWebElement finnaceSubTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Suggested Monthly Payments:')]")]
        public IWebElement disclosureMPYMT { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance-offer-detail/div/div[10]")]
        public IWebElement suggestedSubTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div/div[1]/div[1]")]
        public IWebElement sExistingMember { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div/div[1]/div[2]")]
        public IWebElement sNewMember { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div/div[2]/div[1]")]
        public IWebElement sExistingReward { get; set; }

        [FindsBy(How = How.XPath, Using = "//finance/div/div[3]/div/div[2]/div[2]")]
        public IWebElement sNewReward { get; set; }


        

        public Control(IWebDriver driver)
        { 
            PageFactory.InitElements(driver, this);
        }



    }
}
