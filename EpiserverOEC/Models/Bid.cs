using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OEC_webb.Models
{
    public class Bid
    {
        public Bid (int itemID, string bidder, int bidAmount, DateTime bidTime)
        {
            ItemID = itemID;
            BidderName = bidder;
            BidAmount = bidAmount;
            BidTime = bidTime;
        }

        public int ItemID { get; set; }
        public string BidderName { get; set; }
        public int BidAmount { get; set; }
        public DateTime BidTime { get; set; }
    }
}