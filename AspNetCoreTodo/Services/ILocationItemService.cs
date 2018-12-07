using System;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class ILocationItemService
    {
        Task<LocationItem[]> GetLocationAsync();
    }
}