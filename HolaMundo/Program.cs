// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, mundo!!!!");

string texto;
int dia = 5;

switch (dia)
{
    case 1:
        texto = "Lunes";
        break;
    case 2:
        texto = "Martes";
        break;
}


texto = dia switch
{
    1 => "Lunes",
    2 => "Martes",
    3 => "Miercoles",
    _ => "Error"
};

string[] diasSemana = { "Lunes", "MArtes", "miercoles" };

Console.WriteLine(diasSemana[dia-1]);

Console.WriteLine(texto);

