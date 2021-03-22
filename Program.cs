using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_Inheritance_Publication
{
    class Program
    {
        /*Задание 1
        1.	Создать абстрактный класс Издание с методами позволяющим вывести на экран информацию об издании.
        2.	Создать производные классы: Книга (название, фамилия автора, год издания, издательство), 
        Статья (название, фамилия автора, название журнала, его номер и год издания), 
        Электронный ресурс (название, фамилия автора, ссылка, аннотация) со своими методами вывода информации на экран.
        3.	Создать каталог (массив) из n изданий, вывести полную информацию из каталога, 
        а также организовать поиск изданий по фамилии автора.
        */
        static void Main(string[] args)
        {
            Publication book1 = new Book("Война и мир", "Толстой Л.Н.", 1865, "Москва");
            Publication book2 = new Book("Капитал", "Карл Маркс", 1867, "О. Мейснера");
            Publication article1 = new Article("Исследование нелинейного взаимодействия сходящихся звуковых пучков в воздухе", "Воронин В.А.", "Интернаука", 188, 2020);
            Publication article2 = new Article("Понятие спам и методы борьбы с ним", "Котиева Хава Малсаковна", "Интернаука", 4, 2021);
            Publication eResource = new ElectronicResource("Час Быка", "Ефремов Иван Антонович", @"https://thelib.ru/books/efremov_ivan_antonovich/chas_byka.html", "Все имеет свое начало. Творчество И.А.Ефремова — это начало русской научно-фантастической литературы. Его произведения вывели научную фантастику в особый род литературы, который он сам называл «беллетристикой в науке». Она превратилась из литературы «второго сорта» в «могущественный рычаг прогресса и борьбы за лучшую жизнь общества».");

            List<Publication> catalog = new List<Publication>();
            catalog.Add(book1);
            catalog.Add(book2);
            catalog.Add(article1);
            catalog.Add(article2);
            catalog.Add(eResource);

            foreach (Publication item in catalog)
            {
                item.ShowInfo();
            }

            Console.Write("для поиска публикации введите фамилию автора: ");
            string name = Console.ReadLine();
            SearchByName(catalog, name);
        }

        public static void SearchByName(List<Publication> catalog, string name)
        {
            foreach (Publication item in catalog)
            {
                if (item.authorName.Contains(name))
                {
                    item.ShowInfo();
                }
            }
        }
    }
}
