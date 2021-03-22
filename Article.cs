using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_Inheritance_Publication
{
    public class Article: Publication
    {
        public string journalName { get; set; }
        public int journalNumber { get; set; }
        private int yearPublicMagazine_;
        public int yearPublicMagazine
        {
            get { return yearPublicMagazine_; }
            set
            {
                if (value > 0) { yearPublicMagazine_ = value; }
                else throw new Exception("ошибка! год может быть только положительным числом!");
            }
        }

        public Article()
        {
            type = "Статья";
        }
        public Article(string publicationName, string authorName, string journalName, int journalNumber, int yearPublicMagazine) : this()
        {
            this.publicationName = publicationName;
            this.authorName = authorName;
            this.journalName = journalName;
            this.journalNumber = journalNumber;
            this.yearPublicMagazine = yearPublicMagazine;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("название журнала: " + journalName);
            Console.WriteLine("номер журнала: " + journalNumber);
            Console.WriteLine("год издания журнала: " + yearPublicMagazine);
            Console.WriteLine();
        }
    }
}
