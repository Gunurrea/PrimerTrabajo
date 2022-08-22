string nombre;
byte edad;
decimal descuento1 = 0;
decimal descuento2= 0;
var entrada = 15000;

//calculo descuento

descuento1 = Math.Round(Convert.ToDecimal(entrada * 0.05M), 2);
descuento2 = Math.Round(Convert.ToDecimal(entrada * 0.03M), 2);

//pedir datos
Console.WriteLine("Ingrese su nombre completo: ");
nombre=Console.ReadLine();

Console.WriteLine("Ingrese su edad: ");
edad=Convert.ToByte(Console.ReadLine());

//mostrar resultado


if (edad >0 && edad <= 4){
Console.WriteLine("Su nombre es: " + nombre);
Console.WriteLine("su edad es: " + edad);
Console.WriteLine("tiene entrada gratis" );
}

if (edad >4 && edad <= 18){

Console.WriteLine("Su nombre es: " + nombre);
Console.WriteLine("su edad es: " + edad);
Console.WriteLine("tiene un descuento en la entrada de: "+ descuento1 );
var total = entrada-descuento1;
Console.WriteLine("TOTAL A PAGAR:" + total);
}

if(edad > 18 ){
Console.WriteLine("Su nombre es: " + nombre);
Console.WriteLine("su edad es: " + edad);
Console.WriteLine("tiene un descuento en la entrada de: "+ descuento2 );
var total = entrada-descuento2;
Console.WriteLine("TOTAL A PAGAR:" + total);
}