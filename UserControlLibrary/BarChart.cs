using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlLibrary
{
    public class BarChart
    {
        public string Label { get; set; }
        public float Value { get; set; }

        public BarChart(string label, float value)
        {
            Label = label;
            Value = value;
        }
    }
}
