using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace GoatAppFramework
{
    public static class TestLog
    {
      
        public static TestContext testContext;
        static DataTable results;
        static int count;
        public static string resultLocation;

        public static void LogException(String ExceptionMessage,Object Control)
        {
            try
            {

                File.AppendAllText(resultLocation + "\\" + "ExceptionLog.txt",ExceptionMessage);
                Screenshot Image = ((ITakesScreenshot)Control).GetScreenshot();
                Image.SaveAsFile(Path.Combine(resultLocation, testContext.Properties["__Tfs_TestCaseId__"] + "ExceptionImage_" + count++ + ".jpg"));
            }
            catch (Exception e)
            {
            }
        }

        public static void LogInfo(String Message)
        {
            try
            {
                DataRow dr = results.NewRow();
                if (Message.Split(new char[] { ':' })[0].Length > 256)
                    dr["StepDescription"] = Message.Split(new char[] { '|' })[0].Substring(0, 255);
                else
                    dr["StepDescription"] = Message.Split(new char[] { '|' })[0];
                dr["Status"] = Message.Split(new char[] { '|' })[1];
               
                results.Rows.Add(dr);
                results.AcceptChanges();
            }
            catch (Exception e)
            {
            }
        }

        internal static void InitializeResults()
        {
            count = 1;
            resultLocation = testContext.ResultsDirectory;
            results = new DataTable();
            results.Columns.Add("Step");
            results.Columns.Add("StepDescription");
            results.Columns.Add("Status");
            results.Columns["Step"].AutoIncrement = true;
        }

        internal static void setContext(TestContext TestContext)
        {
            testContext = TestContext;
        }

        internal static bool returnFinalResult()
        {

            if (results.Select("Status = 'FAIL'").Count() > 0) return true;
            else return false;
        }

        internal static void WriteResults()
        {
            try
            {
                String content = String.Empty;
                foreach (DataColumn dc in results.Columns)
                    content += dc.ColumnName + ",";
                content = content.Remove(content.Length - 1);
                content = content + "\n";
                foreach (DataRow dr in results.Rows)
                {
                    foreach (DataColumn dc in results.Columns)
                        content += dr[dc] + ",";
                    content = content.Remove(content.Length - 1);
                    content = content + "\n";
                }
              //  File.AppendAllText(resultLocation + "\\" + testContext.Properties["__Tfs_TestCaseId__"] + "_Results.csv", content + "\n");
                  File.AppendAllText("C:\\result2.csv", content);
                string[] files = Directory.GetFiles(resultLocation);
                foreach (var file in files)
                    if (file.Contains(testContext.Properties["__Tfs_TestCaseId__"].ToString()))
                        testContext.AddResultFile(file);
            }
            catch (Exception e)
            {

            }
        }
    }
}

