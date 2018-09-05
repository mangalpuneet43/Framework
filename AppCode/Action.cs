using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using log4net.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace GoatAppFramework
{
    public static class Action
    {

        public static IWebElement element = null;
        public static IWebElement e = null;
        public static List<IWebElement> elements = null;
        public static List<IWebElement> opts = null;
        public static List<IWebElement> ele = null;
        public static IWebDriver driver;
        public static Boolean status = false;
        public static int counter;
        public static String eText = string.Empty;




        public static void Enter_Text(Object Control, String data)
        {
            try
            {
                while (counter < 60)
                {
                    element = (IWebElement)Control;
                    if (element.Displayed)
                    {

                        element.SendKeys(data);
                        TestLog.LogInfo("String " + data + " entered in " + Control + "|PASS");
                        break;

                    }
                    else
                    {
                        Thread.Sleep(10);
                        counter = counter + 10;
                    }
                }
            }


            catch (Exception e)
            {
                TestLog.LogInfo("Error entering string " + data + " in " + Control + "|FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Control);
            
            }
        }


        public static void click_Element(Object Control)
        {
            try

            {
                while (counter < 60)
                {
                     
                    if (((IWebElement)Control).Displayed)
                    {
                        ((IWebElement)Control).Click();
                        Thread.Sleep(10000);
                       // TestLog.LogInfo("Clicked on " + Control + "|PASS");
                        break;

                    }
                    else
                    {
                        Thread.Sleep(10);
                        counter = counter + 10;
                    }
                }
            }


            catch (Exception e)
            {
                TestLog.LogInfo("Error in Clicked on " + Control + "|FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Control);
             

            }
        }
        public static void verify_Text(Object Control, String ExpectedText)
        {

            try
            {
                while(counter<60)
                {
                    element = (IWebElement)Control;

                    if (element.Displayed)
                    {
                        eText = (element.Text);
                        Console.WriteLine(eText);
                        var textarray = eText.Split('\n').ToList().ConvertAll(x => x.Trim());
                        var expectedtextarray = ExpectedText.Split('*').ToList().ConvertAll(x => x.Trim());
                  
                        if (expectedtextarray.Except(textarray, StringComparer.OrdinalIgnoreCase).Count() > 0)
                     {
                           
                            TestLog.LogInfo("ExpectedText " + ExpectedText + "not matched with " + textarray+" |FAIL");
                            Console.WriteLine("FAIL");
                            break;
                        }

                        else
                        {
                            TestLog.LogInfo("ExpectedText " + ExpectedText + " matched with " + textarray +" | PASS");
                            Console.WriteLine("PASS");
                            break;

                        }
                     
                    }
                    else
                    {
                        Thread.Sleep(10);
                        counter = counter + 10;

                    }

                }

             
            }
            catch (Exception e)
            {
                TestLog.LogInfo("Error in " + ExpectedText + " verification " + Control + "|FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Control);
               
            }
        }

        public static void verifyTextNotExist(Object Control, String ExpectedText)
        {

            try
            {
                while (counter < 60)
                {
                    element = (IWebElement)Control;

                    if (element.Displayed)
                    {
                        eText = (element.Text);
                        Console.WriteLine(eText);
                        var text = eText.Split('\n').ToList().ConvertAll(x => x.Trim());
                        var expectedtext = ExpectedText.Split('*').ToList().ConvertAll(x => x.Trim());

                        if (expectedtext.Except(text, StringComparer.OrdinalIgnoreCase).Count() > 0)
                        {

                            TestLog.LogInfo("ExpectedText " + ExpectedText + "not matched with " + text+" |PASS");
                            Console.WriteLine("PASS");
                            break;
                        }

                        else
                        {
                            TestLog.LogInfo("ExpectedText " + ExpectedText + " matched with " + text +" |FAIL");
                            Console.WriteLine("FAIL");
                            break;

                        }

                    }
                    else
                    {
                        Thread.Sleep(10);
                        counter = counter + 10;

                    }

                }


            }
            catch (Exception e)
            {
                TestLog.LogInfo("Error in " + ExpectedText + " verifocation " + Control + "|FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Control);

            }
        }


        public static void read_Text(Object Control,String ExpectedText)
        {

            try
            {
                while (counter < 60)
                {
                    element = (IWebElement)Control;
                    Console.WriteLine(element.GetAttribute("innerHTML").Trim());
                    if (element.Displayed)
                    {
                        eText = element.GetAttribute("innerHTML").Trim();
                        if (eText.Equals(ExpectedText))
                        {
                            TestLog.LogInfo("ExpectedText " + ExpectedText + "is matched with " + "ActualText " + eText + "|PASS");
                            break;
                        }


                        else
                        {
                            TestLog.LogInfo("ExpectedText " + ExpectedText + "is not matched with " + "ActualText " + eText + "|FAIL");
                            break;
                        }
                    }
                    else
                    {
                        Thread.Sleep(10);
                        counter = counter + 10;
                    }

                }
            }



            catch (Exception e)
            {
                TestLog.LogInfo("Error in Read Text from " + Control + "|FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Control);
               
            }
          

        }
        public static List<IWebElement> element_List(Object Control)
        {
            try
            {
                while (counter < 60)
                {

                    elements = (List<IWebElement>)Control;
                    Console.WriteLine(""+elements.Count);
                    if (elements.Count >= 1)
                    {

                       
                        ele= elements;
                        TestLog.LogInfo("Return Element List from " + Control + "|PASS");
                        break;
                   

                    }
                    else
                    {
                        Thread.Sleep(10);
                        counter = counter + 10;
                      

                    }
                   
                }
                if(elements.Count==0)
                    TestLog.LogInfo("Element List not Present" + Control + "|FAIL");
            }

            catch (Exception e)
            {

                TestLog.LogInfo("Error in Return Element List from " + Control + "|FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Control);
              
            }
            return ele;
        }
       
       

        public static Boolean Select_ComboBox(Object Control1, Object Control2, Object Control3, String OptionValue)
        {

            try

            {
                click_Element(Control1);


                elements = (List<IWebElement>)Control2;
                opts = (List<IWebElement>)Control3;
                foreach (IWebElement e in opts)
                {
                    String inner = e.GetAttribute("innerHTML");
                    if (inner.Equals(OptionValue))
                    {
                        click_Element(e);
                        TestLog.LogInfo("OptionValue  " + OptionValue + "selected "+ "|PASS");
                        status = true;
                        foreach (IWebElement e1 in elements)
                        {
                            String inner1 = e1.GetAttribute("innerHTML");
                            if (inner1.Equals(OptionValue))
                            {
                                break;
                            }

                        }
                        break;
                    }
                }

            }

            catch (Exception e)
            {
                TestLog.LogInfo("Error in OptionValue  " + OptionValue + "select " + "|FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Control1);
               
            }
            return status;
        }


        public static IWebElement IsElement(Object Control)
        {
            
                try
                {
                while (counter < 20)
                {
                 
                    if (((IWebElement)Control).Displayed)
                    {
                        e = (IWebElement)Control;
                        TestLog.LogInfo("Element return from " + Control + "|PASS");
                        break;
                    }
                    else
                    {
                        Thread.Sleep(10);
                        counter = counter + 10;
                    }

                }
                }

            catch (Exception e)
            {
                TestLog.LogInfo("Error in Element return from " + Control + "|FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", Control);
           
            }
            return e;
        }

        public static void verifyText(Object parent,string item,string Expected)
        {

            try
            {

                IWebElement Parent = (IWebElement)parent;
                IList<IWebElement> child = Parent.FindElements(By.ClassName("ng-star-inserted"));
                IWebElement target = child.Single(o => Regex.IsMatch(o.Text, item));
                Console.WriteLine(target.Text);
                eText = (target.Text);
            
                var text = eText.Split('\n').ToList().ConvertAll(x => x.Trim());
                var expectedtext = Expected.Split('*').ToList().ConvertAll(x => x.Trim());

                if (expectedtext.Except(text, StringComparer.OrdinalIgnoreCase).Count() > 0)
                {

                    TestLog.LogInfo(item+" ExpectedText " + Expected + "not matched with " + text+" |FAIL");
          
                 
                }

                else
                {
                    TestLog.LogInfo(item+" ExpectedText " + Expected + " matched with " + text+" |PASS");
                    
              

                }

            }

            catch (Exception e)
            {
                TestLog.LogInfo(item + " text and value is not Matched |FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", parent);
            }

        }
        public static void verifyText(string item, string Expected, Object control)
        {

          try
                {
                
                    IList<IWebElement> child = (IList<IWebElement>)control;
                    Console.WriteLine(child.Count);
            
                    IWebElement target = child.Single(o => Regex.IsMatch(o.Text, item));
                    Console.WriteLine(target.Text);
            
                eText = (target.Text);

                    var text = eText.Split('\n').ToList().ConvertAll(x => x.Trim());
                    var expectedtext = Expected.Split('*').ToList().ConvertAll(x => x.Trim());

                    if (expectedtext.Except(text, StringComparer.OrdinalIgnoreCase).Count() > 0)
                    {

                    TestLog.LogInfo(item + " ExpectedText " + Expected + "not matched with " + text+" |FAIL");
                    Console.WriteLine("FAIL");

                    }

                    else
                    {
                        TestLog.LogInfo(item + " ExpectedText " + Expected + " matched with " + text+" |PASS");
                       Console.WriteLine("PASS");

                    

                }

            }

            catch (Exception e)
            {
                TestLog.LogInfo(item + " text and value is not Matched |FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", control);
            }

        }



        public static IWebDriver AppLaunch(String browser)
        {
            IWebDriver driver = null;
            try
            {

                if (browser.Equals("firefox"))
                {
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(Constants.GoatURL);
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);


                }
                else if (browser.Equals("IE"))
                {


                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(Constants.GoatURL);
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                    TestLog.LogInfo("App is Launched"+ Constants.GoatURL +"|PASS");


                }

                else if (browser.Equals("chrome"))
                {

                    driver = new ChromeDriver();
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(Constants.GoatURL);
                   
                    TestLog.LogInfo("App is Launched" + Constants.GoatURL + "|PASS");


                }
            }


            catch (Exception e)
            {
                TestLog.LogInfo("Error in App Launching" + Constants.GoatURL + "|FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", driver);
            

            }
            return driver;

        }

        public static void closeBrowser(IWebDriver driver)
        {

            try
            {
                driver.Quit();
                TestLog.LogInfo("App is Closed " +"|PASS");

            }
            catch (Exception e)
            {
                TestLog.LogInfo("error in App closing" + "|FAIL");
                TestLog.LogException(e.Message + "\n" + e.StackTrace + "\n", driver);
              
            }
        }

    }
}

