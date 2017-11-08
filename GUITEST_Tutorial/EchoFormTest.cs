using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace GUITEST_Tutorial
{
    /// <summary>
    /// Summary description for EchoFormTest
    /// </summary>
    [CodedUITest]
    public class EchoFormTest
    {
        const string FILE_PATH = @"Easy Calculator.exe";
        const string START_UP_FORM_NAME = "MainForm";
        const string TARGET_FORM_NAME = "EchoForm";

        [TestInitialize]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, START_UP_FORM_NAME);
            Robot.ClickMenuItem(new string[] { "Echo", "Test" });
            Robot.SetForm(TARGET_FORM_NAME);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Robot.CleanUp();
        }

        [TestMethod]
        public void TestHyperlink()
        {
            Robot.ClickHyperlink("Google");
        }

        [TestMethod]
        public void TestRadio()
        {
            Robot.ClickRadioButton("SDT");
            Robot.AssertText("ReplyLabel", "echo:SDT");
        }

        [TestMethod]
        public void TestCombo()
        {
            Robot.SetComboBox("Combo", "CSIE");
            Robot.AssertText("ReplyLabel", "echo:CSIE");
        }        

        [TestMethod]
        public void TestNumeric()
        {
            Robot.SetNumericUpDown("Numeric", "87");
            Robot.AssertNumericUpDown("Numeric", "87");
            Robot.AssertText("ReplyLabel", "echo:87");
        }        
    }
}
