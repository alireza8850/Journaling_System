using App;

bool running = true;
Manager manager = new Manager();

//Login
Console.Clear();
Console.WriteLine("Welcome");
Console.WriteLine();
Console.WriteLine("Användarnamn: ");
string? username = Console.ReadLine();
Console.Clear();
Console.WriteLine();
Console.WriteLine("Lösenord: ");
string? password = Console.ReadLine();
Console.Clear();

bool ok = Login.TryLogin(username, password);
if (!ok)
{
    Console.WriteLine("Fel Inloggning...");
    return;
}

// Huvud Meny

while (running)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("*******Meny*********");
    Console.WriteLine("___________________");
    Console.WriteLine();
    Console.WriteLine("1. Skriv Ny Journal.");
    Console.WriteLine("2. Visa Journal.");
    Console.WriteLine("3. Statistik");
    Console.WriteLine("4. Sök");
    Console.WriteLine("0. Avsluta");
    Console.WriteLine();
    Console.WriteLine("___________________");
    Console.WriteLine();
    Console.WriteLine("Val: ");

    string? input = Console.ReadLine();

    switch (input)
    {
        case "1":
            manager.NewJournal();
            break;

        case "2":
            break;

        case "3":
            break;

        case "4":
            break;

        case "0":
            running = false;
            break;
    }
}



