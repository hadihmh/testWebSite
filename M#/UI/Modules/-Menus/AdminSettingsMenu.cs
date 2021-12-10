using MSharp;
using Domain;

namespace Modules
{
    public class AdminMenu : MenuModule
    {
        public AdminMenu()
        {
            SubItemBehaviour(MenuSubItemBehaviour.ExpandCollapse);
            WrapInForm(false);
            AjaxRedirect();
            IsViewComponent();
            RootCssClass("sidebar-menu");
            UlCssClass("nav flex-column");
            Using("Olive.Security");

            Item("Contacts")
                .OnClick(x => x.Go<ContactPage>());

            Item("Administrators")
                .OnClick(x => x.Go<Admin.Settings.AdministratorsPage>());

            Item("General Settings")
                .OnClick(x => x.Go<Admin.Settings.GeneralPage>());
            Item("Slides")
               .OnClick(x => x.Go<Admin.SlidesPage>());

        }
    }
}