using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;
public class MainPage : BasePage
{  
    public MainPage(IPage page): base(page){}

    public async ValueTask GoToBooks()
    {
        await WaitingLoad();
        await Page.Locator(Locators.bookspage).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на Books");
    }
    public async ValueTask GoToComputers()
    {
        await WaitingLoad();
        await Page.Locator(Locators.computerspage).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на Computers");
    }
    public async ValueTask GoToElectronics()
    {
        await WaitingLoad();
        await Page.Locator(Locators.electronicspage).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на Electronics");
    }
    public async ValueTask GoToShoes()
    {
        await WaitingLoad();
        await Page.Locator(Locators.apparelpage).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на Shoes");
    }
    public async ValueTask GoToDigital()
    {
        await WaitingLoad();
        await Page.Locator(Locators.digitaldownloadpage).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на Digital");
    }
    public async ValueTask GoToJewelry()
    {
        await WaitingLoad();
        await Page.Locator(Locators.jewelrypage).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на Jewelry");
    }
    public async ValueTask GoToGiftcards()
    {
        await WaitingLoad();
        await Page.Locator(Locators.giftcardspage).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на Gift");
    }  
    public async ValueTask GoToMainPage()
    {
        await WaitingLoad();
        await Page.Locator(Locators.mainlogopage).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на Главную страницу");
    }
    public async ValueTask GoToShippingCart()
    {
        await WaitingLoad();
        await Page.Locator(Locators.shippingcart).ClickAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход в корзину");
    }
    public async ValueTask MakeSearch(string search)
    {
        await WaitingLoad();
        await Page.Locator(Locators.searchbox).FillAsync(search);
        await Page.Locator(Locators.searchbutton).ClickAsync();    
        NUnit.Framework.TestContext.Progress.WriteLine($"Запрос {search} совершен");
    }
    public async ValueTask<int> CountProductsMain()
    {
        await WaitingLoad();
        return await Page.Locator(Locators.MainPageLoc.featuredthing).CountAsync();    
    }
    public async ValueTask<int> GetCardNumber()
    {
        await WaitingLoad();
        return FindNumber(await Page.Locator(Locators.MainPageLoc.cartnumber).InnerTextAsync());
    }
    
    
}