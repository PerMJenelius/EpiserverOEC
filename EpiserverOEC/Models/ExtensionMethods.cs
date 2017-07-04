using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverOEC.Models
{
    public static class ExtensionMethods
    {
        public static T GetAttributeOfEnumValue<T>(this object enumVal)
              where T : System.Attribute
        {
            T enumAttribute = null;

            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            if (memInfo == null || !memInfo.Any())
            {
                return null;
            }

            var attributes = memInfo.FirstOrDefault().GetCustomAttributes(typeof(T), false);

            if (attributes != null)
            {
                enumAttribute = attributes.Any() ? (T)attributes.FirstOrDefault() : null;
            }

            return enumAttribute;
        }
    }
}