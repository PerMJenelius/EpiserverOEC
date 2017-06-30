using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OEC_webb.Models
{
    public class BidHistory
    {
        public int ItemId { get; set; }
        public int NumberOfBids { get; set; }
        public string LatestBidder { get; set; }
        public int HighestBid { get; set; }
        public int StartingBid { get; set; }
    }
}