public class Program
{
    private static void Main(string[] args)
    {
        //42. Desarrolle un algoritmo donde almacene las ventas que obtuvo mensualmente un almacén durante el año 2023. Mostrar por pantalla cada mes con su respectiva venta en pesos y la suma total de ventas de dicho año.

        //Declaramos los nuevos arrays:
        string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        decimal[] sales = new decimal[12];

        decimal sum = 0;

        //Vamos a implementar métodos para trabajar un poco el POO:

        //Método almacenar ventas...
        StoreSales(months, sales);

        //Método calcular ventas total del año...
        sum = CalculateSalesPerYear(sales, sum);

        //Método para mostrar ventas...
        ShowSales(sales, months, sum);
    }

    private static void StoreSales(string[] months, decimal[] sales)
    {
        for (int i = 0; i < sales.Length; i++)
        {
            Console.WriteLine($"Ingrese las ventas del mes {months[i]}");
            sales[i] = Convert.ToDecimal(Console.ReadLine());
        }
    }

    private static decimal CalculateSalesPerYear(decimal[] sales, decimal sum)
    {
        for (int i = 0; i < sales.Length; i++)
        {
            sum += sales[i];
        }

        return sum;
    }

    private static void ShowSales(decimal[] sales, string[] months, decimal sum)
    {
        for (int i = 0;i < sales.Length; i++)
        {
            Console.WriteLine($"{months[i]}: {sales[i]:C2}");
        }

        Console.WriteLine($"Total = {sum:C2}");
    }
}