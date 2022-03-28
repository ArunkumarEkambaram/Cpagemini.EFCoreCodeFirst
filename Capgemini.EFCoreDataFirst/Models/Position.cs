using System;
using System.Collections.Generic;

#nullable disable

namespace Capgemini.EFCoreDataFirst.Models
{
    public partial class Position
    {
        public string CPositionCode { get; set; }
        public string VDescription { get; set; }
        public int? IBudgetedStrength { get; set; }
        public short? SiYear { get; set; }
        public int? ICurrentStrength { get; set; }
    }
}
