using System.Collections.Generic;
using System.Linq;
using System.Web;

using System;

namespace WeBcalculadora
{
    public class ClsOperacion
    {
        public static float valor1 { get; set; }
        public static float valor2 { get; set; }

        // Banderas para identificar la operación seleccionada
        public static bool sumar = false;
        public static bool restar = false;
        public static bool multiplicar = false;
        public static bool dividir = false;
        public static bool factorial = false;
        public static bool exponente2 = false;
        public static bool exponente3 = false;
        public static bool raiz = false;
        public static bool fibonacci = false;

        // MÉTODOS BÁSICOS
        public static float metodo_sumar(float v1, float v2)
        {
            return v1 + v2;
        }

        public static float metodo_restar(float v1, float v2)
        {
            return v1 - v2;
        }

        public static float metodo_multiplicar(float v1, float v2)
        {
            return v1 * v2;
        }

        public static float metodo_dividir(float v1, float v2)
        {
            return v1 / v2;
        }


        // 🔹 POTENCIA A LA 2
        public static float metodo_exponente2(float v1)
        {
            return v1 * v1;
        }

        // 🔹 POTENCIA A LA 3
        public static float metodo_exponente3(float v1)
        {
            return v1 * v1 * v1;
        }

        // 🔹 RAÍZ CUADRADA
        public static float metodo_raiz(float v1)
        {
            return (float)Math.Sqrt(v1);
        }

        // 🔹 FACTORIAL
        public static float metodo_factorial(float n)
        {
            int num = (int)n;
            int resultado = 1;

            for (int i = 1; i <= num; i++)
                resultado *= i;

            return resultado;
        }

        // 🔹 FIBONACCI
        public static float metodo_fibonacci(float n)
        {
            int num = (int)n;

            if (num <= 0) return 0;
            if (num == 1) return 1;

            int a = 0, b = 1, c = 0;

            for (int i = 2; i <= num; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }

        // 🔹 LIMPIAR TODO
        public static void limpiar()
        {
            valor1 = 0;
            valor2 = 0;

            sumar = false;
            restar = false;
            multiplicar = false;
            dividir = false;
            factorial = false;
            exponente2 = false;
            exponente3 = false;
            raiz = false;
            fibonacci = false;
        }
    }
}

