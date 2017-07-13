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
        [Ignore]
        public virtual String Name { get; set; }
        [Ignore]
        public virtual String Name1 { get; set; }
        [Ignore]
        public virtual String Name2 { get; set; }
        [Ignore]
        public virtual String Name3 { get; set; }
        [Ignore]
        public virtual String Name4 { get; set; }
        [Ignore]
        public virtual String Name5 { get; set; }
        [Ignore]
        public virtual String Name6 { get; set; }
        [Ignore]
        public virtual String Name7 { get; set; }
        [Ignore]
        public virtual String Name8 { get; set; }
        [Ignore]
        public virtual String Name9 { get; set; }
        [Ignore]
        public virtual String Company { get; set; }
        [Ignore]
        public virtual String Company1 { get; set; }
        [Ignore]
        public virtual String Company2 { get; set; }
        [Ignore]
        public virtual String Company3 { get; set; }
        [Ignore]
        public virtual String Company4 { get; set; }
        [Ignore]
        public virtual String Company5 { get; set; }
        [Ignore]
        public virtual String Company6 { get; set; }
        [Ignore]
        public virtual String Company7 { get; set; }
        [Ignore]
        public virtual String Company8 { get; set; }
        [Ignore]
        public virtual String Company9 { get; set; }
        [Ignore]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public virtual String Email { get; set; }
        [Ignore]
        public virtual String Email1 { get; set; }
        [Ignore]
        public virtual String Email2 { get; set; }
        [Ignore]
        public virtual String Email3 { get; set; }
        [Ignore]
        public virtual String Email4 { get; set; }
        [Ignore]
        public virtual String Email5 { get; set; }
        [Ignore]
        public virtual String Email6 { get; set; }
        [Ignore]
        public virtual String Email7 { get; set; }
        [Ignore]
        public virtual String Email8 { get; set; }
        [Ignore]
        public virtual String Email9 { get; set; }
        [Ignore]
        public virtual Boolean IsActive1 { get; set; }
        [Ignore]
        public virtual Boolean IsActive2 { get; set; }
        [Ignore]
        public virtual Boolean IsActive3 { get; set; }
        [Ignore]
        public virtual Boolean IsActive4 { get; set; }
        [Ignore]
        public virtual Boolean IsActive5 { get; set; }
        [Ignore]
        public virtual Boolean IsActive6 { get; set; }
        [Ignore]
        public virtual Boolean IsActive7 { get; set; }
        [Ignore]
        public virtual Boolean IsActive8 { get; set; }
        [Ignore]
        public virtual Boolean IsActive9 { get; set; }
        [Ignore]
        public virtual string Message { get; set; }
        [Ignore]
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