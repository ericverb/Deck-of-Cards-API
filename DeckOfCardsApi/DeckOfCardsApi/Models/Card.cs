namespace DeckOfCardsApi.Models
{
    public class Card
    {
        public string code { get; set; }
        public string image { get; set; }
        public ImageApi images { get; set; }
        public string value { get; set; }
        public string suit { get; set; }
    }
}
