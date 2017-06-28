using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpiserverOEC.Models.Pages
{
    public abstract class SitePageData : EPiServer.Core.PageData
    {
        [Display(GroupName = "SEO", Order = 200, Name = "Search keywords")]
        public virtual String MetaKeywords { get; set; }
    }
}