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
        public bool RemovePollutionGround { get; set; }
        public bool RemovePollutionWater { get; set; }
        public bool RemovePollutionNoise { get; set; }
    }
}


