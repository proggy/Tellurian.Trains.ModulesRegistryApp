﻿using ModulesRegistry.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ModulesRegistry.Services
{
    public interface IModuleService : IDataService<Module>
    {
        Task<Module?> FindByIdAsync(ClaimsPrincipal? principal, int id, int owningPersionId);
        Task<IEnumerable<Module>> GetAllAsync(ClaimsPrincipal? principal);
        Task<IEnumerable<Module>> GetForOwningPerson(ClaimsPrincipal? principal, int personId);
        Task<(int Count, string Message, Module? Entity)> SaveAsync(ClaimsPrincipal? principal, Module entity, int owningPersonId);
    }
}
