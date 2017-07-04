using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverOEC.Models
{
    public class PersPageData
    {
        public int ID { get; set; }
        public string Heading { get; set; }
        public XhtmlString BodyText { get; set; }
        public ContentReference Image { get; set; }
        public int StartingBid { get; set; }
        public bool Large { get; set; }
        public string LinkURL { get; set; }
    }
}