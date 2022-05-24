using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlLibrary
{
    public partial class BarChartControl : Control
    {
        public BarChart[] data;
        public BarChart[] Data
        {
            get { return data; }
            set
            {

                data = value;
                Invalidate();
                Update();
            }
        }

        public BarChartControl()
        {
            
            InitializeComponent();

            Data = new BarChart[]
            {
                new BarChart("1 - 2",15),
                new BarChart("2 - 3",2),
                new BarChart("3 - 4",3),
                new BarChart("4 - 5",4),
                new BarChart("5 - 6",5),
                new BarChart("6 - 7",6),
                new BarChart("7 - 8",7),
                new BarChart("8 - 9",8),
                new BarChart("9 - 10",9)
            };
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            var barWidth = pe.ClipRectangle.Width / (Data.Length+1);
            float maxValue = Data.Max(x => x.Value);
            float minValue = Data.Min(x => x.Value);
            var scalingFactor = (pe.ClipRectangle.Height-25) / (maxValue);
            
            
            for (int i = 0; i < Data.Length; i++)
            {
                float barHeight = Data[i].Value * scalingFactor;

                float barX = (i + 1) * barWidth - 15;
                float barY = pe.ClipRectangle.Height - barHeight - 25;

                pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(15, 52, 96)), barX, barY, (float)(barWidth * 0.8), barHeight);
                pe.Graphics.DrawRectangle(new Pen(Color.FromArgb(233, 69, 96)), barX, barY, (float)(barWidth * 0.8), barHeight);

                pe.Graphics.DrawString(Data[i].Label, new Font("Century Gothic", 10), Brushes.White, barX + 3, pe.ClipRectangle.Height - 20);
            }

            for (int i = 0; i <= maxValue; i +=1)
            {
                var y = pe.ClipRectangle.Height - i * scalingFactor - 25;

                pe.Graphics.DrawLine(new Pen(Color.FromArgb(90, 120, 120)), 20, y, pe.ClipRectangle.Width, y);
                pe.Graphics.DrawString(i.ToString(), new Font("Century Gothic", 10), Brushes.White, 0, y);
            }
        }
    }
}
