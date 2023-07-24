namespace project1.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Book(int id,string title,string description)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description; 

        }

    }
}
