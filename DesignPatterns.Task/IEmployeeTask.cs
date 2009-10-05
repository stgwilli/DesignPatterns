using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Domain;

namespace DesignPatterns.Task
{
    public interface IEmployeeTask
    {
        IList<IEmployee> GetAllEmployees();
    }

}
