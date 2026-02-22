Console.WriteLine("----------------------------------------------------");
Console.WriteLine("Sistema de clasificación de Prioridad Médica");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("Seleccione el tipo de atención");
Console.WriteLine("Emergencia(1) -- Consulta(2) --Pediatría(3) -- Traumatología(4)");
Console.Write("Opción: ");
if (!int.TryParse(Console.ReadLine(), out int tipoAtencion)) return;
int opcion = int.Parse(Console.ReadLine());

Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("Saturación de oxígeno (%): ");
int oxígeno = int.Parse(Console.ReadLine());

Console.Write("Temperatura (℃): ");
double temperatura = int.Parse(Console.ReadLine());

Console.Write("Preció sistólica: ");
int precion = int.Parse(Console.ReadLine());

Console.Write("Nivel de dolor (0-10)");
int dolor = int.Parse(Console.ReadLine());