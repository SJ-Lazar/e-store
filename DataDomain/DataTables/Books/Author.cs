using DataDomain.DataTables.Base;


namespace DataDomain.DataTables.Books
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TitleId { get; set; }
        public Title Title { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
    }
}
