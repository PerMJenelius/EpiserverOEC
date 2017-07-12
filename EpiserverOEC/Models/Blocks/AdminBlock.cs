using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "AdminBlock", GUID = "32b2ce7f-e059-4f4a-890d-6f88661a174b", Description = "")]
    public class AdminBlock : BlockData
    {
        public AdminBlock()
        {
            Inlog = new InlogInfo();
        }

        [Ignore]
        public InlogInfo Inlog { get; set; }

        [Ignore]
        public virtual string Login { get; set; }

        [Ignore]
        public virtual string Password { get; set; }
    }

    public class InlogInfo
    {
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
    }
}