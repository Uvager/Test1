using System.Drawing;
using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace PlaywrightTests;
public class BasePage
{
    string url = "https://demowebshop.tricentis.com/";
    public IPage Page {get;set;}
    public BasePage(IPage page)
    {
        Page = page;
    }
    public async ValueTask GoUrl()
    {
        await Page.GotoAsync(url);
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на сайт");
    }
    public int FindNumber(string n)
    {
        return Convert.ToInt32(Regex.Match(n, @"\d+").Value);
    }
    private protected async ValueTask WaitingLoad()
    {
        await Page.WaitForTimeoutAsync(800);
        await Page.WaitForLoadStateAsync(LoadState.Load);
        await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
    }
}