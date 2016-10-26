//пример взят с сайта http://professorweb.ru
using System;
using System.Collections;

namespace _403_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем хеш-таблицу
            Hashtable ht = new Hashtable();

            // Добавим несколько записей
            ht.Add("alex85", "12345");
            ht.Add("fg230404", "12ldsd");
            ht.Add("I_best_user", "12349");

            // Считаем коллекцию ключей
            ICollection keys = ht.Keys;

            foreach (string s in keys)
                Console.WriteLine(s + ": " + ht[s]);

            Console.ReadLine();
        }
    }
}
