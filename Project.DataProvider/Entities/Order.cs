﻿using System;

namespace Project.DataProvider.Entities
{
    public class Order : BaseEntity<long>
    {
        public DateTime Time { get; set; }
        public virtual Employee Employee { get; set; }
        // TODO: Add User field and add config to it
        public virtual Service Service { get; set; }
    }
}
