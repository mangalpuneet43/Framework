using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoatAppFramework
{
    public static class Reusable
    {
        public static Boolean status = false;
        public static int counter;
        public static IWebDriver driver;
        public static IWebElement element;


        public static Boolean IsDisplayed(Object Control)
        {
            try
            {

                if (Action.IsElement(Control).Displayed)
                {

                    status = true;
                    TestLog.LogInfo(Control + " Element is displayed |PASS");
                }
                else
                {

                    status = false;
                    TestLog.LogInfo(Control + " Element is not displayed |FAIL");
                }
            }
            catch (Exception e)
            {


            }
            return status;
        }
        public static Boolean IsEnabled(Object Control)
        {
            try
            {

                if (Action.IsElement(Control).Enabled)
                {

                    status = true;
                    TestLog.LogInfo(Control + " Element is enabled |PASS");
                }
                else
                {

                    status = false;
                    TestLog.LogInfo(Control + " Element is not enabled |FAIL");
                }
            }
            catch (Exception e)
            {

                TestLog.LogInfo("Error in IsEnabled |FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Control);
            }
            return status;
        }

        public static void IsDisabled(Object Control, string carrier)
        {
            try
            {

                if (Action.IsElement(Control).Enabled)
                {

                    status = true;
                    TestLog.LogInfo(carrier + " button is enabled |FAIL");
                }
                else
                {

                    status = false;
                    TestLog.LogInfo(carrier + " button is not enabled |PASS");
                }
            }
            catch (Exception e)
            {

                TestLog.LogInfo("Error in IsDisabled |FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", carrier);
            }

        }
        public static void Login(Object Username, Object Password, Object SignIn)
        {
            try
            {
                Action.Enter_Text(Username, Constants.ETKUSER);
                Action.Enter_Text(Password, Constants.ETKPWD);
                Action.click_Element(SignIn);
                TestLog.LogInfo("APP is Login |PASS");


            }
            catch (Exception e)
            {
                TestLog.LogInfo("Error in APP Login |FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", SignIn);
            }

        }

        public static void storeLogin(Object txtStoreID, Object btnSetStore, string Data)
        {
            try
            {

                if (((IWebElement)btnSetStore).Displayed)
                {

                    Action.Enter_Text(txtStoreID, Data);
                    Action.click_Element(btnSetStore);
                    TestLog.LogInfo("Store Page is displayed |PASS");
                }
                else
                {

                    TestLog.LogInfo("Stor Page is not displayed |PASS");
                }
            }
            catch (Exception e)
            {
                TestLog.LogInfo("Error in storeLogin() |FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", btnSetStore);
            }


        }




        public static void waitForPage(IWebDriver driver)
        {
            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            }
            catch (Exception e)
            {


            }
        }

        public static void scroll(IWebDriver driver)
        {
            try
            {


                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,1000)");
                TestLog.LogInfo("Page is scrolled |PASS");

            }

            catch (Exception e)
            {
                TestLog.LogInfo("Exception in Page is scrolling |FAIL");
            }
        }

        public static void actvDisclmr(Object Control, String ExpectedText)
        {

            try
            {

                element = (IWebElement)Control;
                Console.WriteLine(element.Text);
             
                if (element.Text.Equals(ExpectedText))
                {
                    TestLog.LogInfo("ExpectedText " + ExpectedText + "matched with " + "ActualText |PASS");
                    Console.WriteLine("Pass");


                }

                else
                {

                    TestLog.LogInfo("ExpectedText " + ExpectedText + "not matched with " + "ActualText |FAIL");
                    Console.WriteLine("Fail");
                }
            }
            catch (Exception e)
            {
                TestLog.LogInfo("Error in " + ExpectedText + " verification " + Control + "|FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Control);

            }
        }


        public static void scrollUp(IWebDriver driver)
        {
            try
            {


                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,-1000)");
                TestLog.LogInfo("Page is scrolled |PASS");
                Thread.Sleep(1000);

            }

            catch (Exception e)
            {
                TestLog.LogInfo("Exception in Page is scrolling |FAIL");
            }
        }

        public static void scrollToElement(IWebDriver driver, Object Control)
        {
            try
            {

                element = driver.FindElement(By.XPath("//span[contains(text(),'" + Control + "')]"));
                if (element.Displayed)
                {
                    Console.WriteLine("Text is displayed");
                }
                else
                {
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    js.ExecuteScript("arguments[0].scrollIntoView();", element);
                    TestLog.LogInfo("Page is scrolled |PASS");
                    Thread.Sleep(1000);
                }

            }

            catch (Exception e)
            {
                TestLog.LogInfo("Exception in Page is scrolling |FAIL");
            }
        }




        public static void verifyImages(String ImgURL, Object control)
        {
             Boolean flag = false;

            try
            {
                IList<IWebElement> elements = (IList<IWebElement>)control;
                foreach (IWebElement e in elements)
                {
                    Console.WriteLine(e.GetAttribute("src"));
                    if (e.GetAttribute("src").Equals(ImgURL) && e.Displayed)
                    {
                        flag = true;

                        TestLog.LogInfo("Image is displayed |PASS");
                        Console.WriteLine("Pass");

                        break;
                    }
                  
                }
                if (!flag)
                {
                    TestLog.LogInfo("Image is not displayed |FAIL");
                    Console.WriteLine("Fail");
                }

            }
            catch (Exception e)
            {
                TestLog.LogInfo("Error in verifyImages |FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", control);

            }
        }

        public static void clickDesc(String Menu, string pos, IWebDriver driver)
        {

            try
            {
                switch (Menu)
                {
                    case "OtherOption":
                        element = driver.FindElement(By.XPath("//related-sku/div/div[" + pos + "]/product-details/div/div[1]/div[1]"));
                        if (element.Displayed)
                        {
                            element.Click();
                            Thread.Sleep(2000);
                            TestLog.LogInfo(Menu + " " + pos + " Description is clicked |PASS");
                        }
                        else
                            TestLog.LogInfo(Menu + " " + pos + " Description is not clicked |FAIL");
                        break;
                    case "BundleAll":
                        element = driver.FindElement(By.XPath("//offer-details/div/div/div[3]/div/div[2]/offer-sku/div/div/div[2]"));
                        //offer-details/div/div/div[3]/div/div[2]/offer-sku/div/div/div[2]
                        if (element.Displayed)
                        {
                            element.Click();
                            Thread.Sleep(2000);
                            TestLog.LogInfo(Menu + " " + pos + " Description is clicked |PASS");
                        }
                        else
                            TestLog.LogInfo(Menu + " " + pos + " Description is not clicked |FAIL");
                        break;
                    case "BundleAny":
                        element = driver.FindElement(By.XPath("//offer-details/div/div/div[2]/div[" + pos + "]/offer-sku/div/div/div[2]/div[2]/div"));
                        if (element.Displayed)
                        {
                            element.Click();
                            Thread.Sleep(2000);
                            TestLog.LogInfo(Menu + " " + pos + " Description is clicked |PASS");
                        }
                        else
                            TestLog.LogInfo(Menu + " " + pos + " Description is not clicked |FAIL");
                        break;
                    case "Services":
                        element = driver.FindElement(By.XPath("//div[contains(text(),'" + pos + "')]"));
                        if (element.Displayed)
                        {
                            element.Click();
                            Thread.Sleep(2000);
                            TestLog.LogInfo(Menu + " " + pos + " Description is clicked |PASS");
                        }
                        else
                            TestLog.LogInfo(Menu + " " + pos + " Description is not clicked |FAIL");
                        break;
                    case "FINC":
                        element = driver.FindElement(By.XPath("//div[contains(text(),'"+pos+"')]"));
                        if (element.Displayed)
                        {
                            element.Click();
                            Thread.Sleep(2000);
                            TestLog.LogInfo(Menu + " " + pos + " OfferName is clicked |PASS");
                        }
                        else
                            TestLog.LogInfo(Menu + " " + pos + " OfferName is not clicked |FAIL");
                        break;
                    case "BundleDetails":
                        element = driver.FindElement(By.XPath("//div[contains(text(),'"+pos+"')]"));
                        if (element.Displayed)
                        {
                            element.Click();
                            Thread.Sleep(2000);
                            TestLog.LogInfo(Menu + " " + pos + " OfferName is clicked |PASS");
                        }
                        else
                            TestLog.LogInfo(Menu + " " + pos + " OfferName is not clicked |FAIL");
                        break;

                }

            }
           

            catch (Exception e)
            {
                TestLog.LogInfo("Error in clickDesc() |FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Menu);
            }





        }

        public static void clickBundleDetails(int pos, IWebDriver drv)
        {
            try
            {

                IList<IWebElement> element = driver.FindElements(By.ClassName("icon"));
                foreach (IWebElement e in element)
                {
                    if (e.Displayed && ++counter == pos)
                    {
                        e.Click();
                        TestLog.LogInfo(pos + "nd Bundle Details icon is clicked |PASS");
                        break;
                    }



                }



            }
            catch (Exception e)
            {
                TestLog.LogInfo("Error in clickBundleDetails() |FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", "BundleDetailsIcon");
            }
        }



        public static void IsRelatedSubGroup(string control, IWebDriver driver)
        {

            try
            {
                while (counter < 30)
                {

                    element = driver.FindElement(By.XPath("//span[contains(text(),'" + control + "')]"));

                    if (element.Text.Equals(control))
                    {
                        element.Click();
                        Thread.Sleep(3000);
                        TestLog.LogInfo(control + " SubGroup is displayed and clicked |PASS");
                        break;
                    }
                    else
                    {
                        Thread.Sleep(10);
                        counter = counter + 10;
                        Reusable.scroll(driver);

                    }
                }

            }

            catch (Exception e)
            {
                TestLog.LogInfo(control + " SubGroup is not displayed |FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", control);
            }

        }
        public static void IsCustomerRating(Object Control,String Data)
        {
            try
            {
               IWebElement e = (IWebElement)Control;

                Console.WriteLine(e.GetAttribute("style").Equals(Data));
                if (e.GetAttribute("style").Equals(Data))
                {

                    TestLog.LogInfo("Rating Star is displayed correct |PASS");
                }

                else
                    TestLog.LogInfo("Rating Star is displayed Incorrect |FAIL");
            }

            catch (Exception e)
            {
                TestLog.LogInfo("Error in  IsCustomerRating() |FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Control.GetType());
            }
        }

    }
}

