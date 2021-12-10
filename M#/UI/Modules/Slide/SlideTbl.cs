using Admin;
using MSharp;

namespace Modules
{
    class SlideTbl : ListModule<Domain.Slide>
    {
        public SlideTbl()
        {
            // TODO: Configure me ...!
            HeaderText("Slides");

            Search(GeneralSearch.AllFields).Label("Find:");
            SearchButton("Search").OnClick(x => x.Reload());

            Column(x => x.Title);
            Column(x => x.Description);
            Column(x => x.LinkUrl);
            Column(x => x.LinkText);
            Column(x => x.DisplayOrder);
            Column(x => x.Image);

            ButtonColumn("Edit")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Edit)
                .OnClick(x => x.Go<Admin.Slides.AddOrUpdatePage>().Send("item", "item.ID"));

            ButtonColumn("Delete")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Remove)
                .OnClick(x => {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Slide")
                .Icon(FA.Plus)
                .OnClick(x => x.Go<Admin.Slides.AddOrUpdatePage>());
        }
    }
}
