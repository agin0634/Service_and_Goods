using System;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

namespace Service_and_Goods
{
    [ConfigurationPath("Service_and_Goods.xml")]
    public class Service_and_GoodsConfiguration
    {
        public bool RemoveServiceGarbage { get; set; }
        public bool RemoveServiceHealth { get; set; }
        public bool RemoveServiceDeath { get; set; }
        public bool RemoveServiceCrime { get; set; }
        public bool RemoveServiceFireSafety { get; set; }

        public bool RemovePollutionGround { get; set; }
        public bool RemovePollutionWater { get; set; }
        public bool RemovePollutionNoise { get; set; }
    }
}


