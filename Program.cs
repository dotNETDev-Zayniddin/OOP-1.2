/*
Book class dan object yarating va object orqali propertylar yordamida fieldlarning qiymatini o’zgartiring.
*/


using System;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {   
            Book book = new Book();
            Console.WriteLine("Ma'lumotlar bazasiga kiritish uchun kitob haqida ma'lumotlarni to'ldiring: ");
            
            Console.Write("Kitob nomini kiriting: " + book.Title);
            book.Title = Console.ReadLine();
            
            Console.Write($"{book.Title} kim tomonidan yozilgan? ");
            book.Author = Console.ReadLine();

            Console.Write($"Kitob qaysi yilda nashr qilingan? ");
            book.Year = Convert.ToInt32(Console.ReadLine());
           
            Console.Write($"{book.Author}ning {book.Title}({book.Year}) kitobi narxini kiriting:(so'mda) ");
            book.Price = Convert.ToInt32(Console.ReadLine());
            
            book.SettingUp();

        }
    }
}