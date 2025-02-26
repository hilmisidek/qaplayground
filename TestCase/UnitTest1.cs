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
            //open url
            driver.Url = "https://qaplayground.dev/apps/dynamic-table/";
            
            //create new object
            dyntable page_0 = new dyntable();
            
            //initialize page
            PageFactory.InitElements(driver, page_0);

            //using method in dyntable class
            var name_real = page_0.get_name();

            Console.WriteLine("NAME :::::");
            Console.WriteLine(name_real);

            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            //initialize new object from car class inherit vehicle class
            Car proton_satria = new Car();
            
            //this portion come from vehicle class
            proton_satria.make = "Proton";
            proton_satria.model = "Satria";
            proton_satria.type = "Car";
            proton_satria.color = "Blue";
            proton_satria.transmission = "Auto";
            proton_satria.seater = 6;

            //this portion come from car class
            proton_satria.entertainment_item = "Bluetooth Player";
            proton_satria.autopilot = true;
            proton_satria.seat_cover = "Leather";

            //this method come from vehicle class
            proton_satria.vehicle_info();

            //this method come from car class
            proton_satria.car_info();


        }

        [Test]
        public void Test3_string() {
            //using built in function to reverse as string
            String input = "Awang goneng";

            //cast string to array
            Char[] arr = input.ToCharArray();
            
            //reverse
            Array.Reverse(arr);

            //initialize a new string
            String in_rev_str = new string(arr);
            
            Console.WriteLine(in_rev_str);

        }


    }
}