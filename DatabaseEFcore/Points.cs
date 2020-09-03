﻿using System;
using System.Collections.Generic;

namespace DatabaseEFcore
{
    public partial class Points
    {
        public Points()
        {
            PointsItems = new HashSet<PointsItems>();
        }

        public long Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Whatsapp { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string City { get; set; }
        public string Uf { get; set; }

        public virtual ICollection<PointsItems> PointsItems { get; set; }
    }
}
