using System.Collections.Generic;

namespace Session01.Join
{
    public class Course
    {
        public string Name { get; set; }
        public int MasterId { get; set; }
        public List<int> StudentsId { get; set; }
    }
}
