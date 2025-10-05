namespace backend_dotnet9.Core.Entities
{
    public class Message : BaseEntity<long>
    {
        public string SenderUserName { get; set; }
        public string ReceiverUserName { get; set; }
        public string Text { get; set; }
    }
}
