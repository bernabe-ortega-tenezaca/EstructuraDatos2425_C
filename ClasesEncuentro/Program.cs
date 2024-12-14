while (true)
{
    Menu();
    string opcion = Console.ReadLine(); //Readline -- Lee desde teclado
    
    switch (opcion)
    {
        case "0":
            return;
        case "1":
            Console.WriteLine("At work - Tipos de datos básicos");
            break;
        case "2":
            Console.WriteLine("At work - POO encapsulamiento");
            break;
        case "3":
            Console.WriteLine("At work - Array y matrices");
            break;
        // case "4":
        //     Console.WriteLine("Men at work - .....");
        //     break;
        default:
            Console.WriteLine("Opción no válida, pulse una tecla para continuar");
            break;
    }
}






// Programa Principal
Encabezado();

Menu();

PiePagina();





/// Funciones
static void Menu(){ // Se debe actualizar cada semana
    Console.WriteLine("Seleccione una opción del menú");
    Console.WriteLine();
    Console.WriteLine("1 Tipos de datos básicos");
    Console.WriteLine("2 POO");
    Console.WriteLine("3 Array y Matrices");
    Console.WriteLine("------------------------------");
    //Console.WriteLine(new string('-', 30));
    Console.WriteLine("0 Salir");
}

static void Encabezado(){
    Console.Clear();
    Console.WriteLine("+++++++++++++++++++++++++++++++++");
    Console.WriteLine("+ Universidad Estatal Amazónica +");
    Console.WriteLine("+++++++++++++++++++++++++++++++++");
    Console.WriteLine();
}

static void PiePagina(){
    Console.WriteLine();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("  Programado por @El programador");
    Console.WriteLine(new string('=', 33)); // Genera una cadena con 33 signos igual
}