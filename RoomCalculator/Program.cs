
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the length of the room: ");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of the room: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the room");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Height: {height}");

        double area = width * length;
        double perimeter = (length * 2) + (width * 2);
        double surfaceArea = 2 * length * height + 2 * width * height + 2 * length * width;
        double volume = width * length * height;

        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
        Console.WriteLine($"Volume: {volume}");
        Console.WriteLine($"Surface Area: {surfaceArea}");
        if(area >= 650)
        {
            Console.WriteLine("This is a large sized room");
        }else if (area < 650 && area > 250)
        {
            Console.WriteLine("This is a medium sized room");
        }
        else
        {
            Console.WriteLine("This is a small sized room");
        }
    }
}



