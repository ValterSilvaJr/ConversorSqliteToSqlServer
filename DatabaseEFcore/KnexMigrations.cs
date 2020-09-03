using System;
using System.Collections.Generic;

namespace DatabaseEFcore
{
    public partial class KnexMigrations
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? Batch { get; set; }
        public byte[] MigrationTime { get; set; }
    }
}
