namespace DogSitter.Models.RequestModels
{
    public class RequestFeedback
    {
        public RequestClient Client { get; set; }
        public RequestSitter Sitter { get; set; }
        public string Feedback { get; set; }
    }
}
