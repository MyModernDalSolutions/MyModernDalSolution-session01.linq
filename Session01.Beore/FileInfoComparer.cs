using System.Collections.Generic;
using System.IO;

namespace Session01.Beore
{
    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            checkequal(x.Length, y.Length);
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
            
            bool checkequal(long a, long b)
            {
                //while repeat code in the same method
                //clean code in methods
                return a > b;
            }
        }
        
    }
}
