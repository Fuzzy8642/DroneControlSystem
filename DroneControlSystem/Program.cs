using DroneControlSystem;
Console.WriteLine("=== Система управления БПЛА (версия 1.0) ===\n");
// Создание объекта дрона с помощью конструктора
Drone myDrone = new Drone("DJI Mini 3", 85);
// Вывод информации
myDrone.PrintInfo();
Console.WriteLine();
// Демонстрация работы условия и цикла
Console.Write("Введите команду (1 — взлёт, 0 — выход): ");
int command = int.Parse(Console.ReadLine());
while (command != 0)
{
    if (command == 1)
    {
        myDrone.TakeOff();
    }
    else
    {
        Console.WriteLine("Неизвестная команда.");
    }
    Console.Write("Введите команду (1 — взлёт, 0 — выход): ");
    command = int.Parse(Console.ReadLine());


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
    if (d.BatteryLevel < 20)
    {
        Console.WriteLine("Warning. Low battery lvl");
    }
}
Console.WriteLine("Программа завершена.");