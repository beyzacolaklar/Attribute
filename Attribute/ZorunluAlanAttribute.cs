using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace OgrenciApp.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ZorunluAlanAttribute : System.Attribute
    {
        public string HataMesaji { get; }

        public ZorunluAlanAttribute(string hataMesaji)
        {
            HataMesaji = hataMesaji;
        }
    }
}


