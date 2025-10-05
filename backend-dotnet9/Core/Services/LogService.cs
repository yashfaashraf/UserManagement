using backend_dotnet9.Core.DbContext;
using backend_dotnet9.Core.Dtos.Log;
using backend_dotnet9.Core.Entities;
using backend_dotnet9.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace backend_dotnet9.Core.Services
{
    public class LogService(ApplicationDbContext dbContext) : ILogService
    {
        private readonly ApplicationDbContext _context= dbContext;

        public async Task SaveNewLog(string UserName, string Description)
        {
            var log = new Log
            {
                UserName = UserName,
                Description = Description
            };
            await _context.Logs.AddAsync(log);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<GetLogDto>> GetLogsAsync()
        {
             var logs = await _context.Logs
             .Select(q => new GetLogDto
             {
                 CreatedAt = q.CreatedAt,
                 Description = q.Description,
                 UserName = q.UserName,
             })
             .OrderByDescending(q => q.CreatedAt)
             .ToListAsync();
            return logs;
        }

        public async Task<IEnumerable<GetLogDto>> GetMyLogsAsync(ClaimsPrincipal User)
        {
            var logs = await _context.Logs
           .Where(q => q.UserName == User.Identity.Name)
           .Select(q => new GetLogDto
           {
              CreatedAt = q.CreatedAt,
              Description = q.Description,
              UserName = q.UserName,
           })
          .OrderByDescending(q => q.CreatedAt)
          .ToListAsync();
            return logs;
        }

      
    }
}
