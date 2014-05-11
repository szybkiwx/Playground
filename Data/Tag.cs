using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Data
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Expense> Expenses { get; set; }

        public Tag()
        {
            Expenses = new List<Expense>();
        }
    }
}
