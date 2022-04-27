using System;

namespace TP1
{
    public class Program
    {
        const int LIMITE = 10;
        static int exponente;
        static double resultadoExponente;
        static bool continua;

        static void Main(string[] args)
        {
            do
            {
                Inicio();
                Calculo();
                Resultado();
                EvaluarSalida();
            } while (continua);
        }
        private static void Inicio()
        {
            bool ingreso = true;
            do
            {
                MensajeInicial();
                Console.WriteLine("Ingrese un valor entero del exponente del numero e: ");
                exponente = IngresaValorInt();
                if (exponente > 0)
                    ingreso = false;
            } while (ingreso);
        }
        private static void Calculo()
        {
            double exp;
            int fact;
            resultadoExponente = 1;
            for (int i = 1; i <= LIMITE; ++i)
            {
                exp = Math.Pow(exponente, i);
                fact = ObtenerFactorial(i);
                resultadoExponente += (exp / fact);
            }
        }
        private static void Resultado()
        {
            MensajeInicial();
            Console.WriteLine("Exponente ingresado: {0}, limite de iteraciones: {1} ", exponente, LIMITE);
            Console.WriteLine("Resultado de la funcion: {0}", resultadoExponente);
        }
        private static void EvaluarSalida()
        {
            Console.WriteLine();
            Console.WriteLine("Desea continuar calculando valores para la funcion? (S/N)");
            continua = IngresaValorBool();
        }
        private static void MensajeInicial()
        {
            Console.Clear();
            Console.WriteLine("TP1 - VALLES MARTIN");
            Console.WriteLine("Programa de calculo de funcion exponencial");
            Console.WriteLine();
        }
        private static int IngresaValorInt()
        {
            return int.Parse(Console.ReadLine());
        }
        private static bool IngresaValorBool()
        {
            string c;
            do
            {
                c = Console.ReadLine();
            } while (c != "S" && c != "s" && c != "N" && c != "n");

            if (c == "S" || c == "s")
                return true;
            else
                return false;
        }

        private static int ObtenerFactorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
