﻿using System.ComponentModel;

namespace Dukkantek.Inventory.Common.Enums
{
    public enum ProductStatusEnum
    {
        [Description("InStock")]
        Project = 1,
        [Description("Sold")]
        Sold = 2,
        [Description("Damaged")]
        Damaged = 3,
    }
}
