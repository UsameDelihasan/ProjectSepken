using Entities.Abstract;
using System;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string BookName { get; set; }
        public int Page { get; set; }
        public int genre { get; set; }
    }
}
