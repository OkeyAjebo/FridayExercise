using BlogApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp
{
    public class Tester
    {
        BlogRepository<Blog, Post> repository = new BlogRepository<Blog, Post>();
        
        public static void Main()
        {

            Console.ReadLine();
        }

        public void Add()
        {
             
        }
    }
}
