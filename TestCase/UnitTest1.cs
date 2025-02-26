using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V131.DOM;
using qaplayground.PageObjects;
using SeleniumExtras.PageObjects;
using System.Drawing;

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

        [Test]
        public void Test2()
        {

            Car proton_satria = new Car();
            proton_satria.make = "Proton";
            proton_satria.model = "Satria";
            proton_satria.type = "Car";
            proton_satria.color = "Blue";
            proton_satria.transmission = "Auto";
            proton_satria.seater = 6;
            proton_satria.entertainment_item = "Bluetooth Player";
            proton_satria.autopilot = true;
            proton_satria.seat_cover = "Leather";

            proton_satria.vehicle_info();
            proton_satria.car_info();


        }

        [Test]
        public void Test3_string() {

            String input = "Awang goneng";
            Char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            String in_rev_str = new string(arr);
            Console.WriteLine(in_rev_str);

        }


    }
}