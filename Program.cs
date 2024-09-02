using System;
using System.Collections.Generic;

class Traductor
{
    static void Main()
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>
        {
            { "tiempo", "time" },
            { "persona", "person" },
            { "año", "year" },
            { "camino", "way" }, // o "forma"
            { "día", "day" },
            { "cosa", "thing" },
            { "hombre", "man" },
            { "mundo", "world" },
            { "vida", "life" },
            { "mano", "hand" },
            { "parte", "part" },
            { "niño", "child" }, // o "niña"
            { "ojo", "eye" },
            { "mujer", "woman" },
            { "lugar", "place" },
            { "trabajo", "work" },
            { "semana", "week" },
            { "caso", "case" },
            { "punto", "point" }, // o "tema"
            { "gobierno", "government" },
            { "empresa", "company" }  // o "compañía"
        };

        int opcion;
        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario);
                    break;
                case 2:
                    AgregarPalabra(diccionario);
                    break;
                case 0:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    break;
            }
        } while (opcion != 0);
    }

    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese la frase: ");
        string frase = Console.ReadLine();
        string[] palabras = frase.ToLower().Split(' ');
        List<string> fraseTraducida = new List<string>();

        foreach (string palabra in palabras)
        {
            if (diccionario.ContainsKey(palabra))
            {
                fraseTraducida.Add(diccionario[palabra]);
            }
            else
            {
                fraseTraducida.Add(palabra);
            }
        }

        Console.WriteLine("Su frase traducida es: " + string.Join(" ", fraseTraducida));
    }

    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese la palabra en español: ");
        string palabraEspanol = Console.ReadLine().ToLower();
        Console.Write("Ingrese la traducción al inglés: ");
        string palabraIngles = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(palabraEspanol))
        {
            diccionario.Add(palabraEspanol, palabraIngles);
            Console.WriteLine("Palabra agregada con éxito.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}

/* Explicación del Código:
/Diccionario: Se inicializa un diccionario con las palabras base en español y su traducción al ingles.
Menú Principal: Permite al usuario elegir entre traducir una frase, agregar nuevas palabras o salir del programa.
Función TraducirFrase: Toma la frase del usuario, verifica cada palabra contra el diccionario y traduce las palabras conocidas,
incluidas las palabras que se ayan agregad previamente con la opcion agregar palabra.
Función AgregarPalabra: Permite al usuario añadir nuevas palabras al diccionario y ser usadas para traducir una frase.*/
