using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _01.ConsoleTest
{
    /// <summary>
    /// using으로 사용할수 있게 만듬
    /// : IDisposable를 상속받고 Dispose()를 반드시 구현해야 함.
    /// 이걸 using에 사용하면 반드시 닫힘.
    /// </summary>
    class _07Disposable : IDisposable
    {
        private TextWriter writer = null;

        public void Create() 
        {
            writer = File.CreateText("sample.txt");
        }

        public void Close()
        {
            Dispose();
        }

        public void Write() 
        {
            throw new ApplicationException("Sample Exception");
        }
        public void Dispose()
        {
            if (writer != null) writer.Close();
        }
    }
}
