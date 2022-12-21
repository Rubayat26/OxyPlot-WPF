using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Wpf;
using OxyPlot.Legends;


namespace OxyPlotDemo3
{
    
    public class MainViewModel
    {
        public MainViewModel()
        {
            // MyModel = new PlotModel { Title = "Example 1" };

            // // MyModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = -20, Maximum = 80 });
            // //MyModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = -10, Maximum = 10 });

            
            // MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            //// MyModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));


            // MyModel.IsLegendVisible = true;
            MyModel = new PlotModel { Title = "Example 1"};
            MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            MyModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
            MyModel.Series.Add(new FunctionSeries(Math.Tan, 0, 10, 0.1, "tan(x)"));
            MyModel.Series.Add(new FunctionSeries(Math.Log, 0, 1, 0.1, "log(x)"));
            MyModel.Series.Add(new FunctionSeries(Math.Exp, 0, 1, 0.1, "exp(x)"));


            MyFunctionSeries = new FunctionSeries();
            MyFunctionSeries.Points.Add(new DataPoint(0, 0));
            MyFunctionSeries.Points.Add(new DataPoint(10, 10));
            MyFunctionSeries.Title = "DataPoints";


            MyModel.Series.Add(MyFunctionSeries);



            //model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = -20, Maximum = 80 });
            //model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = -10, Maximum = 10 });
            //model.IsLegendVisible = true;
            MyModel.Legends.Add(new Legend { LegendPosition = LegendPosition.RightTop, LegendPlacement = LegendPlacement.Outside, LegendOrientation = LegendOrientation.Vertical });


        }

        public PlotModel MyModel { get; private set; }

        public FunctionSeries MyFunctionSeries { get; private set; }

        //public PlotView MyPlotView { get; private set; }
    }
}
