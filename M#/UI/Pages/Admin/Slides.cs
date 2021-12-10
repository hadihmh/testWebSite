using MSharp;

namespace Admin
{
    class SlidesPage : SubPage<AdminPage>
    {
        public SlidesPage()
        {
            Add<Modules.SlideTbl>();
        }
    }
}
