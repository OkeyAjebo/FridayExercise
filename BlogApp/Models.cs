using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp
{
    public class BaseModel
    {
        public int ID { get; set; }
    }

    public class Blog : BaseModel
    {
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }

    public class Post : BaseModel
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Body { get; set; }
    }
    public class Author : BaseModel
    {
        public string FullName { get; set; }
        public List<Post> Posts { get; set; }
    }


}
