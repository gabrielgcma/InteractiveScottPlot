using ScottPlot;
using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveScottPlot
{
    public partial class ClickableScatterPlotDemo : Form
    {
        private static Random rand = new();

        private List<double[]> ysSignal;

        private int pointCount = 1000;

        private int secondaryDataSampleCount = 100;

        public ClickableScatterPlotDemo()
        {
            InitializeComponent();

            formsPlot1.LeftClickedPlottable += FormsPlot1_LeftClickedPlottable;

            formsPlot1.Plot.Title("Primary data");
            formsPlot2.Plot.Title("Secondary data");

            formsPlot1.Plot.Palette = Palette.OneHalfDark;
            formsPlot2.Plot.Palette = Palette.OneHalfDark;
            formsPlot1.Plot.Style(Style.Gray1);
            formsPlot2.Plot.Style(Style.Gray1);

            ysSignal = new(pointCount);

            for (int i = 0; i < pointCount; i++)
            {
                double[] randomSamples = DataGen.RandomNormal(rand, secondaryDataSampleCount);
                ysSignal.Add(randomSamples);
            }

            double[] xsScatter = DataGen.RandomNormal(rand, pointCount, 3);
            double[] ysScatter = DataGen.RandomNormal(rand, pointCount, 2);

            ClickableScatterPlot randomScatterPoints = new(xsScatter, ysScatter, 3f, formsPlot1);
            formsPlot1.Plot.Add(randomScatterPoints);
            formsPlot1.Refresh();
            formsPlot2.Refresh();

            pointXLabel.Text = "";
            pointYLabel.Text = "";
        }

        private void FormsPlot1_LeftClickedPlottable(object? sender, EventArgs e)
        {
            if (sender is ClickableScatterPlot points)
            {
                Coordinate clickedCoords = points.LastHoveredPoint;

                int clickedPointIndex = 0;

                for (int i = 0; i < points.PointCount; i++)
                {
                    if (points.Xs[i] == clickedCoords.X
                        && points.Ys[i] == clickedCoords.Y)
                    {
                        clickedPointIndex = i;
                    }
                }

                pointXLabel.Text = $"{clickedCoords.X:0.000}";
                pointYLabel.Text = $"{clickedCoords.Y:0.000}";

                formsPlot2.Plot.Clear();
                formsPlot2.Plot.AddSignal(ysSignal[clickedPointIndex], color: points.Color);
                formsPlot2.Refresh();
            }
        }
    }
}
