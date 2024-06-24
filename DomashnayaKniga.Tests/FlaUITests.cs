using System;
using System.Diagnostics;
using System.Threading;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using FlaUI.UIA3;

namespace DomashnayaKniga.Tests
{
    public class FlaUITests
    {
        [Fact]
        public void LoginWithNewAccount()
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory + "DomashnayaKniga.exe";
            var app = Application.Launch(directory);
            var auto = new UIA3Automation();
            var main = app.GetMainWindow(auto);
            var cf = new ConditionFactory(new UIA3PropertyLibrary());

            main.FindFirstDescendant(cf.ByAutomationId("gotoSignup")).AsLabel().Click();
            Thread.Sleep(2000);
            main = app.GetAllTopLevelWindows(auto)[0];
            string login = "flaui" + (Environment.TickCount % 1000).ToString();
            main.FindFirstDescendant(cf.ByAutomationId("textBoxLogin")).AsTextBox().Enter(login);
            main.FindFirstDescendant(cf.ByAutomationId("textBoxPassword")).AsTextBox().Enter("testing");
            main.FindFirstDescendant(cf.ByAutomationId("textBoxPassword2")).AsTextBox().Enter("testing");
            main.FindFirstDescendant(cf.ByAutomationId("textBoxFirstName")).AsTextBox().Enter("Искусственный");
            main.FindFirstDescendant(cf.ByAutomationId("textBoxLastName")).AsTextBox().Enter("Интеллект");
            main.FindFirstDescendant(cf.ByAutomationId("buttonSignup")).AsButton().Click();
            Keyboard.Press(VirtualKeyShort.ENTER);
            Thread.Sleep(2000);
            main = app.GetAllTopLevelWindows(auto)[0];
            main.FindFirstDescendant(cf.ByAutomationId("textBoxLogin")).AsTextBox().Enter(login);
            main.FindFirstDescendant(cf.ByAutomationId("textBoxPassword")).AsTextBox().Enter("testing");
            main.FindFirstDescendant(cf.ByAutomationId("buttonLogin")).AsButton().Click();
            Thread.Sleep(2000);
            main = app.GetAllTopLevelWindows(auto)[0];
            Assert.Equal("WinMain", main.AutomationId);
            main.Close();
        }
    }
}
