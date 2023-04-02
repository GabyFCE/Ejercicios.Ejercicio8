

while (true)
{
    Console.WriteLine("Quiere ingresar una frase? s/n");
    string resp = Console.ReadLine();
    if (resp == "s")
    {
        Console.WriteLine("Ingresa la frase!");
        string frase = Console.ReadLine();
        if (frase.Contains("fin"))
        {
            Console.WriteLine("la frase contiene 'fin'");
            continue;
        }
        else
        {
            Console.WriteLine("la frase no contiene 'fin'");
            continue;
        }

    }
    else if( resp == "n")
    {
        Console.WriteLine("Saliendo del programa...");
        break;
    }
    else
    {
        Console.WriteLine("Ingreso incorrecto. Ingrese 's' o 'n'.");
        continue;
    }
}

