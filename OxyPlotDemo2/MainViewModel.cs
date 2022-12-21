using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
//using OxyPlot.Axes;
using OxyPlot.Series;


namespace OxyPlotDemo2
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.MyModel = new PlotModel { Title = "Example 1" };
            MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, " cos(x)"));
           // MyModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = -20, Maximum = 80 });
            //MyModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = -10, Maximum = 10 });

        }

        public PlotModel MyModel { get; private set; }

    }
}
