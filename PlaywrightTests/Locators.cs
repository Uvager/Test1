namespace PlaywrightTests;
public static class Locators
{
    public const string bookspage = "//*[@class='top-menu']//a[starts-with(@href, '/books')]";
    public const string computerspage = "//*[@class='top-menu']//a[starts-with(@href, '/computers')]";
    public const string electronicspage = "//*[@class='top-menu']//a[starts-with(@href, '/electronics')]";
    public const string apparelpage = "//*[@class='top-menu']//a[starts-with(@href, '/apparel-shoes')]";
    public const string digitaldownloadpage = "//*[@class='top-menu']//a[starts-with(@href, '/digital-downloads')]";
    public const string jewelrypage = "//*[@class='top-menu']//a[starts-with(@href, '/jewelry')]";
    public const string giftcardspage = "//*[@class='top-menu']//a[starts-with(@href, '/gift-cards')]";
    public const string mainlogopage = "img[alt='Tricentis Demo Web Shop']";
    public const string searchbox = "//*[@class='search-box-text ui-autocomplete-input']";
    public const string searchbutton = "//*[@class='button-1 search-box-button']";
    public const string shippingcart = "//a[@href='/cart']//span[@class='cart-label']";
    public static class LoginPageLoc
    {
        public const string emailloc = "//input[@class='email']";
        public const string passwordloc = "//input[@class='password']";
        public const string loginbutton = "//input[@class='button-1 login-button']";
    }
    public static class MainPageLoc
    {
    public const string maintitle = "//*[@class='topic-html-content-header']";
    public const string featuredthing = "//div[@class = 'item-box']";
    public const string loginpage = "//a[@href='/login']";
    public const string authpass = "//a[text()='eg.dmitrieff2011@yandex.ru']";
    public const string cartnumber = "//span[@class='cart-qty']";

    } 
    public static class BooksPageLoc
    {
        public const string bookstitle = "//*[@class='page-title']//h1[text()='Books']";
        public const string bookslist = "//div[@class = 'item-box']";

    }
    public static class ComputersPageLoc
    {
        public const string computerstitle = "//*[@class='page-title']//h1[text()='Computers']";
        public const string desktop = "//h2//a[@title='Show products in category Desktops']";
        public const string simplepc = "//div[@class='details']//a[@href='/simple-computer']";
        public const string processorslow = "//input[@id='product_attribute_75_5_31_96']";
        public const string ram4 = "//input[@id='product_attribute_75_6_32_101']";
        public const string hdd400 = "//input[@id='product_attribute_75_3_33_103']";
        public const string softwareimage = "//input[@id='product_attribute_75_8_35_107']";
        public const string softwareoffice = "//input[@id='product_attribute_75_8_35_108']";
        public const string price = "//span[@itemprop='price']";
        public const string addtocart = "//input[@id='add-to-cart-button-75']";
    }
    public static class ElectronicsPageLoc
    {
        public const string electronicstitle = "//*[@class='page-title']//h1[text()='Electronics']";
    }
    public static class ApparelPageLoc
    {
        public const string appareltitle = "//*[@class='page-title']//h1[text()='Apparel & Shoes']";
    }     
    public static class DigitalPageLoc
    {
        public const string digitalltitle = "//*[@class='page-title']//h1[text()='Digital downloads']";
    } 
    public static class JewelryPageLoc
    {
        public const string jewelrytitle = "//*[@class='page-title']//h1[text()='Jewelry']";
    } 
    public static class GiftPageLoc
    {
        public const string giftltitle = "//*[@class='page-title']//h1[text()='Gift Cards']";
    }
    public static class SearchLoc
    {
        public const string laptop = "//*[@class='product-title']//a[starts-with(@href, '/141-inch')]";
        public const string lappage = "//li/strong[text()='14.1-inch Laptop']";
    }    
    public static class ShoppingLoc
    {
        public const string totprice = "//span[@class='product-price order-total']";
        public const string agreement = "//input[@id='termsofservice']";
        public const string choseadress = "//select[@name='billing_address_id']";
        public const string checkout = "//button[@id='checkout']";
        public const string newadress = "//option[@value='']";
        public const string addresscont2 = "//input[@onclick='Shipping.save()']";
        public const string addresscont1 = "//input[@onclick='Billing.save()']";
        public const string instore = "//input[@id='PickUpInStore']";
        public const string paymentcont = "//input[@class='button-1 payment-method-next-step-button']";
        public const string payinfocont = "//input[@class='button-1 payment-info-next-step-button']";
        public const string country1= "//select[@id='BillingNewAddress_CountryId']";
        public const string country2= "//*[@id='shipping-address-select']/option[2]";
        public const string city = "//input[@id='BillingNewAddress_City']";
        public const string adresss1 = "//input[@id='BillingNewAddress_Address1']";
        public const string zip = "//input[@id='BillingNewAddress_ZipPostalCode']";
        public const string phone = "//input[@id='BillingNewAddress_PhoneNumber']";
        public const string totalprice = "//span[@class='product-price order-total']";
        public const string conform = "//input[@class='button-1 confirm-order-next-step-button']";
        public const string sucsord = "//h1[text()='Thank you']";
        public const string contlast = "//input[@class='button-2 order-completed-continue-button']";
    }
}
