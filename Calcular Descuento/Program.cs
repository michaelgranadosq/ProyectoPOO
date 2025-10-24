using System;

class ProgramaDescuento
{
    static void Main()
    {
        Console.Write("Ingrese el valor de la compra en colones: ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());
        double descuento = 0;

        if (valorCompra >= 200000 && valorCompra <= 500000)
        {
            descuento = valorCompra * 0.10;
        }
        else if (valorCompra > 500000)
        {
            descuento = valorCompra * 0.15;
        }

        double totalFinal = valorCompra - descuento;

        Console.WriteLine($"Descuento aplicado: ₡{descuento:N2}");
        Console.WriteLine($"Total a pagar: ₡{totalFinal:N2}");
    }
}
