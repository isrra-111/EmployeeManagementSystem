using Microsoft.EntityFrameworkCore;
using TCSASystem.Blazor.EmployeeManagement.Data;
using TCSASystem.Blazor.EmployeeManagement.Models.DTOs;
using TCSASystem.Blazor.EmployeeManagement.Models.Responses;
using TCSASystem.Blazor.EmployeeManagement.Models;

namespace TCSASystem.Blazor.EmployeeManagement.Services;

public interface IEmployeeService
{
    Task<GetEmployeesResponse> GetEmployees();
    Task<BaseResponse> AddEmployee(AddEmployeeForm addEmployeeForm);

    Task<GetEmployeeResponse> GetEmployee(int id);
    Task <BaseResponse>DeleteEmployee(int id);

    Task<BaseResponse>EditEmployee(Employee employee);

}
public class EmployeeService : IEmployeeService

{
    private readonly IDbContextFactory<DataContext> _factory;


    public EmployeeService(IDbContextFactory<DataContext> factory)
        {
        _factory = factory;
        }

    public async Task<BaseResponse> AddEmployee(AddEmployeeForm addEmployeeForm)
    {
        var response = new BaseResponse();
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                context.Add(new Employee
                {
                    Name = addEmployeeForm.Name,
                    Position = addEmployeeForm.Position,
                    Salary = addEmployeeForm.Salary,
                    Type = addEmployeeForm.Type,
                    ImageUrl = addEmployeeForm.ImageUrl
                });

                var result = await context.SaveChangesAsync();

                if (result == 1)
                {
                    response.StatusCode = 200;
                    response.Message = "Employee added successfully";
                }
                else
                {
                    response.StatusCode = 400;
                    response.Message = "Error occurred while adding the employee.";
                }
            }
        }
        catch (Exception ex)
        {
            response.StatusCode = 500;
            response.Message = "Error adding employee: " + ex.Message;
        }

        return response;

    }

    public async Task<BaseResponse> DeleteEmployee(int id)
    {
        var response = new BaseResponse();
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                context.Remove(id);

                var result = await context.SaveChangesAsync();

                if (result == 1)
                {
                    response.StatusCode = 200;
                    response.Message = "Employee deleted successfully";
                }
                else
                {
                    response.StatusCode = 400;
                    response.Message = "Error occurred while deleted the employee.";
                }
            }
        }
        catch (Exception ex)
        {
            response.StatusCode = 500;
            response.Message = "Error deleted employee: " + ex.Message;
        }

        return response;
    }

    public async Task<BaseResponse> EditEmployee(Employee employee)
    {
        var response = new BaseResponse();
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                context.Update(employee);

                var result = await context.SaveChangesAsync();

                if (result == 1)
                {
                    response.StatusCode = 200;
                    response.Message = "Employee updated successfully";
                }
                else
                {
                    response.StatusCode = 400;
                    response.Message = "Error occurred while updated the employee.";
                }
            }
        }
        catch (Exception ex)
        {
            response.StatusCode = 500;
            response.Message = "Error updated employee: " + ex.Message;
        }

        return response;
    }

    public async Task<GetEmployeeResponse> GetEmployee(int id)
    {
       var response=new GetEmployeeResponse();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var employee = await context.Employees.FirstOrDefaultAsync(x=>x.Id==id);
                response.Employee = employee;
                response.StatusCode = 200;
                response.Message = "Success";
            }

        }
        catch (Exception ex)
        {
            response.StatusCode = 500;
            response.Message = "Error retreving employees:" + ex.Message;
            response.Employee = null;
        }
        return response;

    }

    public async Task<GetEmployeesResponse> GetEmployees()
    {
       var response=new GetEmployeesResponse();
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var employees = await context.Employees.ToListAsync();
                response.Employees=employees;
                response.StatusCode = 200;
                response.Message = "Success";
            }

        }
        catch (Exception ex)
        {
            response.StatusCode = 500;
            response.Message = "Error retreving employees:"+ex.Message;
            response.Employees = null;
        }
        return response;
    }

   
}
