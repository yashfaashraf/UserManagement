namespace backend_dotnet9.Core.Dtos.Auth
{
    public class LoginServiceResponseDto
    {
        public string NewToken { get; set; }
        public UserInfoResultDto UserInfo { get; set; }
    }
}
