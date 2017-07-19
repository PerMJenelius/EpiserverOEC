using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverOEC.Models.Pages
{
    [ContentType(DisplayName = "GlobalSettings", GUID = "cb1f7a1c-217b-40fe-9057-c550ace38cd2", Description = "")]
    public class GlobalSettings : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Company Name",
            Description = "The name of the company.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string CompanyName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Address",
            Description = "One or more lines of address info.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string Address { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Organisation Number",
            Description = "The organisation number of the company, if any.",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual string OrgNr { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email",
            Description = "The email address of the company.",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual string Email { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Phone",
            Description = "The phone number of the company.",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual string Phone { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Facebook",
            Description = "The Facebook page of the company.",
            GroupName = SystemTabNames.Content,
            Order = 6)]
        public virtual string Facebook { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Linkedin",
            Description = "The Linkedin page of the company.",
            GroupName = SystemTabNames.Content,
            Order = 7)]
        public virtual string Linkedin { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Spotify",
            Description = "The Spotify page of the company.",
            GroupName = SystemTabNames.Content,
            Order = 8)]
        public virtual string Spotify { get; set; }
    }
}