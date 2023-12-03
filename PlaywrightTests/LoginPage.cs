using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;
public class LoginPage : BasePage
{  
    public LoginPage(IPage page): base(page){}

    public async ValueTask Auth(string email, string password)
    {
        await WaitingLoad();
        await Page.Locator(Locators.MainPageLoc.loginpage).ClickAsync();
        await Page.Locator(Locators.LoginPageLoc.emailloc).FillAsync(email);
        await Page.Locator(Locators.LoginPageLoc.passwordloc).FillAsync(password);
        await Page.Locator(Locators.LoginPageLoc.loginbutton).ClickAsync();
    }

}