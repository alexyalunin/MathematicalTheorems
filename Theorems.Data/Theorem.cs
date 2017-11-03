using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theorems.Data
{
    public class Theorem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Proof { get; set; }
        public List<Author> Authors { get; set; }
    }
}
