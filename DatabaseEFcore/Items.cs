using System;
using System.Collections.Generic;

namespace DatabaseEFcore
{
    public partial class Items
    {
        public Items()
        {
            PointsItems = new HashSet<PointsItems>();
        }

        public long Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }

        public virtual ICollection<PointsItems> PointsItems { get; set; }
    }
}
