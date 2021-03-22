using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_Inheritance_Publication
{
    public class Book : Publication
    {
        private int yearPublication_;
        public int yearPublication {
            get { return yearPublication_; }
            set {
                if (value > 0) { yearPublication_ = value; }
                else throw new Exception("ошибка! год может быть только положительным числом!");
            }
        }
        public string publishingHouse { get; set; }
        public Book()
        {
            type = "Книга";
        }
        public Book(string publicationName, string authorName, int yearPublication, string publishingHouse) : this()
        {
            this.publicationName = publicationName;
            this.authorName = authorName;
            this.yearPublication = yearPublication;
            this.publishingHouse = publishingHouse;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("год публикации: " + yearPublication);
            Console.WriteLine("издательство: " + publishingHouse);
            Console.WriteLine();
        }



    }
}
