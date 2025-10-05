using backend_dotnet9.Core.Dtos.General;
using backend_dotnet9.Core.Dtos.Message;
using System.Security.Claims;

namespace backend_dotnet9.Core.Interfaces
{
    public interface IMessageService
    {
        Task<GeneralServiceResponseDto> CreateNewMessageAsync(ClaimsPrincipal User, CreateMessageDto createMessageDto);
        Task<IEnumerable<GetMessageDto>> GetMessagesAsync();
        Task<IEnumerable<GetMessageDto>> GetMyMessagesAsync(ClaimsPrincipal User);
    }
}
