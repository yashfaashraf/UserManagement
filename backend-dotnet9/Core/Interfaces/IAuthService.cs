using backend_dotnet9.Core.Dtos.Auth;
using backend_dotnet9.Core.Dtos.General;
using System.Security.Claims;

namespace backend_dotnet9.Core.Interfaces
{
    public interface IAuthService
    {
        Task<GeneralServiceResponseDto> SeedRolesAsync();
        Task<GeneralServiceResponseDto> RegisterAsync(RegisterDto registerDto);
        Task<LoginServiceResponseDto?> LoginAsync(LoginDto loginDto);
        Task<GeneralServiceResponseDto> UpdateRoleAsync(ClaimsPrincipal User, UpdateRoleDto updateRoleDto);
        Task<LoginServiceResponseDto?> MeAsync(MeDto meDto);
        Task<IEnumerable<UserInfoResultDto>> GetUsersListAsync();
        Task<UserInfoResultDto?> GetUserDetailsByUserNameAsync(string userName);
        Task<IEnumerable<string>> GetUsernamesListAsync();
    }
}
