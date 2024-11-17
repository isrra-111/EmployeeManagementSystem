using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TCSASystem.Blazor.EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Salary { get; set; }

        public EmployeeType Type { get; set; }

        public Position Position { get; set; }

    }

    public enum EmployeeType
    {
        [Display(Name = "FreeLancer")]
        FreeLancer,

        [Display(Name = "Casual")]
        Casual,

        [Display(Name = "Part Time")]
        PartTime,

        [Display(Name = "Full Time")]
        FullTime,

        [Display(Name = "Intern")]
        Intern,



    }

    public enum Position
 {

        [Display(Name ="CEO")]
        CEO,

        [Display(Name ="CFO")]
        CFO,

        [Display(Name ="CTO")]
        CTO,

        [Display(Name ="Accountant")]
        Accountant,

        [Display(Name = "Markting Manager")]
        MarktingManager,

        [Display(Name ="HR Manager")]
        HRManager,

        [Display(Name ="Backend Developer")]
        BackendDeveloper,

        [Display(Name ="Frontend Developer")]
        FrontendDeveloper,

        [Display(Name = "Designer")]
        Designer,
        
        [Display(Name = "Project Manager")]
        ProjectManager,

        [Display(Name = "Tester")]
        Tester,



        
    }
}

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum enumValue)
    {
        return enumValue.GetType()
          .GetMember(enumValue.ToString())
          .First()
          .GetCustomAttribute<DisplayAttribute>()
          ?.GetName();
    }
}
