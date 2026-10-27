namespace EFSESSION01.models
{
    public class Book
    {
        public int BookId { get; set; }

        public string ISBN { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int NumOfPages { get; set; }
        public int PublicationYear { get; set; }
        public bool IsInStock { get; set; }

    }
}
