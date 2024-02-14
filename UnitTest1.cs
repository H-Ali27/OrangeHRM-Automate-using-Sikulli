using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SikuliModule;
using System;
using WindowsInput;

namespace SikuliProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExecutionClass()
        {
            IWebDriver driver = new ChromeDriver();
            InputSimulator sim = new InputSimulator();
            driver.Manage().Window.Maximize();

            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

            SikuliAction.Click(@"E:\Seleium\SikuliProject\Pictures\005.png");
            sim.Keyboard.TextEntry("Admin");

            SikuliAction.Click(@"E:\Seleium\SikuliProject\Pictures\004.png");
            sim.Keyboard.TextEntry("admin123");

            SikuliAction.Click(@"E:\Seleium\SikuliProject\Pictures\003.png");

            SikuliAction.Click(@"E:\Seleium\SikuliProject\Pictures\002.png");

            SikuliAction.Click(@"E:\Seleium\SikuliProject\Pictures\001.png");
        }
    }
}
