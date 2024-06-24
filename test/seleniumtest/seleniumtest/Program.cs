using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

public static class Script
{
    public static void Main()
    {
        // Initialize Chrome WebDriver
        IWebDriver driver = new ChromeDriver();

        try
        {
            // Navigate to Home Page
            driver.Navigate().GoToUrl("http://localhost:5173");

            // Wait for page to load
            System.Threading.Thread.Sleep(3000);

            // Navigate to About Page
            IWebElement aboutLink = driver.FindElement(By.XPath("//a[contains(text(), 'About')]"));
            aboutLink.Click();

            // Wait for page to load
            System.Threading.Thread.Sleep(7000);

            // Click on the "Vue" link
            IWebElement vueLink = driver.FindElement(By.XPath("//a[contains(text(), 'Vue')]"));
            vueLink.Click();

            // Wait for page to load
            System.Threading.Thread.Sleep(3000);

            // Click on the "Jenkins" link
            IWebElement jenkinsLink = driver.FindElement(By.XPath("//a[contains(text(), 'Jenkins')]"));
            jenkinsLink.Click();

            // Wait for page to load
            System.Threading.Thread.Sleep(3000);

            // Click on the "GitHub" link
            IWebElement githubLink = driver.FindElement(By.XPath("//a[contains(text(), 'GitHub')]"));
            githubLink.Click();

            // Wait for page to load
            System.Threading.Thread.Sleep(3000);

            // Click on the "Selenium" link
            IWebElement seleniumLink = driver.FindElement(By.XPath("//a[contains(text(), 'Selenium')]"));
            seleniumLink.Click();

            // Wait for page to load
            System.Threading.Thread.Sleep(3000);

            // Click on the "000webhost.com" link
            IWebElement webhostLink = driver.FindElement(By.XPath("//a[contains(text(), '000webhost.com')]"));
            webhostLink.Click();

            // Wait for page to load
            System.Threading.Thread.Sleep(3000);

            // Click on the "Publish over FTP" link
            IWebElement ftpLink = driver.FindElement(By.XPath("//a[contains(text(), 'Publish over FTP')]"));
            ftpLink.Click();

            // Wait for page to load
            System.Threading.Thread.Sleep(3000);

        }
        finally
        {
            // Close the WebDriver session
            driver.Quit();
        }
    }

    // Method to switch to the new tab or window
    public static void SwitchToNewTab(IWebDriver driver)
    {
        // Get all window handles
        IReadOnlyCollection<string> handles = driver.WindowHandles;

        // Switch to the last opened window (assuming the new one is the last one)
        foreach (string handle in handles)
        {
            driver.SwitchTo().Window(handle);
        }
    }
}