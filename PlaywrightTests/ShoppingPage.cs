using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;
public class ShoppingPage : BasePage
{  
    public ShoppingPage(IPage page): base(page){}

    public async ValueTask<int> GetPrice()
    {
        await WaitingLoad();
        return FindNumber(await Page.Locator(Locators.ShoppingLoc.totprice).InnerTextAsync());
    }
    public async ValueTask MakeShip()
    {
        await WaitingLoad();
        await Page.Locator(Locators.ShoppingLoc.agreement).ClickAsync();
        await Page.Locator(Locators.ShoppingLoc.checkout).ClickAsync();
        await WaitingLoad();
        await Page.Locator(Locators.ShoppingLoc.addresscont1).First.ClickAsync();
        await WaitingLoad();
        await Page.Locator(Locators.ShoppingLoc.instore).ClickAsync();
        await Page.Locator(Locators.ShoppingLoc.addresscont2).ClickAsync();
        await WaitingLoad();
        await Page.Locator(Locators.ShoppingLoc.paymentcont).ClickAsync();
        await Page.Locator(Locators.ShoppingLoc.payinfocont).ClickAsync();
        await WaitingLoad();
        Assert.That(await Page.Locator(Locators.ShoppingLoc.totalprice).InnerTextAsync() == "927.00","Цена не совпадает");
        await Page.Locator(Locators.ShoppingLoc.conform).ClickAsync();
        await Page.Locator(Locators.ShoppingLoc.contlast).ClickAsync();

    }
}