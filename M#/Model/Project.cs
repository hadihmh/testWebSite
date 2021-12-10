using MSharp;

namespace App
{
    public class Project : MSharp.Project
    {
        public Project()
        {
            Name("exampleWebsite").SolutionFile("exampleWebsite.sln");

            Role("Local.Request");
            Role("Anonymous");
            Role("Admin").SkipQueryStringSecurity();

            Layout("Admin default").AjaxRedirect().Default().VirtualPath("~/Views/Layouts/AdminDefault.cshtml");
            Layout("Admin default Modal").AjaxRedirect().Modal().VirtualPath("~/Views/Layouts/AdminDefault.Modal.cshtml");
            Layout("Login").AjaxRedirect().VirtualPath("~/Views/Layouts/Login.cshtml");
            Layout("Blank").AjaxRedirect().VirtualPath("~/Views/Layouts/Blank.cshtml");

            PageSetting("LeftMenu");
            PageSetting("SubMenu");
            PageSetting("TopMenu");
            Layout("Default")
               .AjaxRedirect()
               .VirtualPath("~/Views/Layouts/Default.cshtml");
            PageSetting("MainNav");
            PageSetting("MainFooter");

            AutoTask("Clean old temp uploads").Every(10, TimeUnit.Minute)
                .Run("await new Olive.Mvc.DiskFileRequestService().DeleteTempFiles(olderThan: 1.Hours());");
        }
    }
}
