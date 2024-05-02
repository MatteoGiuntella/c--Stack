// See https://aka.ms/new-console-template for more information

    
        Stack<string> parole = new Stack<string>(new string[] { "Ciao", "Mondo", "Come", "Stai" });
        string parolaRimossa = parole.Pop();

        Console.WriteLine("Stack aggiornato:");
        foreach (string parola in parole)
        {
            Console.WriteLine(parola);
        }
