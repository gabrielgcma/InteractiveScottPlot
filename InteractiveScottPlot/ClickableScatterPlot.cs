using ScottPlot.Plottable;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveScottPlot
{
    public class ClickableScatterPlot : ScatterPlot, IHittable
    {
        public ScottPlot.Cursor HitCursor { get; set; } = ScottPlot.Cursor.Hand;
        public bool HitTestEnabled { get; set; } = true;

        private float hitTolerance = 1.2f;

        private FormsPlot targetPlot;

        private float pointsSize;

        private Crosshair crossHair;
        public Coordinate LastHoveredPoint { get; set; }

        public ClickableScatterPlot(double[] xs,
                                    double[] ys,
                                    float pointsSize,
                                    FormsPlot targetPlot) : base(xs, ys)
        {
            this.targetPlot = targetPlot;
            this.pointsSize = pointsSize;
            this.MarkerSize = pointsSize;
            this.MarkerColor = targetPlot.Plot.GetSettings().GetNextColor();
            this.LineStyle = LineStyle.None;
        }

        public bool HitTest(Coordinate hitCoords)
        {
            PlotDimensions plotDims = targetPlot.Plot.GetSettings().GetPlotDimensions(0, 0, 1);

            bool hit = false;
            Coordinate hoveredPointCoords = new();

            for (int i = 0; i < Xs.Length; i++)
            {
                var pX = Xs[i];
                var pY = Ys[i];

                Coordinate currentPointCoords = new(pX, pY);

                Pixel currentPointCoordsPx = currentPointCoords.ToPixel(plotDims);
                Pixel hitCoordsPx = hitCoords.ToPixel(plotDims);

                double hitToPointDist = hitCoordsPx.Distance(currentPointCoordsPx);

                hit = hitToPointDist < pointsSize * hitTolerance;

                if (hit)
                {
                    hoveredPointCoords = currentPointCoords;
                    break;
                }
            }

            if (hit)
            {
                Func<double, string> formatter = val => $"{val:F4}";

                if (crossHair != null)
                    targetPlot.Plot.Remove(crossHair);

                crossHair = targetPlot.Plot.AddCrosshair(hoveredPointCoords.X, hoveredPointCoords.Y);
                crossHair.VerticalLine.PositionFormatter = formatter;
                crossHair.HorizontalLine.PositionFormatter = formatter;

                LastHoveredPoint = hoveredPointCoords;
                targetPlot.Refresh();
            }
            else
            {
                targetPlot.Plot.Remove(crossHair);
                targetPlot.Refresh();
                LastHoveredPoint = new Coordinate(0, 0);
            }

            return hit;
        }
    }
}
