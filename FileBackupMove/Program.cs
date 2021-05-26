using System;
/*
 * SRC디렉토리에 있는 백업 파일들은 일단위로 DEST디렉토리로 일자 폴더 아래 복사한다. 일자별로 폴더를 만들고 복사하는데 일자 폴더는 14일치 유지
 * 주간백업은 3주차일요일자 버젼을 보관한다.
 * 일간백업 14일분 14copy, 주간 3주분 3copy
 * 각 파일 복사시 로그 기록남기고 전체 처리후  db로그에 기록을 남긴다.
 * */

namespace FileBackupMove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
