using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using WebApplication1.Entities;

namespace WebApplication1.Taghelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper:TagHelper
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>
        {
             new Employee()
                {
                    Id = 1,
                    CityId = 1,
                    Firstname= "Cavid",
                    Lastname= "Atamaglanov"

                },
                new Employee()
                {
                    Id = 2,
                    CityId = 2,
                    Firstname= "Elvin",
                    Lastname= "Camalzade"

                },
                new Employee()
                {
                    Id = 3,
                    CityId = 3,
                    Firstname= "Ismail",
                    Lastname= "Seyidmemmedli"

                }

        };

    }
}
