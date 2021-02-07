using System;
using System.Collections.Generic;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Collections;
using System.Drawing;
using System.IO;

namespace ConsoleExcelTest01
{
    class ExtractPicturesFromExcel
    {
        public void Run()
        {
            FileStream file = File.OpenRead(@"C:\00.Dev\VSTestProject\TestSolution01\ConsoleExcelTest01\clothes.xlsx");
            IWorkbook workbook = new XSSFWorkbook(file);

            IList pictures = workbook.GetAllPictures();
            int i = 0;
            foreach (IPictureData pic in pictures)
            {
                string ext = pic.SuggestFileExtension();
                if (ext.Equals("jpeg"))
                {
                    Image jpg = Image.FromStream(new MemoryStream(pic.Data));
                    jpg.Save(string.Format("pic{0}.jpg", i++));
                }
                else if (ext.Equals("png"))
                {
                    Image png = Image.FromStream(new MemoryStream(pic.Data));
                    png.Save(string.Format("pic{0}.png", i++));
                }
            }


            /* 엑셀에 이미지를 추가한다.
            IDrawing patriarch = sheet1.CreateDrawingPatriarch();
            //create the anchor
            XSSFClientAnchor anchor = new XSSFClientAnchor(500, 200, 0, 0, 2, 2, 4, 7);
            anchor.AnchorType = AnchorType.MoveDontResize;
            //load the picture and get the picture index in the workbook
            //first picture
            int imageId = LoadImage("../../image/HumpbackWhale.jpg", workbook);
            XSSFPicture picture = (XSSFPicture)patriarch.CreatePicture(anchor, imageId);
            //Reset the image to the original size.
            //picture.Resize();   //Note: Resize will reset client anchor you set.
            picture.LineStyle = LineStyle.DashDotGel;

            //second picture
            int imageId2 = LoadImage("../../image/HumpbackWhale.jpg", workbook);
            XSSFClientAnchor anchor2 = new XSSFClientAnchor(500, 200, 0, 0, 5, 10, 7, 15);
            XSSFPicture picture2 = (XSSFPicture)patriarch.CreatePicture(anchor2, imageId2);
            picture.LineStyle = LineStyle.DashDotGel;
            */

        }

        public int LoadImage(string path, IWorkbook wb)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[file.Length];
            file.Read(buffer, 0, (int)file.Length);
            return wb.AddPicture(buffer, PictureType.JPEG);
        }


    }
}
