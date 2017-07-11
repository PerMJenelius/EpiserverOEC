using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "BidSquare", GUID = "8589c4b8-6297-4024-b1ed-7c67f59f08c6", Description = "")]
    public class BidSquare : BlockData
    {
        public BidSquare()
        {
            BidThing = new BidStuff();
        }

        [Ignore]
        public BidStuff BidThing { get; set; }

        [CultureSpecific]
        [Display(
           Name = "NewBidder",
           Description = "NewBidder",
           GroupName = SystemTabNames.Content,
           Order = 21)]
        public virtual string NewBidder { get; set; }

        [CultureSpecific]
        [Display(
           Name = "BidAmount",
           Description = "BidAmount",
           GroupName = SystemTabNames.Content,
           Order = 21)]
        public virtual int BidAmount { get; set; }

        [CultureSpecific]
        [Display(
           Name = "ItemId",
           Description = "ItemId",
           GroupName = SystemTabNames.Content,
           Order = 21)]
        public virtual int ItemId { get; set; }

        [CultureSpecific]
        [Display(
           Name = "LowestBid",
           Description = "LowestBid",
           GroupName = SystemTabNames.Content,
           Order = 21)]
        public virtual int LowestBid { get; set; }

        [CultureSpecific]
        [Display(
           Name = "MaxBid",
           Description = "MaxBid",
           GroupName = SystemTabNames.Content,
           Order = 21)]
        public virtual int MaxBid { get; set; }
    }

    public class BidStuff
    {
        public virtual string NewBidder { get; set; }

        public virtual int BidAmount { get; set; }

        public virtual int ItemId { get; set; }

        public virtual int LowestBid { get; set; }

        public virtual int MaxBid { get; set; }
    }
}