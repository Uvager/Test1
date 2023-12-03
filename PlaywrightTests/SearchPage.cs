using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;
public class SearchPage : BasePage
{  
    public SearchPage(IPage page): base(page){}

    public async ValueTask ChoseLapt()
    {
        await WaitingLoad();
        await Page.Locator(Locators.SearchLoc.laptop).ClickAsync();
    }

}