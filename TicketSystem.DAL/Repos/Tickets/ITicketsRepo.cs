﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Data.Models;

namespace TicketSystem.DAL.Repos.Tickets
{
    public interface ITicketsRepo
    {
        IEnumerable<Ticket> GetAll();
        Ticket? GetById(int id);
        void Add(Ticket entity);
        void Update(Ticket entity);
        void Delete(Ticket entity);

        int SaveChanges();
    }
}
