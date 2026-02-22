Console.WriteLine("=== Sistema de clasificación de Prioridad Médica ===");
Console.WriteLine("Seleccione el tipo de atención");
Console.WriteLine("Emergencia(1) -- Consulta(2) --Pediatría(3) -- Traumatología(4)");
Console.Write("Opción: ");

int opcion = int.Parse(Console.ReadLine());

Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("Saturación de oxígeno (%): ");
int oxigeno = int.Parse(Console.ReadLine());

Console.Write("Temperatura (℃): ");
double temperatura = int.Parse(Console.ReadLine());

Console.Write("Preció sistólica: ");
int precion = int.Parse(Console.ReadLine());

Console.Write("Nivel de dolor (0-10)");
int dolor = int.Parse(Console.ReadLine());

if (edad < 0 && edad > 120)
{
    Console.WriteLine("Error: edad fuera de rango");
    return;
}
else if (temperatura < 35 || temperatura > 45)
{
    Console.WriteLine("Error: temperatura corporal no compatible con la vida");
    return;
}
else if (oxigeno < 0 || oxigeno > 100)
{
    Console.WriteLine("Error: nivel de oxígeno inválido");
    return;
}
else if (dolor <0 && dolor > 10)
{
    Console.WriteLine("Error: el nivel de dolor tiene que se de 0-10");
    return;
}
else if (opcion < 1 && opcion > 4)
{
    Console.WriteLine("Error: opción no válida");
    return;
}
 switch (opcion)
{
    case 1:
        if (precion < 90)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("prioridad 1");
            Console.WriteLine("Reanimación e intervención inmediata");
            Console.WriteLine("----------------------------------------");

        }
        break;
}
