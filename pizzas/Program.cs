
# Preguntar al usuario por la renta
renta = float(input("¿Cuál es tu renta anual? "));
# Condicional para determinar el tipo impositivo dependiendo de la renta
if renta < 10000:
    tipo = 5
elif renta < 20000:
    tipo = 10
elif renta < 35000:
    tipo = 15
elif renta < 60000:
    tipo = 20
else:
    tipo = 30;
# Mostrar por pantalla el producto de la renta por el tipo impositivo
Console.WriteLine("Tienes que pagar ", renta * tipo / 100, "$", sep='')