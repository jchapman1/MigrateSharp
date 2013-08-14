using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SampleProject_Schema;

namespace ProjectSchemaTypes
{
    public static class DB
    {
        public static Tables Tables { get; set; }
    }

    public class Tables
    {

        public WM_User WM_User = new WM_User();
        public WM_ApplicationSettings WM_ApplicationSettings = new WM_ApplicationSettings();



    }

    public class WM_ApplicationSettings : IDatabaseTable
    {
        public ITableColumn UserId { get; private set; }
        public ITableColumn SettingName { get; private set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public ITableColumn OldUserId { get; private set; }
    }

    public class WM_User : IDatabaseTable
    {
        public ITableColumn Id { get; private set; }
        public ITableColumn Name { get; private set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public ITableColumn OldId { get; private set; }
    }
}
