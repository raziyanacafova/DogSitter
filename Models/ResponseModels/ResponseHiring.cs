namespace DogSitter.Models.ResponseModels
{
    public class ResponseHiring
    {
        //public int Id { get; set; }       dun'no if it is necessary
        public int SitterId { get; set; }
        public int ClientId { get; set; }
        public int NumberOfDogs { get; set; }
    }
}
