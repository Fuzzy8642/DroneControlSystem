using DroneControlSystem;
using System.Globalization;
Console.WriteLine("=== Система управления БПЛА (версия 2.0) ===");
// Создание объекта дрона с помощью конструктора
Drone myDrone = new Drone("DJI Mini 3", 85);
// Вывод информации
myDrone.PrintInfo();
Console.WriteLine();
// Демонстрация работы условия и цикла
bool tempr = true;
string input="";
while (tempr == true)
{
    Console.WriteLine("Введите число");
    Console.Write("Введите команду (1 — взлёт, 2 — расчёт времени, 0 — выход): ");
    input = Console.ReadLine();

    if (!int.TryParse(input, out int command))
    {
        tempr = false;
    }
    else Console.WriteLine("Введите число");
}

while (Convert.ToInt32(input)!= 0)
{
    if (Convert.ToInt32(input) == 1)
    {
        myDrone.TakeOff();
    }
    else
    {
        Console.WriteLine("Неизвестная команда.");
    }
    Console.Write("Введите команду (1 — взлёт, 0 — выход): ");
    int command = int.Parse(Console.ReadLine());


    if (myDrone.BatteryLevel < 50)
    {
        bool temp = true;
        while (temp == true)
        {
            Console.WriteLine("Заряд ниже половинуЮ зарядить? 1 - yes 2 - no");
            int inpu = Convert.ToInt32(Console.ReadLine());

            if (inpu == 1)
            {
                myDrone.ChargeBattery(myDrone.BatteryLevel);
                temp = false;
            }
            else if (inpu == 2)
            {
                temp = false;
            }
            else if (inpu != 1 && inpu != 2)
            {
                Console.WriteLine("Incorrect? try again");
            }
        }
    }
}


Drone[] drones = new Drone[]
{
new Drone("DJI Mini 3", 85),
new Drone("Autel EVO Lite", 45),
new Drone("Parrot Anafi", 15)
};

foreach (Drone d in drones)
{
    Console.WriteLine($"Model: {d.Model}");
    Console.WriteLine($"Battery: {d.BatteryLevel}");
    d.CalculateFlightTime();
    if (d.BatteryLevel < 20)
    {
        Console.WriteLine("Warning. Low battery lvl");
    }
}


Drone myScndDrone = new Drone("drone");
Console.WriteLine("Программа завершена.");