
int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}

string [] Create_mass ()
{
    string [] rand_mass= {"try","pass","do","why","house"};
    return rand_mass;
}

void PrintMass(string [] mass)
{
    Console.WriteLine($"Nach_mass: [{string.Join(",",mass)}]");
}

string[] Checker(string [] mass)
{
    string [] end_mass= new string[mass.Length];
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length<=3)
        {
            end_mass[i]=mass[i];
        }
    }
    return end_mass;
}

string [] d_mass = Create_mass();
PrintMass(d_mass);

string[] result = Checker(d_mass);
PrintMass(result);
