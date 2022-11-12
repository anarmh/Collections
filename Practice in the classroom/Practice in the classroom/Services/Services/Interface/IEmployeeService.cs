using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interface
{
   public interface IEmployeeService
    {
        public int GetFilteredEmployeeCount(DateTime start,DateTime end,double salary);
    }
}
