using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleProject_Schema;

namespace MigrateNETCore
{
    public static class Schema
    {
        public static CreateTable CreateTable(string name, Action<CreateTable> init = null)
        {
            CreateTable table = new CreateTable();
            
            if (init != null)
            {
                init(table);
            }

            return table;
        }

        public static TTable AlterTable<TTable>(TTable table, Action<TTable> action) where TTable : IDatabaseTable
        {
            action(table);
            return table;
        }
    }
}
