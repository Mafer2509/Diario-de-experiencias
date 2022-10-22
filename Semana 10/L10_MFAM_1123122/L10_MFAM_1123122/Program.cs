// See https://aka.ms/new-console-template for more information

using L10_MFAM_1123122;


Triangulorectangulo triangulo = new Triangulorectangulo();
Console.Write("Ingrese el cateto A: ");
triangulo.catetoA = double.Parse(Console.ReadLine());

Console.Write("Ingrese el Angulo Opuesto a A: ");
triangulo.anguloOpuestoA = double.Parse(Console.ReadLine());

Console.WriteLine("Cateto B: " + triangulo.ObtenerCatetoB());
Console.WriteLine("Hipotenusa: " + triangulo.ObtenerHipotenusa());
Console.WriteLine("Angulo opuesto a B: " + triangulo.ObtenerAnguloOpuesto());
Console.WriteLine("Area del triangulo: " + triangulo.ObtenerArea());
