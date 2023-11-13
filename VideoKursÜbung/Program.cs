using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VideoKursÜbung
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //Maxvalue Minvalue und uint probiert und implementiert
            string s = "string";
            int i = int.MaxValue;
            int f = int.MinValue;
            uint u = uint.MinValue;

            //

            //objekt initialisiert und + Operator benutzt
            object obj = new object();
            Console.WriteLine("Hello World " + s + " Bye World");
            Console.ReadLine();

            //Verschiedene Arrays erstellt und initialisiert

            int[] number = { 4, 5, 6 };

            int[] number2 = { 1, 2, 3 };

            int[,] numbers = { { 2, 3, 4 }, { 1, 2, 3 } };

            //CopyTo Methode benutzt 

            number.CopyTo(number2, 0);


            bool result;

            //is  benutzt
            result = i is int;
            Console.WriteLine("Is i int? : {0}", result);
            Console.ReadLine();

            //? Operator benutzt

            string n = true ? " v ist true" : "v ist falsch";
            Console.ReadLine();

            Console.WriteLine(f + "" + i);

            Console.ReadLine();

            // Neue Operatoren benutzt

            i ^= f;
            i |= f;

            Console.WriteLine(f + "" + i);

            Console.ReadLine();

            string x = "";

            //neue Operatorenkombination versucht

            result = i < f || f > 0;

            Console.WriteLine(result);

            Console.ReadLine();

            // as Stichwort benutzt

            String newtype = obj as String;

           


            // throw benutzt

            try 
            {
                
            }
            catch
            {
                // Macht etwas.
                throw;
            }
        }

        static bool X()
        {
            return false;

            
        }

        void x()
        {
            this.x();
        }

        // derived class, base, virtual und override benutzt
        public class Vehicle
        {
            public string Brand = "Mercedes";

            public virtual void Example()
            {
                //Beispiel
            }
          
        }

        class Car : Vehicle
        {
            public string Model = "S-Klasse";

            public override void Example()
            {
                base.Example();
            }

        }

        public class Ex : System.Exception
        {
            public Ex(string message) : base(message)
            {

            }
        }
        // Vector benutzt
        public Vector VectorExample()
        {
            Vector vector1 = new Vector(20, 30);
            Double scalar1 = 75;
            Vector vectorResult = new Vector();

            // Multiply the vector by the scalar.
            // vectorResult is equal to (1500,2250)
            vectorResult = Vector.Multiply(scalar1, vector1);

            return vectorResult;

            Console.WriteLine(vectorResult);
            Console.ReadLine();
        }
        
        //Interface benutzt

        public interface TestInterface
        {
            void Donothing();
        }
    }
}
