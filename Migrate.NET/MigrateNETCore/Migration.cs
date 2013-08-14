using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleProject_Schema;

namespace MigrateNETCore
{
    public abstract class Migration
    {

        public abstract void Forward();

        public virtual void Rollback()
        {
            return;
        }

        public CreateTable CreateTable(string name, Action<CreateTable> initializer)
        {
            return Schema.CreateTable(name, initializer);
        }

        public TTable AlterTable<TTable>(TTable table, Action<TTable> action) where TTable : IDatabaseTable
        {
            return Schema.AlterTable(table, action);
        }

        public void CreateForeignKey<TFromColumn, TToColumn>(TFromColumn from, TToColumn to) 
            where TFromColumn : ITableColumn
            where TToColumn : ITableColumn
        {
            return;
        }

    }
}
