using MSharp;

namespace Admin.Slides
{
    class AddOrUpdatePage : SubPage<Admin.SlidesPage>
    {
        public AddOrUpdatePage()
        {
            Add<Modules.SlideFrm>();
        }
    }
}
