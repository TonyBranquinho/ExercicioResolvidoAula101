using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvidoAula101.Entities
{
    internal class Department
    {
        public string DepName { get; set; }

        public Department()
        {
        }

        public Department(string depName)
        {
            DepName = depName;
        }
    }
}


