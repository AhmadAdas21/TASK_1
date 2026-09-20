using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TASK_1
{
    public class student
    {
        public int id{ get; }
        public string name{ get; }
        public float grade{ get; }
        public int age{ get; }


        public student(int idd, string namee, int agee, float gradee)
        {
         

            id = idd;
            name = namee;
            age = agee;
            grade = gradee;
        }

    }
}
