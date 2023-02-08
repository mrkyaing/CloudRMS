using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.I
{
    internal class TeamLead : ILead,IProgrammer
    {
        public void AssignTask()=> Console.WriteLine("Assign the task");

        public void CreateSubTask()=> Console.WriteLine("create a subtask");

        public void WorkOnTask()=> Console.WriteLine("code-implementation Of crud process for order function");

    }
}
