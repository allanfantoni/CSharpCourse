using Shapes.Entities;
using Shapes.Entities.Enums;

try
{
    List<Shape> list = new List<Shape>();

    Console.Write("Enter the number of shapes: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"Shape #{i} data:");
        Console.Write("Rectangle or Circle (r/c)? ");
        char ch = char.Parse(Console.ReadLine());
        Console.Write("Color (Black/Blue/Red): ");
        Color color = Enum.Parse<Color>(Console.ReadLine());

        if (ch == 'r' || ch == 'R')
        {
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            list.Add(new Rectangle(color, width, height));
        }
        else
        {
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            list.Add(new Circle(color, radius));
        }
    }

    Console.WriteLine();
    Console.WriteLine("SHAPE AREAS:");

    foreach (Shape shape in list)
    {
        Console.WriteLine(shape.Area().ToString("F2"));
    }
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}