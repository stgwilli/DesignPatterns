using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Domain;

namespace DesignPatterns.Task
{
    public class EmployeeTask : IEmployeeTask
    {



        public IList<IEmployee> GetAllEmployees()
        {
            IList<IEmployee> results = new List<IEmployee>();


            return results;
        }
    }
}
