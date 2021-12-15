    using System;
    using System.Collections.Generic;
    using System.Linq;
     
    namespace Coding.Exercise
    {
        public class Employee
        {
            public string Name { get; set; }
            public DateTime HireDate { get; set; }
        }
        
        public class Exercise
        {
             public IEnumerable<Employee> GetRecentlyHiredEmployees(List<Employee> datas){
                return datas.Where(isRecentlyHired);
            }
            
            //Ecrire le prédicat isRecentlyHired
            Func<Employee, bool> isRecentlyHired = e => e.HireDate >= DateTime.Today.AddDays(-30);
        }
    }