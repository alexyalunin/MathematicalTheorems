using System.Collections.Generic;

namespace Theorems.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Theorem> Theorems { get; set; }
    }
}