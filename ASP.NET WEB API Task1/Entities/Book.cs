namespace ASP.NET_WEB_API_Task1.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public object deletedBook { get; internal set; }
    }
}