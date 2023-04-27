﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Dto.DTOs.Tickets;

namespace TicketSystem.Dto.Managers.Tickets
{
    public interface ITicketsManager
    {
        List<TicketReadDto> GetAll();
        TicketReadDto? GetById(int id);

        int Add(TicketAddDto doctorDto);
        bool Update(TicketUpdateDto doctorDto);
        void Delete(int id);
    }
}
