using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Data
{
    public class Expense
    {
        public int Id { get; set; }
        public List<Tag> Tags { get; set; }

        public Expense()
        {
            Tags = new List<Tag>();
        }
    }
}
