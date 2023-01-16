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
// 3.
(double, double) GetCrossOfLines(double linePointB1, double linePointK1,
                     double linePointB2, double linePointK2)
{
  double pointOflineCrossX = (linePointB2 - linePointB1) / (linePointK1 - linePointK2);

  double pointOflineCrossY = ((linePointK1 * linePointB2) - (linePointK2 * linePointB1)) / (linePointK1 - linePointK2);


  return (pointOflineCrossX, pointOflineCrossY);
}

void PrintCord(double x, double y)
{
  Console.WriteLine($"Координаты пересечения линий: {x},{y}");
}


var pointsOfline1 = CreatePoint();

Console.WriteLine($"Координаты первой прямой:{pointsOfline1}");
double linePointB1 = (pointsOfline1.Item1);
double linePointK1 = (pointsOfline1.Item2);
var pointsOfline2 = CreatePoint();
double linePointB2 = (pointsOfline2.Item1);
double linePointK2 = (pointsOfline2.Item2);
Console.WriteLine($"Координаты второй прямой:{pointsOfline2}");
Console.WriteLine($"b1={linePointB1}  k1={(linePointK1)}  b2={(linePointB2-linePointB1)/(linePointK1-linePointK2)}   k2={linePointK2}");

(double pointOflineCrossX, double pointOflineCrossY) = GetCrossOfLines(linePointB1, linePointB2, linePointK1, linePointK2);

PrintCord(pointOflineCrossX, pointOflineCrossY);




