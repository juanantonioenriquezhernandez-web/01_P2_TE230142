Console.WriteLine("SISTEMA DE EVALUACIÓN DE CONSUMO ELÉCTRICO DE MOTOR DC");
Console.WriteLine();

MotorDC motor1 = new MotorDC();// se toma MotorDC como una clase para  crear el objeto motor1

Console.Write("Ingrese el identificador del motor: ");// Se solicita al usuario que ingrese un identificador para el motor
motor1.Identificador = Console.ReadLine() ?? "Sin ID";

Console.Write("Ingrese el voltaje de alimentación (V): ");// Se solicita al usuario que ingrese el voltaje de alimentación del motor
motor1.Voltaje = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente consumida (A): ");// Se solicita al usuario que ingrese la corriente consumida por el motor
motor1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Identificador del motor: {motor1.Identificador}");// Muestra el identificador del motor
Console.WriteLine($"Potencia eléctrica: {motor1.CalcularPotencia():F2} W");// Muestra la potencia eléctrica calculada
Console.WriteLine($"Estado: {motor1.ObtenerEstadoConsumo()}");// Muestra el estado del consumo eléctrico del motor

class MotorDC // Clase que representa un motor de corriente continua (DC)
{
    public string Identificador { get; set; } = "";// Propiedad para el identificador del motor
    public double Voltaje { get; set; }
    public double Corriente { get; set; }// Propiedad para la corriente en amperes

    public double CalcularPotencia() => Voltaje * Corriente;// Método que calcula la potencia eléctrica del motor en vatios (W)

    public string ObtenerEstadoConsumo()// Método que determina el estado del consumo eléctrico del motor
    {
        double potencia = CalcularPotencia();
        if (potencia <= 120)
            return "Consumo normal (menor o igual a 120 W)";// Si la potencia es menor o igual a 120 W, se considera consumo normal
        else
            return "Consumo elevado (mayor a 120 W)";// Si la potencia es mayor a 120 W, se considera consumo elevado
    }
}
