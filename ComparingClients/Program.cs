using ComparingClients.Entities;

Client a = new() 
{
    Name = "Maria",
    Email = "maria@gmail.com"
};

Client b = new()
{
    Name = "Alex",
    Email = "alex@gmail.com"
};

Console.WriteLine(a.Equals(b));
Console.WriteLine(a == b);
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());