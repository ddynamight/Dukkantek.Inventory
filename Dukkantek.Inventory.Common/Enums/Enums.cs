using System.ComponentModel;

namespace Dukkantek.Inventory.Common.Enums
{
    public enum InvoiceTypeEnum
    {
        [Description("General")]
        General = 0,
        [Description("Project")]
        Project = 1,
        [Description("Service")]
        Service = 2,
    }

    public enum DurationTypeEnum
    {
        [Description("Weekly")]
        Weekly = 1,
        [Description("Monthly")]
        Monthly = 2,
        [Description("Quarterly")]
        Quarterly = 3,
        [Description("BiAnnually")]
        BiAnnually = 4,
        [Description("Annually")]
        Annually = 5,
        [Description("Biennially")]
        Biennially = 6,
        [Description("Quinquennially")]
        Quinquennially = 7,
    }
}
