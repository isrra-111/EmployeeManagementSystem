using Bogus;
using Bogus.DataSets;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using TCSASystem.Blazor.EmployeeManagement.Models;

namespace TCSASystem.Blazor.EmployeeManagement.Data
{
    public class DataContext:IdentityDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
            protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Employee>().HasData(GetEmployees());
        }


        private List<Employee> GetEmployees()
        { 
        
            var employees = new List<Employee>();

            var facker=new Faker("en");

            Random random = new Random();
            int index = random.Next(1, 100); // Random number between 1 and 99
            string gender = random.Next(0, 2) == 0 ? "men" : "women"; // Randomly select gender

            for (int i=0; i< 50; i++)  
            {
                var employee = new Employee
                {
                    Id=i+1,
                    ImageUrl = $"https://randomuser.me/api/portraits/{gender}/{index}.jpg",
                    Name =facker.Name.FullName(),
                    Salary=GetRandomSalary(),
                    Type=GetRandomEmployeeType(),
                    Position=GetRandomPosition()

                };
                employees.Add(employee);

            }
            return employees;

        }

        private Position GetRandomPosition()
        {
            var random = new Random();
            var positions = Enum.GetValues(typeof(Position));  // Get array of enum values
            return (Position)positions.GetValue(random.Next(positions.Length));  // Use GetValue to get a random value        }
        }
        private EmployeeType GetRandomEmployeeType()
        {
            var random = new Random();
            var types = Enum.GetValues(typeof(EmployeeType));  // Get array of enum values
            return (EmployeeType)types.GetValue(random.Next(types.Length));  // Use GetValue to get a random value        }

        }
            private decimal GetRandomSalary()
        {
            var random = new Random();
           decimal salary = random.Next(30000,100000); //generate a random salary between $30,000 & 10,0000
           
            return salary;
        }


    }
}
