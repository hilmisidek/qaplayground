using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using qaplayground.PageObjects;
using SeleniumExtras.PageObjects;

namespace qaplayground.TestCase
{
    public class Tests
    {
        IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();


        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://qaplayground.dev/apps/dynamic-table/";
            dyntable page_0 = new dyntable();
            PageFactory.InitElements(driver, page_0);
            var name_real = page_0.get_name();
            Console.WriteLine("NAME :::::");
            Console.WriteLine(name_real);

            Assert.Pass();
        }
    }
}