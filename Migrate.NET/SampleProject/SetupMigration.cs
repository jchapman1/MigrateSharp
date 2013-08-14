using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigrateNETCore;
using ProjectSchemaTypes;

namespace SampleProject
{
    public class SetupMigration : Migration
    {
        public override void Forward()
        {
            CreateTable("Users", users =>
            {
                users.AddColumn("FirstName", DbType.String, x =>
                {
                    x.NotNull = true;
                    x.MaxLength = 25;
                });

                users.AddColumn("LastName", DbType.String, x =>
                {
                    x.NotNull = true;
                    x.MaxLength = 50;
                });

                users.AddColumn("LastName", DbType.String);
                users.AddColumn("LastModified", DbType.DateTime);
                users.AddColumn("Deleted", DbType.Boolean);
            });

            CreateTable("Roles", roles =>
            {
                roles.AddColumn("RoleId", DbType.Int32);
                roles.AddColumn("Name", DbType.String);
                roles.AddColumn("Description", DbType.String);
            });

            AlterTable(DB.Tables.WM_User, users =>
            {
                users.Name.MaxLength = 12;
                users.Id.NotNull = false;            
            });

            CreateForeignKey(DB.Tables.WM_User.Id, DB.Tables.WM_User.Name);

        }
    }
}
