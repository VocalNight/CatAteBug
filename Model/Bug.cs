using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAteBug.Model
{
    internal class Bug
    {
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateOnly AddedDate { get; set; }
        public DateOnly ResolvedDate { get; set; }

    }
}
