using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumFirst;

namespace SeleniumParallelTest
{
    public class Hooks : Base
    {
        //private FirefoxParallelTests Driver;

        public Hooks()
        {
            // Driver = new FirefoxDriver();
            Driver = new ChromeDriver();
        }

        ~Hooks()
        {
            Driver.Quit();
        }
    }
}
