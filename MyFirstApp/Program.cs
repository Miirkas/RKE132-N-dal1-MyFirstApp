// See on kommentaar minu koodile

//rakendus küsib kasutajalt sisestada oma nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Sistesta oma nimi:"); //Output
//string - sõne
string kasutajaNimi = Console.ReadLine(); //Input


Console.WriteLine("Tere" +", " +  kasutajaNimi + "!"); //Output
//string interpolation

Console.WriteLine($"Tere, {kasutajaNimi}!"); //Output


