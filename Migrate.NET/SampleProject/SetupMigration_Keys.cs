using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigrateNETCore;
using ProjectSchemaTypes;

namespace SampleProject
{
    public class SetupMigration_Keys : Migration
    {
        public override void Forward()
        {
            CreateForeignKey(from: DB.Tables.WM_User.Name, to: DB.Tables.WM_ApplicationSettings.UserId);
        }

        public override void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
