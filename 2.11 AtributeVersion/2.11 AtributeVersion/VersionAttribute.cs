using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._11_AtributeVersion
{
    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Enum|AttributeTargets.Struct|AttributeTargets.Interface|AttributeTargets.Method)]
    class VersionAttribute : Attribute
    {
        private int minor;
        private int major;

        public VersionAttribute(int major, int minor)
        {
            this.minor = minor;
            this.major = major;
        }

        public int Major
        { 
            get {return this.major;}
            set {this.major = value;}
        }

        public int Minor
        {
            get { return this.minor; }
            set { this.minor = value; }
        }
    }
}
