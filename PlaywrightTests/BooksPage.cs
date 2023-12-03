using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;
public class BooksPage : BasePage
{  
    public BooksPage(IPage page): base(page){}

    public async ValueTask<int> Countbooks()
    {
        await WaitingLoad();
        return await Page.Locator(Locators.BooksPageLoc.bookslist).CountAsync();    
    }

}