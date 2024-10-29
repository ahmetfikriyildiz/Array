using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArray
{
    class Program
    {
        static void Main()
        {
            // 1. Aşama: 10 adet tam sayı verisi alacak bir dizi tanımlayın
            int[] array= new int[10];

            // 2. Aşama: Dizinin elemanlarını bir for döngüsü ile doldurun.Dizinin elemanlarını foreach döngüsü ile ekrana yazdırın
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = i;
            }
            foreach (int i in array)
            {
                Console.Write(i+" ");
            }

            // 3. Aşama: Diziye kullanıcıdan alınan yeni bir değeri ekleyi
            Console.Write("\nLütfen bir eleman giriniz : ");
            int newEleman=Convert.ToInt32(Console.ReadLine());

            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            
            newArray[array.Length] = newEleman;

            Console.WriteLine("Onbirinci eleman eklenmiş dizi");
            foreach (int i in newArray)
            {
                Console.Write(i + " ");
            }

            // 4. Aşama: Diziyi büyükten küçüğe sıralayın ve ekrana yazdırın
            Array.Sort( newArray );
            Array.Reverse( newArray );

            Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi:");
            foreach (int i in newArray)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
