using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;
public class ComputersPage : BasePage
{  
    public ComputersPage(IPage page): base(page){}

    public async ValueTask GoToDesktops()
    {
        await WaitingLoad();
        await Page.Locator(Locators.ComputersPageLoc.desktop).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на вкладку Desktops совершен");
    }
    public async ValueTask AddSimple()
    {
        await WaitingLoad();
        await Page.Locator(Locators.ComputersPageLoc.simplepc).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на страницу товара совершен");
        await Page.Locator(Locators.ComputersPageLoc.processorslow).ClickAsync();
        await Page.Locator(Locators.ComputersPageLoc.ram4).ClickAsync();
        await Page.Locator(Locators.ComputersPageLoc.hdd400).ClickAsync();
        await Page.Locator(Locators.ComputersPageLoc.softwareimage).ClickAsync();
        await Page.Locator(Locators.ComputersPageLoc.softwareoffice).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Параметры выбранны");
    }
    public async ValueTask<int> GetPrice()
    {
        await WaitingLoad();
        return FindNumber(await Page.Locator(Locators.ComputersPageLoc.price).InnerTextAsync());
    }
    public async ValueTask AddToCart()
    {
      await WaitingLoad();
      await Page.Locator(Locators.ComputersPageLoc.addtocart).ClickAsync();  
    }
}