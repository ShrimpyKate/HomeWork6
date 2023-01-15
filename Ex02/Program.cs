// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//1.create points
(int x, int y) CreatePoint()
{
  Console.WriteLine("Введите значение первой точки прямой: ");
  int x = int.Parse(Console.ReadLine());
  Console.WriteLine("Введите значение второй прямой точки: ");
  int y = int.Parse(Console.ReadLine());
  return (x,y);
}
//3.
(int pointX, int pointY)GetCrossOfLines( int linePointB1, int linePointK1, int linePointB2, int linePointK2)
{

}










var pointsOfline1 = CreatePoint();
Console.WriteLine($"Координаты первой прямой:{pointsOfline1}");
var pointsOfline2 = CreatePoint();
Console.WriteLine($"Координаты второй прямой:{pointsOfline2}");
