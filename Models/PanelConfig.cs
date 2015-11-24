using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefectMap.Models
{
    public class PanelConfig
    {
        public string ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Corner PosType { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int DataCount { get; set; }
        public int GateCount { get; set; }
        public int DataWidth { get; set; }
        public int GateWidth { get; set; }
    }
}