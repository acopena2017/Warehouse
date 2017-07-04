using System;
using System.Collections.Generic;

namespace Warehouse.Entities
{
    public partial class QueuingConfiguration
    {
        public int QueuingConfigurationId { get; set; }
        public string Name { get; set; }
        public double CrossAisleFactor { get; set; }
        public double HighLoosePickFactor { get; set; }
        public double HighPickFactor { get; set; }
        public double LowLoosePickFactor { get; set; }
        public double NewItemFactor { get; set; }
        public double NewLocationFactor { get; set; }
        public double PalletPickFactor { get; set; }
        public double PalletPickForLooseFactor { get; set; }
        public double XyDistanceFactor { get; set; }
        public double ZDistanceFactor { get; set; }
        public double NewPalletFactor { get; set; }
        public double ReserveBinFactor { get; set; }
    }
}
