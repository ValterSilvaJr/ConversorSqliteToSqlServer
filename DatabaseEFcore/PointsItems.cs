using System;
using System.Collections.Generic;

namespace DatabaseEFcore
{
    public partial class PointsItems
    {
        public long Id { get; set; }
        public long PointId { get; set; }
        public long ItemId { get; set; }

        public virtual Items Item { get; set; }
        public virtual Points Point { get; set; }
    }
}
