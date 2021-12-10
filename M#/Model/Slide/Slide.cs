using MSharp;

namespace Domain
{
    class Slide : EntityType
    {
        public Slide()
        {
            String("Title").Mandatory();
            String("Description").Mandatory();
            String("Link Url").Mandatory();
            String("Link Text").Mandatory();
            Int("Display Order").Mandatory();
            OpenImage("Image");
        }
    }
}
