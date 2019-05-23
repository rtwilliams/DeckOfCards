namespace Business.Models.DeckOfCards
{
    public class CardModel
    {
        public string Suite { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string Print()
        {
            return string.Format("{0} {1}", Name, Suite);
        }
    }
}
