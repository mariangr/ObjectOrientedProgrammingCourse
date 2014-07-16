using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._07_StudentsAndLinq
{
    class Group
    {
        public Group(short groupNumber, string departmentName)
        {
            this.DepartmentName = departmentName;
            this.GroupNumber = groupNumber;
        
        }

        public short GroupNumber { set; get; }
        public string DepartmentName { set; get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Group number: " + this.GroupNumber);
            result.AppendLine("Group department: " + this.DepartmentName);
            return result.ToString();
        }
    }
}
