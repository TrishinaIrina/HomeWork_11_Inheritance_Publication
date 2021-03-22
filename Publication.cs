using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_Inheritance_Publication
{
    public abstract class Publication
    {
        public string type { get; set; }
        public string publicationName { get; set; }
        public string authorName { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine("тип издания: " + type);
            Console.WriteLine("название публикации: " + publicationName);
            Console.WriteLine("имя автора: " + authorName);
        }
    }
}
