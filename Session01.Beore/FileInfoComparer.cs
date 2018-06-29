using System.Collections.Generic;
using System.IO;

namespace Session01.Beore
{
    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            if (x.Length<y.Length)
            {
                return -1;
            }
            else if(x.Length==y.Length)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
