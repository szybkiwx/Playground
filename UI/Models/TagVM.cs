using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playground.UI.Models
{
    public class TagVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExpensesCount { get; set; }
    }
}