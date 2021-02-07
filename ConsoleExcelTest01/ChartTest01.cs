using NPOI.SS.UserModel;
using NPOI.SS.UserModel.Charts;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System.IO;

namespace ConsoleExcelTest01
{
    class ChartTest01
    {
        const int NUM_OF_ROWS = 3;
        const int NUM_OF_COLUMNS = 10;



        private void CreateChart(IDrawing drawing, ISheet sheet, IClientAnchor anchor, string serie1, string serie2)
        {
            IChart chart = drawing.CreateChart(anchor);
            IChartLegend legend = chart.GetOrCreateLegend();
            legend.Position = LegendPosition.TopRight;

            ILineChartData<double, double> data = chart.ChartDataFactory.CreateLineChartData<double, double>();

            // Use a category axis for the bottom axis.
            IChartAxis bottomAxis = chart.ChartAxisFactory.CreateCategoryAxis(AxisPosition.Bottom);
            IValueAxis leftAxis = chart.ChartAxisFactory.CreateValueAxis(AxisPosition.Left);
            leftAxis.Crosses = AxisCrosses.AutoZero;

            IChartDataSource<double> xs = DataSources.FromNumericCellRange(sheet, new CellRangeAddress(0, 0, 0, NUM_OF_COLUMNS - 1));
            IChartDataSource<double> ys1 = DataSources.FromNumericCellRange(sheet, new CellRangeAddress(1, 1, 0, NUM_OF_COLUMNS - 1));
            IChartDataSource<double> ys2 = DataSources.FromNumericCellRange(sheet, new CellRangeAddress(2, 2, 0, NUM_OF_COLUMNS - 1));

            var s1 = data.AddSeries(xs, ys1);
            s1.SetTitle(serie1);
            var s2 = data.AddSeries(xs, ys2);
            s2.SetTitle(serie2);

            chart.Plot(data, bottomAxis, leftAxis);
        }


        public void Run()
        {
            IWorkbook wb = new XSSFWorkbook();
            ISheet sheet = wb.CreateSheet("linechart");

            IRow row;
            ICell cell;


            // line chart
            for (int rowIndex = 0; rowIndex < NUM_OF_ROWS; rowIndex++)
            {
                row = sheet.CreateRow((short)rowIndex);
                for (int colIndex = 0; colIndex < NUM_OF_COLUMNS; colIndex++)
                {
                    cell = row.CreateCell((short)colIndex);
                    cell.SetCellValue(colIndex * (rowIndex + 1));
                }
            }

            IDrawing drawing = sheet.CreateDrawingPatriarch();
            IClientAnchor anchor1 = drawing.CreateAnchor(0, 0, 0, 0, 0, 5, 10, 15);
            CreateChart(drawing, sheet, anchor1, "title1", "title2");
            IClientAnchor anchor2 = drawing.CreateAnchor(0, 0, 0, 0, 0, 20, 10, 35);
            CreateChart(drawing, sheet, anchor2, "s1", "s2");



            // ScatterChart
            ISheet sheet1 = wb.CreateSheet("ScatterChart");
            for (int rowIndex = 0; rowIndex < NUM_OF_ROWS; rowIndex++)
            {
                row = sheet1.CreateRow((short)rowIndex);
                for (int colIndex = 0; colIndex < NUM_OF_COLUMNS; colIndex++)
                {
                    cell = row.CreateCell((short)colIndex);
                    cell.SetCellValue(colIndex * (rowIndex + 1));
                }
            }

            drawing = sheet1.CreateDrawingPatriarch();
            IClientAnchor anchor = drawing.CreateAnchor(0, 0, 0, 0, 0, 5, 10, 15);

            IChart chart = drawing.CreateChart(anchor);
            IChartLegend legend = chart.GetOrCreateLegend();
            legend.Position = (LegendPosition.TopRight);

            IScatterChartData<double, double> data = chart.ChartDataFactory.CreateScatterChartData<double, double>();

            IValueAxis bottomAxis = chart.ChartAxisFactory.CreateValueAxis(AxisPosition.Bottom);
            IValueAxis leftAxis = chart.ChartAxisFactory.CreateValueAxis(AxisPosition.Left);
            leftAxis.Crosses = AxisCrosses.AutoZero;

            IChartDataSource<double> xs = DataSources.FromNumericCellRange(sheet1, new CellRangeAddress(0, 0, 0, NUM_OF_COLUMNS - 1));
            IChartDataSource<double> ys1 = DataSources.FromNumericCellRange(sheet1, new CellRangeAddress(1, 1, 0, NUM_OF_COLUMNS - 1));
            IChartDataSource<double> ys2 = DataSources.FromNumericCellRange(sheet1, new CellRangeAddress(2, 2, 0, NUM_OF_COLUMNS - 1));


            data.AddSeries(xs, ys1);
            data.AddSeries(xs, ys2);
            chart.Plot(data, bottomAxis, leftAxis);


            using (FileStream fs = File.Create(@"C:\00.Dev\temp\ChartTest.xlsx"))            
            {
                wb.Write(fs);
            }

        }
    }
}
