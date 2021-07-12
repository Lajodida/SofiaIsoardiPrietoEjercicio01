using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofiaIsoardiPrietoEjercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la medida del primer cateto del triángulo");
            var catetoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la medida del segundo cateto del triángulo");
            var catetoB = Convert.ToDouble(Console.ReadLine());

            var superficie = (catetoA * catetoB) / 2;
            var hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
            var perimetro = catetoA + catetoB + hipotenusa;

            Console.WriteLine($"La superficie del triángulo es: {superficie}");
            Console.WriteLine($"El prímetro del triángulo es: {perimetro}");

        }
    }
}
