using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerStoreService.Data
{
  public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int AuthorId { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}