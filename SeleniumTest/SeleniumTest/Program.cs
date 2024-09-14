using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            
            //driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            //IWebElement element = driver.FindElement(By.Name("q"));
            //element.SendKeys("Selenium c# tutorials");

            //IWebElement elementBtn = driver.FindElement(By.Name("btnK"));
            //elementBtn.Click();


            string s = driver.FindElement(By.XPath("/html/body/center/font")).Text;
    
            driver.Quit();
        }
    }
}
