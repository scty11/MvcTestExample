using System;
using System.Runtime.Remoting.Messaging;
using System.Web.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using TestStack.Seleno.Configuration;

namespace BankingSite.FunctionalUITests
{
    public static class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        public static readonly string RootUrl;

        static BrowserHost()
        {

            //var t =
            //    @"C:\_dev\mvcTesting\5-automated-aspdotnet-mvc-m5-exercise-files\after\StronglyTypedPageObjectModels\BankingSite\BankingSite.FunctionalUITests\bin\Debug\";
            RemoteWebDriver y = new ChromeDriver();

           // y.Navigate().GoToUrl("https://www.google.co.uk/");
            Instance.Run("BankingSite", 4223, config => config.WithRouteConfig(RouteConfig.RegisterRoutes)
            .WithRemoteWebDriver(() => y));

            RootUrl = Instance.Application.Browser.Url;
        }
    }
}
