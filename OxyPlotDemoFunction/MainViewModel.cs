using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Legends;

namespace OxyPlotDemoFunction
{
    public class MainViewModel
    {

        public MainViewModel()
        {
            MyModel = new PlotModel { Title = "Demo Function" };


            FS = new FunctionSeries();
            FS.Title = "y=f(x)";
            FS.Points.Add(new DataPoint(0, 0));
            FS.Points.Add(new DataPoint(1, 1));
            MyModel.Series.Add(FS);

            MyModel.Series.Add(GetFunction());
            MyModel.Series.Add(GetLines());


            MyModel.Legends.Add(new Legend { LegendPosition = LegendPosition.RightTop, LegendPlacement = LegendPlacement.Outside, LegendOrientation = LegendOrientation.Vertical });






        }

        public PlotModel MyModel { get; private set; }

        public FunctionSeries FS { get; private set; }

        private FunctionSeries GetFunction() 
        {
            FunctionSeries fs = new FunctionSeries();
            for (double i = 0.0; i < 1.0; i += 0.01)
            {
                DataPoint dp = new DataPoint(i, GetValue(i));
                fs.Points.Add(dp);
            }

            
            return fs;
        }
        

        private double GetValue(double x)
        {
            double cycle = 0.25;
            return Math.Sin(Math.Sqrt(2 * Math.PI * cycle /100 + x));
        }


        private FunctionSeries GetLines()
        {
            double[] x = new double[100];
            double[] y = new double[100];
            double cycle = 0.25;
            int k = 2;

            x[0] = x[1] = y[0] = 0.02;
            y[1] = Math.Sin(Math.Sqrt(2 * Math.PI * 2 * cycle / 100 + 2/100));

            Console.WriteLine("1");
            for (int i = 2; i < 100; i+=2) 
            {
                x[k] = y[i - 1];
                y[k] = y[i - 1];
                x[k + 1] = y[i - 1];
                y[k + 1] = Math.Sin(Math.Sqrt(2 * Math.PI * y[i] * cycle / 100 + y[i]));
                k += 2;


            }

            FunctionSeries Fs = new FunctionSeries();

            for(int i=1; i<100; ++i)
            {
                DataPoint dp = new DataPoint(x[i], y[i]);
                Fs.Points.Add(dp);
            }
            return Fs;

        }
    }
}
