using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

public class Tests : BaseTest
{
    [Test]
    public async Task Case_1()
    {
        MainPage newpage = new MainPage(Page); 
        NUnit.Framework.TestContext.Progress.WriteLine("Начало Case 1");
        await newpage.GoToBooks();
        await Expect(Page.Locator(Locators.BooksPageLoc.bookstitle)).ToBeVisibleAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на вкладку Books совершен");
        await newpage.GoToComputers();
        await Expect(Page.Locator(Locators.ComputersPageLoc.computerstitle)).ToBeVisibleAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на вкладку Computers совершен");
        await newpage.GoToElectronics();
        await Expect(Page.Locator(Locators.ElectronicsPageLoc.electronicstitle)).ToBeVisibleAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на вкладку Electronics совершен");
        await newpage.GoToShoes();
        await Expect(Page.Locator(Locators.ApparelPageLoc.appareltitle)).ToBeVisibleAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на вкладку Apparel & Shoes совершен");
        await newpage.GoToDigital();
        await Expect(Page.Locator(Locators.DigitalPageLoc.digitalltitle)).ToBeVisibleAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на вкладку Digital downloads совершен");
        await newpage.GoToJewelry();
        await Expect(Page.Locator(Locators.JewelryPageLoc.jewelrytitle)).ToBeVisibleAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на вкладку Jewelry совершен");
        await newpage.GoToGiftcards();
        await Expect(Page.Locator(Locators.GiftPageLoc.giftltitle)).ToBeVisibleAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на вкладку Gift Cards совершен");
        await newpage.GoToMainPage();
        await Expect(Page.Locator(Locators.MainPageLoc.maintitle)).ToBeVisibleAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Возвращение на главную страницу совершено");
        NUnit.Framework.TestContext.Progress.WriteLine("Окончание Case 1");
    }

    [Test]
    public async Task Case_2()
    {
        MainPage newpage = new MainPage(Page);
        Assert.That(await newpage.CountProductsMain() == 6, "Колличество не совпадает");
    }

    [Test]
    public async Task Case_3()
    {
        MainPage newpage = new MainPage(Page);
        SearchPage searchpage = new SearchPage(Page);
        NUnit.Framework.TestContext.Progress.WriteLine("Начало Case 3");
        await newpage.MakeSearch("14.1-inch Laptop");
        await searchpage.ChoseLapt();
        await Expect(Page.Locator(Locators.SearchLoc.lappage)).ToBeVisibleAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Окончание Case 3");
    }

    [Test]
    public async Task Case_4()
    {
        MainPage newpage = new MainPage(Page);
        LoginPage loginpage = new LoginPage(Page);
        NUnit.Framework.TestContext.Progress.WriteLine("Начало Case 4");
        await loginpage.Auth("eg.dmitrieff2011@yandex.ru","123456");
        await Expect(Page.Locator(Locators.MainPageLoc.authpass)).ToBeVisibleAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Аунтефикация пройденп");
        NUnit.Framework.TestContext.Progress.WriteLine("Окончание Case 4");
    }
    [Test]
    public async Task Case_5()
    {
        MainPage newpage = new MainPage(Page); 
        BooksPage bookpage = new BooksPage(Page);
        NUnit.Framework.TestContext.Progress.WriteLine("Начало Case 5");
        await newpage.GoToBooks();
        await Expect(Page.Locator(Locators.BooksPageLoc.bookstitle)).ToBeVisibleAsync();
        NUnit.Framework.TestContext.Progress.WriteLine("Переход на вкладку Books совершен");
        Assert.That(await bookpage.Countbooks() == 6, "Колличество не совпадает");
        NUnit.Framework.TestContext.Progress.WriteLine("Окончание Case 5");
    }
    [Test]
    public async Task Case_6()
    {
        MainPage newpage = new MainPage(Page); 
        LoginPage loginpage = new LoginPage(Page);
        ComputersPage comppage = new ComputersPage(Page);
        NUnit.Framework.TestContext.Progress.WriteLine("Начало Case 6");
        await loginpage.Auth("eg.dmitrieff2011@yandex.ru","123456");
        await Expect(Page.Locator(Locators.MainPageLoc.authpass)).ToBeVisibleAsync();
        await newpage.GoToComputers();
        await comppage.GoToDesktops();
        await comppage.AddSimple();
        Assert.That(await comppage.GetPrice() == 800,"Цена не совпадает");
        NUnit.Framework.TestContext.Progress.WriteLine("Проверка цены проведена");
        await comppage.AddToCart();
        NUnit.Framework.TestContext.Progress.WriteLine($"Кол-во товаров в корзине = {await newpage.GetCardNumber()}");
        Assert.That(await newpage.GetCardNumber() == 1,"Колличество товаров в корзмне не совпадает");       
    }
    [Test]
    public async Task Case_7()
    {
        MainPage newpage = new MainPage(Page); 
        LoginPage loginpage = new LoginPage(Page);
        ComputersPage comppage = new ComputersPage(Page);
        ShoppingPage shoppingpage = new ShoppingPage(Page);
        NUnit.Framework.TestContext.Progress.WriteLine("Начало Case 7");
        await loginpage.Auth("eg.dmitrieff2011@yandex.ru","123456");
        await Expect(Page.Locator(Locators.MainPageLoc.authpass)).ToBeVisibleAsync();
        await newpage.GoToComputers();
        await comppage.GoToDesktops();
        await comppage.AddSimple();
        Assert.That(await comppage.GetPrice() == 800,"Цена не совпадает");
        NUnit.Framework.TestContext.Progress.WriteLine("Проверка цены проведена");
        await comppage.AddToCart();
        await newpage.GoToShippingCart();
        Assert.That(await shoppingpage.GetPrice()== 920,"Цена не совпадает");
        await shoppingpage.MakeShip();
        NUnit.Framework.TestContext.Progress.WriteLine("Окончание Case_7");
    }
}