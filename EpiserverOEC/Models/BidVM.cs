using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OEC_webb.Models
{
    public class BidVM
    {
        [Required]
        public string NewBidder { get; set; }

        [Required]
        public int BidAmount { get; set; }

        public int ItemId { get; set; }
        public int LowestBid { get; set; }
    }
}