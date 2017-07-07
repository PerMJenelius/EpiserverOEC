using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "BidForm", GUID = "a452e4fc-2613-4b6c-9b79-c6bc00b15d5c", Description = "")]
    public class BidForm : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Bidder",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string NewBidder { get; set; }

        [CultureSpecific]
        [Display(
            Name = "BidAmount",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual int BidAmount { get; set; }
    }
}