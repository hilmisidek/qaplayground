using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace qaplayground.PageObjects
{
    public class dyntable
    {
        IWebDriver driver;

        //page factory things
        [FindsBy(How = How.XPath,Using= "//tr/td//div[contains(text(),'Spider-Man')]/parent::div/parent::div/parent::td/following-sibling::td[2]")]
        //class constructor
        IWebElement row_spider_name { get; set; }

        public String get_name() {

            var r_name = row_spider_name.Text;
            return r_name;

        }


    }
}
