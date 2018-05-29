using System;
using System.Text;

namespace Aula12Complete
{
    class Program
    {
        static void Main(string[] args)
        {

            // Especificar UTF-8 como codificação de saída
            Console.OutputEncoding = Encoding.UTF8;

            // Declarar coleções do tipo Guarda3 para diferentes
            // tipos a guardar
            Guarda3<IStuff> g3istuff;
            Guarda3<string> g3s;
            Guarda3<float> g3f;

            // No caso do IStuff usar SetItem e GetItem
            g3istuff = new Guarda3<IStuff>();
            g3istuff.SetItem(1, new Food(FoodType.Bread, 2.3f, 0.5f));
            g3istuff.SetItem(2, new Food(FoodType.Meat, 0.3f, 0.95f));
            g3istuff.SetItem(3, new Gun(5, 0.1f, 10, 250f));

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(g3istuff.GetItem(i));
            }

            // No caso das strings usar SetItem e o facto de Guarda3<T> ser
            // iterável
            g3s = new Guarda3<string>();
            g3s.SetItem(1, "Olá");
            g3s.SetItem(2, "Tudo bem?");
            g3s.SetItem(3, "Adeus!");

            foreach (string s in g3s)
            {
                Console.WriteLine(s);
            }

            // No caso dos float usamos a sintaxe de inicialização de coleções
            // e o facto de Guarda3<T> ser iterável
            g3f = new Guarda3<float>() { 5.4f, 19.1f, -100f};

            foreach (float f in g3f)
            {
                Console.WriteLine(f);
            }
        }
    }
}
