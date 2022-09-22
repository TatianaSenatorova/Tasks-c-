/*Написать программу масштабирования фигуры
```
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/

/*void ScaleCoordinates(string[] arr, int coefScale)
{
    /*for (int i = 0; i < arr.Length; i++)
    {
         string[] arr_1 = arr.Split('(', ',', ')');
         Console.WriteLine($"{arr_1}");
   /*}*/





Console.Write("Enter coordinates of figer: ");
string s = Console.ReadLine();
string[] arr = s.Split(' ','(', ',', ')');
for (int i = 0; i < arr.Length; i++)
Console.Write ($"{arr[i]}");
