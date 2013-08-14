using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrateNETCore
{
    public class ColumnOptions
    {
        public bool NotNull { get; set; }
        public int MaxLength { get; set; }
        public int Size { get; set; }
        public int Scale { get; set; }
        public object ForeignKey { get; set; }
    }
}
