using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace MigrateNETCore
{
    public class CreateTable
    {
        private string tableName = string.Empty;
        private readonly List<Tuple<string, DbType, ColumnOptions>> tableColumns = new List<Tuple<string, DbType, ColumnOptions>>();

        public void AddColumn(string name, DbType type, Action<ColumnOptions> options = null)
        {

            ColumnOptions columnOptions = new ColumnOptions();

            if (options != null)
            {
                options(columnOptions);
            }

            if (tableColumns.All(x => x.Item1 != name))
            {
                tableColumns.Add(Tuple.Create(name, type, columnOptions));
            }
            else
            {
                throw new ArgumentException(string.Format("Column [{0}] has already been added to the table", name));
            }
        }

        public void ApplyName(string name)
        {
            tableName = name;
        }
    }
}
