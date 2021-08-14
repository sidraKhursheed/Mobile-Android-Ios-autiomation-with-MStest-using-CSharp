using System;
using System.Threading;
using AventStack.ExtentReports;
using Ios_Android_Project.PageObjectModel;
using Ios_Android_Project.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Ios_Android_Project
{
    [TestClass]
    public class LaunchApplication:BaseClass
    {
        
        public void DummyApplicationLaunch()
        {
            string button1 = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View[2]/android.app.Dialog/android.view.View/android.widget.Button[1]";
            ExtentTest test = extent.CreateTest("DummyApplicationLaunch").Info("Test Started");
            Thread.Sleep(1000);
            IWebElement Button1Element = Base.ElementByXpath(button1);
            test.Info("Button Found");
            Thread.Sleep(ts);
            if (Button1Element.Text == "Looking for a place to stay")
            {
                test.Pass("Test case Pass", MediaEntityBuilder.CreateScreenCaptureFromPath(TakesScreenshot("ScreenShot")).Build());
                test.Info("Button assertion passed");
            }

            else
            {
                test.Fail("Test case failed", MediaEntityBuilder.CreateScreenCaptureFromPath(TakesScreenshot("ScreenShot")).Build());
                test.Info("Assertion failed");
            }
            test.Info("Test Finished");
        }

        [TestAttribute(UserMode = UserMode.Normal)]

        [TestCategory("Web TestCases Production New")]
        public void ApplicationLaunch()
        {
            Run(DummyApplicationLaunch);
        }
    }
}
