using System;
/*
 * 사용자가 데이터 Clear
 * 
 * 1)사용자삭제시 해당 사용자의 디렉토리 삭제 * 
 * 2)사용자가 존재시 해당 사용자의 파일들(엑셀업로드 파일및 각종 메일이나 이미지 파일들)중 업로드 시간이 오래 경과한 파일들 삭제 처리. 
 * 
 * 
 * Process)
 * 1) 각종 설정을 초기화한다.
 *  - 사용자 파일들과 디렉토리 위치 및 db접속 정보, 경과한시간 삭제 값
 * 2) 특정 디렉토리에 있는 모든 서브 디렉토리 읽어 Array에 저장
 * 3) Array에 있는 사용자 ID가 db상에 존재하는지 Check
 * 4) 미존재시 -> 해상 사용자가 삭제된 경우임으로 이 id에 해당하는 디렉토리 삭제
 * 5) 위의 과정을 로그로 남긴다. 
 * 6) 로그는 1달치만 보관하게 함.
 * 
 * 
 * DirInfo.cs       --> 디렉토리 및 파일 처리 class
 * */
namespace UserDataClear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
}
