using System;
using System.Collections.Generic;
using System.Text;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;

namespace ConsoleExcelTest01
{
    class HyprtLink_Font
    {
        public void Run ()
        {
            IWorkbook workbook = new XSSFWorkbook();

            ICellStyle hlink_style = workbook.CreateCellStyle();
            IFont hlink_font = workbook.CreateFont();
            hlink_font.Underline = FontUnderlineType.Single;
            hlink_font.Color = HSSFColor.Blue.Index;
            hlink_style.SetFont(hlink_font);

            ICell cell;
            ISheet sheet = workbook.CreateSheet("Hyperlinks");

            cell = sheet.CreateRow(0).CreateCell(0);
            cell.SetCellValue("URL Link");
            XSSFHyperlink link = new XSSFHyperlink(HyperlinkType.Url);
            link.Address = ("http://poi.apache.org/");
            cell.Hyperlink = (link);
            cell.CellStyle = (hlink_style);

            //link to a file in the current directory
            cell = sheet.CreateRow(1).CreateCell(0);
            cell.SetCellValue("File Link");
            link = new XSSFHyperlink(HyperlinkType.File);
            link.Address = ("link1.xls");
            cell.Hyperlink = (link);
            cell.CellStyle = (hlink_style);

            //e-mail link
            cell = sheet.CreateRow(2).CreateCell(0);
            cell.SetCellValue("Email Link");
            link = new XSSFHyperlink(HyperlinkType.Email);
            //note, if subject contains white spaces, make sure they are url-encoded
            link.Address = ("mailto:poi@apache.org?subject=Hyperlinks");
            cell.Hyperlink = (link);
            cell.CellStyle = (hlink_style);


            //Create a target sheet and cell
            ISheet sheet2 = workbook.CreateSheet("Target ISheet");
            sheet2.CreateRow(0).CreateCell(0).SetCellValue("Target ICell");

            cell = sheet.CreateRow(3).CreateCell(0);
            cell.SetCellValue("Worksheet Link");
            link = new XSSFHyperlink(HyperlinkType.Document);
            link.Address = ("'Target ISheet'!A1");
            cell.Hyperlink = (link);
            cell.CellStyle = (hlink_style);


            // font Test용 Sheet생성
            ISheet sheet1 = workbook.CreateSheet("Font_Test Sheet");

            //font style1: underlined, italic, red color, fontsize=20
            IFont font1 = workbook.CreateFont();
            font1.Color = IndexedColors.Red.Index;
            font1.IsItalic = true;
            font1.Underline = FontUnderlineType.Double;
            font1.FontHeightInPoints = 20;

            //bind font with style 1
            ICellStyle style1 = workbook.CreateCellStyle();
            style1.SetFont(font1);

            //font style2: strikeout line, green color, fontsize=15, fontname='宋体'
            IFont font2 = workbook.CreateFont();
            font2.Color = IndexedColors.OliveGreen.Index;
            font2.IsStrikeout = true;
            font2.FontHeightInPoints = 15;
            font2.FontName = "굴림체";

            //bind font with style 2
            ICellStyle style2 = workbook.CreateCellStyle();
            style2.SetFont(font2);

            //apply font styles
            ICell cell1 = sheet1.CreateRow(1).CreateCell(1);
            cell1.SetCellValue("Hello World!");
            cell1.CellStyle = style1;
            ICell cell2 = sheet1.CreateRow(3).CreateCell(1);
            cell2.SetCellValue("早上好！");
            cell2.CellStyle = style2;

            ////cell with rich text 
            ICell cell3 = sheet1.CreateRow(5).CreateCell(1);
            XSSFRichTextString richtext = new XSSFRichTextString("Microsoft OfficeTM");

            //apply font to "Microsoft Office"
            IFont font4 = workbook.CreateFont();
            font4.FontHeightInPoints = 12;
            richtext.ApplyFont(0, 16, font4);
            
            //apply font to "TM"
            IFont font3 = workbook.CreateFont();
            font3.TypeOffset = FontSuperScript.Super;
            font3.IsItalic = true;
            font3.Color = IndexedColors.Blue.Index;
            font3.FontHeightInPoints = 8;
            richtext.ApplyFont(16, 18, font3);

            cell3.SetCellValue(richtext);




            /*
             * BorderStryle
             * */
            ISheet sheet3 = workbook.CreateSheet("BorderStype");
            IRow row = sheet3.CreateRow(1);
            // Create a cell and put a value in it.
            cell = row.CreateCell(1);
            cell.SetCellValue(4);

            // Style the cell with borders all around.
            ICellStyle style = workbook.CreateCellStyle();
            style.BorderBottom = BorderStyle.Thin;
            style.BottomBorderColor = IndexedColors.Black.Index;
            style.BorderLeft = BorderStyle.DashDotDot;
            style.LeftBorderColor = IndexedColors.Green.Index;
            style.BorderRight = BorderStyle.Hair;
            style.RightBorderColor = IndexedColors.Blue.Index;
            style.BorderTop = BorderStyle.MediumDashed;
            style.TopBorderColor = IndexedColors.Orange.Index;

            //create border diagonal
            style.BorderDiagonalLineStyle = BorderStyle.Medium; //this property must be set before BorderDiagonal and BorderDiagonalColor
            style.BorderDiagonal = BorderDiagonal.Forward;
            style.BorderDiagonalColor = IndexedColors.Gold.Index;

            cell.CellStyle = style;
            // Create a cell and put a value in it.
            cell2 = row.CreateCell(2);
            cell2.SetCellValue(5);
            style2 = workbook.CreateCellStyle();
            style2.BorderDiagonalLineStyle = BorderStyle.Medium;
            style2.BorderDiagonal = BorderDiagonal.Backward;
            style2.BorderDiagonalColor = IndexedColors.Red.Index;
            cell2.CellStyle = style2;

            using (FileStream fs = File.Create(@"C:\00.Dev\temp\HyprtLink_Font.xlsx"))
            {
                workbook.Write(fs);
            }
        }
    }
}
