using System;
using System.Collections.Generic;

namespace DatabaseEFcore
{
    public partial class KnexMigrationsLock
    {
        public long Index { get; set; }
        public long? IsLocked { get; set; }
    }
}
