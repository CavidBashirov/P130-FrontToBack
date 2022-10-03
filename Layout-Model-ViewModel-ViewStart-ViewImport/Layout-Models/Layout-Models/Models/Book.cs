using System;

namespace Layout_Models.Models
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
