Console.WriteLine("Task 1");
int[] numbers = { 3, 7, 2, 9, 5, 1 };
int sum = 0;
foreach (int num in numbers)
{
    sum += num;
}
Console.WriteLine("Sum = " + sum);


Console.WriteLine("Task 2 part 1");
int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
Array.Sort(temps);
int min = temps[0];
int max = temps[temps.Length - 1];
Console.WriteLine("Min = " + min + ", Max = " + max);

Console.WriteLine("Task 2 part 2");
int[] tempx = { 12, -3, 45, 0, 28, -10, 33 };
int ooo = tempx[0];
int iii = tempx[0];
foreach (int temp in tempx)
  {
      min = Math.Min(ooo, temp);
      max = Math.Max(iii, temp);
  }
Console.WriteLine("Min = " + ooo + ", Max = " + iii);


Console.WriteLine("Task 3");
string[] words = { "apple", "banana", "cherry", "date" };
for (int i = 0; i < words.Length / 2; i++)
{
    string temp = words[i];
    words[i] = words[words.Length - 1 - i];
    words[words.Length - 1 - i] = temp;
}
Console.WriteLine(string.Join(" ", words));

Console.WriteLine("Task 3 part 2");
string[] wordx = { "apple", "banana", "cherry", "date" };
Array.Reverse(wordx);
Console.WriteLine(string.Join(" ", wordx));

Console.WriteLine("tas 4");
int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };
int evenCount = 0;
int oddCount = 0;
for (int i = 0; i < data.Length; i++)
{
    if (data[i] % 2 == 0)
    {
        evenCount++;
    }
    else
    {
        oddCount++;
    }
}
Console.WriteLine($"Even = {evenCount}, Odd = {oddCount}");

Console.WriteLine("Task 5");
int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };
List<int> unique = new List<int>();
for (int i = 0; i < raw.Length; i++)
{
    if (Array.IndexOf(raw, raw[i]) == i)
    {
        unique.Add(raw[i]);
    }
}
Console.WriteLine(string.Join(" ", unique));

Console.WriteLine("Task 6");
int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int k = 3;
int[] result = RotateLeft(arr, k);
foreach (int n in result)
{
    Console.Write(n + " ");
}
static int[] RotateLeft(int[] arr, int k)
{
    int n = arr.Length;
    k = k % n;
    int[] newArr = new int[n];
    int index = 0;
    for (int i = k; i < n; i++)
    {
        newArr[index++] = arr[i];
    }
    for (int i = 0; i < k; i++)
    {
        newArr[index++] = arr[i];
    }

    return newArr;
}








