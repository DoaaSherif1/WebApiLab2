using TicketSystem.Dto.DTOs.Tickets;

namespace TicketSystem.Dto.DTOs.Departments
{
    public class DepartmentReadDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<TicketDeveloperReadDto> Tickets { get; set; } = new HashSet<TicketDeveloperReadDto>();

    }
}

