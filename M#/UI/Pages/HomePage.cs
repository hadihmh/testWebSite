using MSharp;

class HomePage : RootPage
{
    public HomePage()
    {
        Route("/");
        Layout(Layouts.Default);
        BrowserTitle("MSharp Sample Application");
        Set(PageSettings.MainNav, "MainNav");
    }
}
