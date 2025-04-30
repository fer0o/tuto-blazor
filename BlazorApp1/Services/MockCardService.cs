using BlazorApp1.Models;

namespace BlazorApp1.Services{
    public static class MockCardService
    {
        public static List<CardItem> GetMockCards()
        {
            return new List<CardItem>
            {
                new CardItem { Title = "Card 1 ", Description = "Ejemplo uno "},
                new CardItem { Title = "Card 2 ", Description = "Ejemplo dos "},
                new CardItem { Title = "Card 3 ", Description = "Ejemplo tres "},
                new CardItem { Title = "Card 4 ", Description = "Ejemplo cuatro "},
                new CardItem { Title = "Card 5 ", Description = "Ejemplo cinco "},
                new CardItem { Title = "Card 6 ", Description = "Ejemplo seis "},
            };
        }
    }
}