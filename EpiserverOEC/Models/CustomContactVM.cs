using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OEC_webb.Models
{
    public class CustomContactVM : BlockData
    {
        [Required]
        public string Name { get; set; }

        public string Company { get; set; }

        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        public int CurrentNodeID { get; set; }

        [Required]
        public string Name1 { get; set; }
        [Required]
        public string Name2 { get; set; }
        [Required]
        public string Name3 { get; set; }
        [Required]
        public string Name4 { get; set; }
        [Required]
        public string Name5 { get; set; }
        [Required]
        public string Name6 { get; set; }
        [Required]
        public string Name7 { get; set; }
        [Required]
        public string Name8 { get; set; }
        [Required]
        public string Name9 { get; set; }

        public string Company1 { get; set; }
        public string Company2 { get; set; }
        public string Company3 { get; set; }
        public string Company4 { get; set; }
        public string Company5 { get; set; }
        public string Company6 { get; set; }
        public string Company7 { get; set; }
        public string Company8 { get; set; }
        public string Company9 { get; set; }

        [Required(ErrorMessage = "Company1")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email1 { get; set; }
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email2 { get; set; }
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email3 { get; set; }
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email4 { get; set; }
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email5 { get; set; }
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email6 { get; set; }
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email7 { get; set; }
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email8 { get; set; }
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email9 { get; set; }

        public bool isActive1 { get; set; }
        public bool isActive2 { get; set; }
        public bool isActive3 { get; set; }
        public bool isActive4 { get; set; }
        public bool isActive5 { get; set; }
        public bool isActive6 { get; set; }
        public bool isActive7 { get; set; }
        public bool isActive8 { get; set; }
        public bool isActive9 { get; set; }
    }
}