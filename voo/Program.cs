Voo v = new Voo(01, new DateTime(2023, 02, 18));

for(int i = 0; i < v.cadeiras.Length; i++)
{
    if (v.cadeiras[i] == true)
    {
        Console.WriteLine(v.cadeiras[i] + "esta cadeira está ocupada");
    }
    else
    {
        Console.WriteLine("Esta cadeira está dispolivel");
    }
}
