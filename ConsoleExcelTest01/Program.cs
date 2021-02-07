using System;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;

// 
// 도움말
// https://github.com/nissl-lab/npoi/wiki/Getting-Started-with-NPOI
// 

namespace ConsoleExcelTest01
{
    class Program
    {        

        static void Main(string[] args)
        {

            //기본 엑셀 생성관련 테스트 xls
            //BaseExcelCreate01 be1 = new BaseExcelCreate01();
            //be1.Run();

            //기본생성 xlsx 및 성능테스트
            //BasicExcelCreateXLSX be2 = new BasicExcelCreateXLSX();
            //be2.Run();

            //// 엑셀 셀에 해당하는 DataFormat Test
            //DataFormat01 df1 = new DataFormat01();
            //df1.Run();

            //엑셀에 차트그리기
            //ChartTest01 ct1 = new ChartTest01();
            //ct1.Run();

            //엑셀에 링크와 폰트및 셀 border설정
            //HyprtLink_Font hf1 = new HyprtLink_Font();
            //hf1.Run();

            //각종 수식으로 셀에 색을 넣거나 조건에의한 표시처리
            //ConditionalFormats cf1 = new ConditionalFormats();
            //cf1.Run();

            //셀에 메모넣기 및 
            // header와 footer넣기 --> 이건 출력할때 보인다. 출력용 제어라고 보면 됨
            //CreateCommentInXlsx cc1 = new CreateCommentInXlsx();
            //cc1.Run();

            //엑셀에 등록된 이미지 추출하기 & 이미지 추가하기
            //ExtractPicturesFromExcel ep1 = new ExtractPicturesFromExcel();
            //ep1.Run();

            //엑셀셀 바탕색관리 & row및 셀 감추기처리
            FillBackground fb1 = new FillBackground();
            fb1.Run();

        }
    }
}
