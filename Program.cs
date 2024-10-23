using Calc;

int[] arr1 = new int[6];
int [] arr2 = new int[6];
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = i * 3 - 2 + 6;
    arr2[i] = i * 8 + 3/3;
    Console.Write($"\n {arr1[i]} {arr2[i]}");
    Console.WriteLine();
   
}

MyCalc mc = new MyCalc();
Console.Write($"\n{mc.FindMin(arr2)}");
Console.Write($"\n{mc.FindMax(arr2)}");
Console.WriteLine();
Console.Write($"\n{mc.FindMin(arr1)}");
Console.Write($"\n {mc.FindMax(arr1)}");