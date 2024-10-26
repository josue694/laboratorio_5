using Calc_Geometrica;
using figuras_geometricas;

int opcion;

Console.WriteLine("Calculadora Geométrica, seleccione una opción: ");
Console.WriteLine("1. Circulos");
Console.WriteLine("2. Cuadrados/Rectangulos");
Console.WriteLine("3. Triángulos");
Console.WriteLine("4. Elipses");

opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Por favor ingrese el radio del circulo:");
        double radio = Convert.ToDouble(Console.ReadLine());
        Circulos circulo1 = new Circulos(radio);
        Console.WriteLine("El área del circulo es: " + circulo1.CalcularArea());
        break;

    case 2:
        Console.WriteLine("Por favor ingrese la base del cuadrado: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura: ");
        double h = Convert.ToDouble(Console.ReadLine());
        Cuadrado cuadrado1 = new Cuadrado(b, h);
        Console.WriteLine("El área del cuadrado es: " + cuadrado1.CalcularArea());
        break;

    case 3:
        Console.WriteLine("Por ingresa la altura del triángulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa la base del triángulo: ");
        double base_triangulo = Convert.ToDouble(Console.ReadLine());
        Triangulo triangulo1 = new Triangulo(altura, base_triangulo);
        Console.WriteLine("El área del triángulo es " + triangulo1.CalcularArea());
        break;

    case 4:
        Console.WriteLine("Por favor ingresa el radio menor del elipse: ");
        double radio_menor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Por favor ingrese el radio mayor del elipse: ");
        double radio_mayor = Convert.ToDouble(Console.ReadLine());
        Elipse elipse1 = new Elipse(radio_menor, radio_mayor); 
        Console.WriteLine("El área del elipse es " + elipse1.CalcularArea());
        break;

    default:
        Console.WriteLine("Opción no válida.");
        break;
}
