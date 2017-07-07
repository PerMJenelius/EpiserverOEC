using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using OEC_webb.Models;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "SignupBlock", GUID = "4476cf94-601f-4497-b592-16f0488004ba", Description = "A form where the user can sign up for the event.")]
    public class SignupBlock : BlockData
    {
        public SignupBlock()
        {
            Signup = new SignupInfo();
        }

        [Ignore]
        public SignupInfo Signup { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "The first name",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Name { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name1",
            Description = "The 2 name",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual String Name1 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name2",
            Description = "The 3 name",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual String Name2 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name3",
            Description = "The 4 name",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual String Name3 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name4",
            Description = "The 5 name",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual String Name4 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name5",
            Description = "The 6 name",
            GroupName = SystemTabNames.Content,
            Order = 6)]
        public virtual String Name5 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name6",
            Description = "The 7 name",
            GroupName = SystemTabNames.Content,
            Order = 7)]
        public virtual String Name6 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name7",
            Description = "The 8 name",
            GroupName = SystemTabNames.Content,
            Order = 8)]
        public virtual String Name7 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name8",
            Description = "The 9 name",
            GroupName = SystemTabNames.Content,
            Order = 9)]
        public virtual String Name8 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name9",
            Description = "The 10 name",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual String Name9 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Company",
            Description = "The first company",
            GroupName = SystemTabNames.Content,
            Order = 11)]
        public virtual String Company { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Company1",
            Description = "The 2 company",
            GroupName = SystemTabNames.Content,
            Order = 12)]
        public virtual String Company1 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Company2",
            Description = "The 3 company",
            GroupName = SystemTabNames.Content,
            Order = 13)]
        public virtual String Company2 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Company3",
            Description = "The 4 company",
            GroupName = SystemTabNames.Content,
            Order = 14)]
        public virtual String Company3 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Company4",
            Description = "The 5 company",
            GroupName = SystemTabNames.Content,
            Order = 15)]
        public virtual String Company4 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Company5",
            Description = "The 6 company",
            GroupName = SystemTabNames.Content,
            Order = 16)]
        public virtual String Company5 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Company6",
            Description = "The 7 company",
            GroupName = SystemTabNames.Content,
            Order = 17)]
        public virtual String Company6 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Company7",
            Description = "The 8 company",
            GroupName = SystemTabNames.Content,
            Order = 18)]
        public virtual String Company7 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Company8",
            Description = "The 9 company",
            GroupName = SystemTabNames.Content,
            Order = 19)]
        public virtual String Company8 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Company9",
            Description = "The 10 company",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual String Company9 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email",
            Description = "The 1 email address",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual String Email { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email1",
            Description = "The 2 email address",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual String Email1 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email2",
            Description = "The 3 email address",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual String Email2 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email3",
            Description = "The 4 email address",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual String Email3 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email4",
            Description = "The 5 email address",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual String Email4 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email5",
            Description = "The 6 email address",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual String Email5 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email6",
            Description = "The 7 email address",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual String Email6 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email7",
            Description = "The 8 email address",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual String Email7 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email8",
            Description = "The 9 email address",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual String Email8 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email9",
            Description = "The 10 email address",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual String Email9 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "IsActive1",
            Description = "If the 2 field is active or not",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual Boolean IsActive1 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "IsActive2",
            Description = "If the 3 field is active or not",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual Boolean IsActive2 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "IsActive3",
            Description = "If the 4 field is active or not",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual Boolean IsActive3 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "IsActive4",
            Description = "If the 5 field is active or not",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual Boolean IsActive4 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "IsActive5",
            Description = "If the 6 field is active or not",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual Boolean IsActive5 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "IsActive6",
            Description = "If the 7 field is active or not",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual Boolean IsActive6 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "IsActive7",
            Description = "If the 8 field is active or not",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual Boolean IsActive7 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "IsActive8",
            Description = "If the 9 field is active or not",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual Boolean IsActive8 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "IsActive9",
            Description = "If the 10 field is active or not",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual Boolean IsActive9 { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Message",
            Description = "Message",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual string Message { get; set; }

        [CultureSpecific]
        [Display(
            Name = "CurrentNodeID",
            Description = "CurrentNodeID",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual int CurrentNodeID { get; set; }
    }

    public class SignupInfo
    {
        public String Name { get; set; }
        public String Name1 { get; set; }
        public String Name2 { get; set; }
        public String Name3 { get; set; }
        public String Name4 { get; set; }
        public String Name5 { get; set; }
        public String Name6 { get; set; }
        public String Name7 { get; set; }
        public String Name8 { get; set; }
        public String Name9 { get; set; }
        public String Company { get; set; }
        public String Company1 { get; set; }
        public String Company2 { get; set; }
        public String Company3 { get; set; }
        public String Company4 { get; set; }
        public String Company5 { get; set; }
        public String Company6 { get; set; }
        public String Company7 { get; set; }
        public String Company8 { get; set; }
        public String Company9 { get; set; }
        public String Email { get; set; }
        public String Email1 { get; set; }
        public String Email2 { get; set; }
        public String Email3 { get; set; }
        public String Email4 { get; set; }
        public String Email5 { get; set; }
        public String Email6 { get; set; }
        public String Email7 { get; set; }
        public String Email8 { get; set; }
        public String Email9 { get; set; }
        public Boolean IsActive1 { get; set; }
        public Boolean IsActive2 { get; set; }
        public Boolean IsActive3 { get; set; }
        public Boolean IsActive4 { get; set; }
        public Boolean IsActive5 { get; set; }
        public Boolean IsActive6 { get; set; }
        public Boolean IsActive7 { get; set; }
        public Boolean IsActive8 { get; set; }
        public Boolean IsActive9 { get; set; }
        public String Message { get; set; }
    }
}