using NPOI;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleExcelTest01
{
    class BasicExcelCreateXLSX
    {
        public void Run()
        {
            IWorkbook workbook = new XSSFWorkbook();
            
            ISheet sheet1 = workbook.CreateSheet("Sheet A1");
            ISheet sheet2 = workbook.CreateSheet("Sheet A2");
            ISheet sheet3 = workbook.CreateSheet("Sheet A3");

            // 대랑 row생성 테스트 10000 * 20개의 sheet를 만든다.
            //성능테스트 집노트북에서 2초
            Console.WriteLine("Sheet1 Start at " + DateTime.Now.ToString());
            for (int rownum = 0; rownum < 10000; rownum++)
            {
                IRow row = sheet1.CreateRow(rownum);
                for (int celnum = 0; celnum < 20; celnum++)
                {
                    ICell Cell = row.CreateCell(celnum);
                    Cell.SetCellValue("Cell: Row-" + rownum + ";CellNo:" + celnum);
                }
            }
            Console.WriteLine("Sheet1 End at " + DateTime.Now.ToString());


            //성능테스트 집노트북에서 6초
            Console.WriteLine("Sheet2 Start at " + DateTime.Now.ToString());
            int x = 1;
            for (int i = 1; i <= 70000; i++)
            {
                IRow row = sheet2.CreateRow(i);
                for (int j = 0; j < 15; j++)
                {
                    row.CreateCell(j).SetCellValue(x++);
                }
            }
            Console.WriteLine("Sheet2 End at " + DateTime.Now.ToString());

            Console.WriteLine("FileWriteStart at " + DateTime.Now.ToString());
            using (var fileData = new FileStream(@"C:\00.Dev\temp\BasicExcelCreateXLSX.xlsx", FileMode.Create))
            {
                workbook.Write(fileData);
            }
            Console.WriteLine("FileWrite End at " + DateTime.Now.ToString());
        }
    }
}
