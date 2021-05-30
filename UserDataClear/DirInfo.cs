using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDataClear
{
    public class DirInfo
    {
        private string _path;           //디렉토리 정보

        public DirInfo(string path)
        {
            _path = path;
        }

        /// <summary>
        /// 특정 위치의 디렉토리에 있는 모든 서브 디렉토리를 읽어온다.
        /// </summary>
        /// <returns></returns>
        public ArrayList GetDirInfo()
        {
            ArrayList dirInfo = new ArrayList();
            return dirInfo;
        }

        /// <summary>
        /// 사용자 id가 없을경우 해당 id에 해당하는 디렉토리 모두 삭제
        /// </summary>
        /// <returns></returns>
        public bool DelDir( string id)
        {
            return true;
        }

    }
}
