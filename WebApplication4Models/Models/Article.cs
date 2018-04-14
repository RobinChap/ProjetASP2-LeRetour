using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Article
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string ContentEng { get; set; }
        public string ContentFr { get; set; }
        public string UrlImg { get; set; }
        public DateTime PostDate { get; set; }
    }
}
