using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_Inheritance_Publication
{
    public class ElectronicResource: Publication
    {
        public string link { get; set; }
        public string annotation { get; set; }

        public ElectronicResource()
        {
            type = "Электронный ресурс";
        }

        public ElectronicResource(string publicationName, string authorName, string link, string annotation): this()
        {
            this.publicationName = publicationName;
            this.authorName = authorName;
            this.link = link;
            this.annotation = annotation;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("ссылка: " + link);
            Console.WriteLine("аннотация: " + annotation);
            Console.WriteLine();
        }
    }
}
