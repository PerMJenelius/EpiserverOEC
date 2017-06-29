using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverOEC.Models.Blocks
{
    [ContentType(DisplayName = "SignupLink", GUID = "3e39ddb3-270f-478f-8b36-a8ec99bb5be1", Description = "A link to the Signup page")]
    public class SignupLink : BlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */
    }
}