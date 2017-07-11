using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace EpiserverOEC.Models.Pages
{
    [ContentType(DisplayName = "AuctionItemPage", GUID = "c47ab934-48e4-44e1-991c-0c0881fc7940", Description = "")]
    public class AuctionItemPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Add a heading.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Body Text",
            Description = "Add some text to describe the page.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString BodyText { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Image",
            Description = "Add an image of the item.",
            GroupName = UIHint.Image,
            Order = 3)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Starting Bid",
            Description = "Add a starting bid.",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual int StartingBid { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Large Size",
            Description = "Set to true if the item is to be displayed as Large on the Auction Main Page.",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual bool Large { get; set; }

        public virtual string NewBidder { get; set; }

        public virtual int BidAmount { get; set; }

        public virtual int ItemId { get; set; }

        public virtual int LowestBid { get; set; }

        [Display(
            Name = "Main content",
            Description = "Using the editor you can insert text, images or tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }
    }
}