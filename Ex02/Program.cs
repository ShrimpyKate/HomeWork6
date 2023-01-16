// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//1.create points
(double x, double y) CreatePoint()
{
  Console.WriteLine("Введите значение первой точки прямой: ");
  double x = double.Parse(Console.ReadLine());
  Console.WriteLine("Введите значение второй прямой точки: ");
  double y = double.Parse(Console.ReadLine());
  return (x, y);
}
// 2. find cord of coross the linse
(double, double) GetCrossOfLines(double b1, double k1, double b2, double k2)
{
  double x = (b2 - b1) / (k1 - k2);
  double y = k1 * x + b1;
  return (x, y);
}
//5.Print 
void PrintCord(double x, double y)
{
  Console.WriteLine($"Координаты пересечения линий: {x},{y}");
}

(double x, double y) pointsOfline1 = CreatePoint();
Console.WriteLine($"Координаты первой прямой:{pointsOfline1}");
(double x, double y) pointsOfline2 = CreatePoint();
Console.WriteLine($"Координаты второй прямой:{pointsOfline2}");

(double x, double y) result = GetCrossOfLines(pointsOfline1.x, pointsOfline1.y, pointsOfline2.x, pointsOfline2.y);

PrintCord(result.x, result.y);


