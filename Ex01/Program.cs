//Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//For exsample
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4



//1.Ввести кол-во элементов массива
int GetArraySize()
{
  Console.WriteLine("Введите количество элементов массива: ");
  int size = Convert.ToInt32(Console.ReadLine());
  return size;
}

//2.Создать массив
int[] Array(int size)
{
  return new int[size];
}

//Наполнить массив из консоли пользователем и распечатать
//  void FillArrByUser(int[] arr,int size)
//  {
//    Console.WriteLine($"Введите {size} элементов массива: ");
//   for (int i = 0; i < arr.Length; i++)
//   {
//     arr[i]= int.Parse(Console.ReadLine());
//   }
//  }

//3.Наполнить массив случайным образом и распечатать
int[] FillArray(int[] arr)
{
  int index = 0;
  int lenght = arr.Length;
  while (index < lenght)
  {
    arr[index] = Random.Shared.Next(-10, 10);
    Console.Write($"{arr[index]} ");
    index++;
  }
  Console.WriteLine();
  return arr;
}

int FindPositiveCount(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0) count++;
  }
    return count;
  
}

void PrintCount(int count)
{
  Console.WriteLine($"Колличество положительных чисел в массиве: {count}");
}

int size = GetArraySize();
int[] arrNumber = Array(size);
//FillArrByUser(arrNumber,size);
FillArray(arrNumber);
int count=FindPositiveCount(arrNumber);
PrintCount(count);