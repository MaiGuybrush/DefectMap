using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefectMap.Models
{
    public class LayoutConfig
    {
        public Corner ChipCorner { get; set; }
        public int Width {get; set;}
        public int Height { get; set; }
        public List<PanelConfig> Panles { get; set; }
    }
}