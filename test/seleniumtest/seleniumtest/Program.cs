using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


public static class Script
{
    public static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://localhost:5173");

        IWebElement Header = driver.FindElement(By.Id("header"));
        Console.WriteLine("Start new test");
        IWebElement Home = driver.FindElement(By.Id("Home"));
        Home.Click();

        if(driver.Url != "http://localhost:5173/")
        {
            throw new Exception("Invalid url");
        }
    }
}