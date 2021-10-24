using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Symbolics;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Double.Solvers;

namespace SmallestSquares
{
    public partial class Lab3Form : Form
    {
        public Lab3Form()
        {
            InitializeComponent();
        }

        async private void LaunchButton_click(object sender, EventArgs e)
        {
            try
            {
                double[] xPoints = new double[pointsGrid.RowCount];
                double[] yPoints = new double[pointsGrid.RowCount];
                for (int point = 0; point < pointsGrid.RowCount - 1; ++point)
                {
                    xPoints[point] = double.Parse(pointsGrid[0, point].Value.ToString());
                    yPoints[point] = double.Parse(pointsGrid[1, point].Value.ToString());
                }
                PointsDraw(xPoints, yPoints);
                var coefsContainer = CoefFinding(xPoints, yPoints);
                await Task.Run(() => LineDraw(coefsContainer, minX(xPoints), maxX(xPoints)));
            }
            catch
            {
              
            }
        }



        private double minX(double[] xPoints)
        {
            double minX = xPoints[0];
            for (int point = 0; point < xPoints.Length; ++point)
            {
                if (xPoints[point] < minX)
                {
                    minX = xPoints[point];
                }
            }
            return minX;
        }



        private double maxX(double[] xPoints)
        {
            double maxX = xPoints[0];
            for (int point = 0; point < xPoints.Length; ++point)
            {
                if (xPoints[point] > maxX)
                {
                    maxX = xPoints[point];
                }
            }
            return maxX;
        }



        private void PointsDraw(double[] xPoints, double[] yPoints)
        {
            formulaeChart.Series[0].Points.Clear();
            for (int point = 0; point < xPoints.Length; ++point)
            {
                formulaeChart.Series[0].Points.AddXY(xPoints[point], yPoints[point]);
            }
        }



        private void LineDraw(List<Vector<double>> coefs, double start, double end)
        {
            Action action = () =>
            {
                formulaeChart.Series[1].Points.Clear();
                formulaeChart.Series[2].Points.Clear();
            };
            Invoke(action);
            string linearFuncString = "x*" + coefs[0][0].ToString() + "+" + coefs[0][1].ToString();
            string sqrFuncString = "x^2*" + coefs[1][0].ToString() + "+x*" + coefs[1][1].ToString() + "+" + coefs[1][2].ToString();
            Expression linearFun = Infix.ParseOrThrow(linearFuncString.Replace(',', '.'));
            Expression sqrFunc = Infix.ParseOrThrow(sqrFuncString.Replace(',', '.'));

            double step = (end - start) / 1000;
            while (start < end)
            {
                action = () => {
                    formulaeChart.Series[1].Points.AddXY(start, FuncValue(start, linearFun));
                    formulaeChart.Series[2].Points.AddXY(start, FuncValue(start, sqrFunc));
                    };
                Invoke(action);
                start += step;
            }
        }



        private double FuncValue(double point, Expression func)
        {
            Dictionary<string, FloatingPoint> symbol = new Dictionary<string, FloatingPoint>()
            {
                { "x", point }
            };
            return MathNet.Symbolics.Evaluate.Evaluate(symbol, func).RealValue;
        }



        private List<Vector<double>> CoefFinding(double[] xPoints, double[] yPoints)
        {
            double summY = 0;
            double summX = 0;
            double summSqrX = 0;
            double summThrX = 0;
            double summQuadX = 0;
            double summXY = 0;
            double summSqrXY = 0;

            for (int point = 0; point < xPoints.Length; ++point)
            {
                summY += yPoints[point];
                summX += xPoints[point];
                summSqrX += Math.Pow(xPoints[point], 2);
                summThrX += Math.Pow(xPoints[point], 3);
                summQuadX += Math.Pow(xPoints[point], 4);
                summXY += xPoints[point] * yPoints[point];
                summSqrXY += Math.Pow(xPoints[point], 2) * yPoints[point];
            }

            Matrix<double> matrix = DenseMatrix.OfArray(new double[,] {
                {summQuadX, summThrX, summSqrX},
                {summThrX, summSqrX, summX},
                {summSqrX, summX, xPoints.Length - 1}});
            Vector<double> answers = Vector<double>.Build.Dense(new double[] { summSqrXY, summXY, summY });

            Vector<double> sqrCoefs = matrix.SolveIterative(answers, new MlkBiCgStab());
            Vector<double> linearCoefs = matrix.SubMatrix(1, 2, 1, 2).SolveIterative(answers.SubVector(1, 2), new MlkBiCgStab());

            List<Vector<double>> coefsContainer = new List<Vector<double>> { linearCoefs, sqrCoefs };
            return coefsContainer;
        }



        private void CloseButton_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
