using MSharp;

namespace Modules
{
    class SlideFrm : FormModule<Domain.Slide>
    {
        public SlideFrm()
        {
            // TODO: Configure me ...!
            HeaderText("Slide details");

            Field(x => x.Title);
            Field(x => x.Description);
            Field(x => x.LinkUrl);
            Field(x => x.LinkText);
            Field(x => x.DisplayOrder);
            Field(x => x.Image);

            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());

            Button("Save").IsDefault().Icon(FA.Check)
            .OnClick(x =>
            {
                x.SaveInDatabase();
                x.GentleMessage("Saved successfully.");
                x.Go<Admin.SlidesPage>();
            });
        }
    }
}
