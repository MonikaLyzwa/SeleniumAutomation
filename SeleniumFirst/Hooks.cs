using OpenQA.Selenium.Firefox;
using SeleniumFirst;

namespace SeleniumParallelTest
{
    public class Hooks : Base
    {
        //private FirefoxParallelTests Driver;

        public Hooks()
        {
            Driver = new FirefoxDriver();
        }

    }
}
