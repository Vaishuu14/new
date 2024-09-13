using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableAndIComparer_08_08
{
     class Student :IComparable<Student>
    {
        public int SId { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public int Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.SId >  other.SId)
                return 1;
            else if(this.SId < other.SId)
                return -1;
            else return 0;
        }
    }
}
