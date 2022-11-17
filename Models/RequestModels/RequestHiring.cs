namespace DogSitter.Models.RequestModels
{
    public class RequestHiring
    {
        public RequestClient Client { get; set; }
        public RequestSitter Sitter { get; set; }
        public int NumberOfDogs { get; set; }
        //public string TimePeriod { get; set; }    not sure
    }
}
