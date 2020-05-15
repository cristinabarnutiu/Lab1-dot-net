
namespace Models
{

    public class Book
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
        public double Price { get; set; }
    }
}