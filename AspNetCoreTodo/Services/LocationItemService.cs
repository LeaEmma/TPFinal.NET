using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Data;
using AspNetCoreTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTodo.Services
{
    public class LocationItemService : ILocationItemService
    {
        private readonly ApplicationDbContext _context;
        public LocationItemService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TodoItem[]> GetLocationAsync()
        {
            return await _context.Offices
            .Where(x => x.Location == "Barcelona")
            .ToArrayAsync();
        }
    }
}