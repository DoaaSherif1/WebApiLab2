using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Dto.DTOs.Departments;
using TicketSystem.Dto.DTOs.Tickets;
using TicketSystem.DAL.Data.Models;
using TicketSystem.DAL.Repos.Departments;
using TicketSystem.DAL.Repos.Tickets;

namespace TicketSystem.Dto.Managers.Departments
{
    public class DepartmentsManager : IDepartmentsManager
    {
        private readonly IDepartmentsRepo _departmentsRepo;

        public DepartmentsManager(IDepartmentsRepo DepartmentsRepo)
        {
            _departmentsRepo = DepartmentsRepo;
        }

        public DepartmentReadDetailsDto? GetDetails(int id)
        {
            Department? department = _departmentsRepo.GetWithTicketsAndDevelopers(id);
            if (department is null)
            {
                return null;
            }

            return new DepartmentReadDetailsDto
            {
                Id = department.Id,
                Name = department.Name,


                Tickets = department.Tickets
                    .Select(p => new TicketDeveloperReadDto
                    {
                        Id = p.Id,
                        Description = p.Description,
                        Title = p.Title,
                        DevelopersCount = p.Developers.Count
                    }).ToList()
            };
        }
    }
}
