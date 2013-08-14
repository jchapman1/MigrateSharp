using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject_Schema
{
    public interface ITableColumn
    {
        bool NotNull { get; set; }
        int MaxLength { get; set; }
        int Size { get; set; }
        int Scale { get; set; }
        object ForeignKey { get; set; }
    }
}
