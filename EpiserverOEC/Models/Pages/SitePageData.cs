using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpiserverOEC.Models.Pages
{
    public abstract class SitePageData : EPiServer.Core.PageData
    {
        [Display(
            GroupName = "SEO",
            Order = 200,
            Name = "Search keywords")]
        public virtual String MetaKeywords { get; set; }

        [Display(
            Name = "Display Footer",
            Description = "Whether this site should have a standard footer or nay.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [CultureSpecific]
        public virtual bool DisplayFooter { get; set; }
    }
}