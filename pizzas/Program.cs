using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int opcPizza;
        int opcIngrediente;
        String pizza = "";
        String ingrediente = "";
        Console.WriteLine ("Bienvenido a Pizzas el Fercho");
        Console.WriteLine ("Digite la pizza: \n1.Vegetariana \n2.No vegetariana");
        opcPizza = int.Parse(Console.ReadLine());
        switch(opcPizza){
            case 1:
                pizza = "Vegetariana";
                Console.WriteLine ("Seleccione Ingrediente: \n1.Pimiento \n2.Champinones");
                opcIngrediente = int.Parse(Console.ReadLine());
                switch(opcIngrediente){
                    case 1:
                        ingrediente = "Pimiendo";
                        break;
                    case 2:
                        ingrediente = "Champinones";
                        break;
                }
                break;
            case 2:
                pizza = "No vegetariana";
                Console.WriteLine ("Seleccione Ingrediente: \n1.Pepperoni \n2.Salami \n3.Pollo");
                opcIngrediente = int.Parse(Console.ReadLine());
                switch(opcIngrediente){
                    case 1:
                        ingrediente = "Pepperoni";
                        break;
                    case 2:
                        ingrediente = "Salami";
                        break;
                    case 3:
                        ingrediente = "Pollo";
                        break;
                }
                break;
        }
        
       Console.WriteLine ("Informacion Pizza: \nTipo: " + pizza + " \nIngredientes: Tomate, Mozarella, " + ingrediente);
        
 
        
        
        
    }
}






