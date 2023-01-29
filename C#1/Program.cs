string [] array = {"Hello", "Hi", "323233", "5434343", ":)", "Привет", "The", "End"};
int b = 0;

for(int i = 0; i < array.Length; i++)
{
int a = array[i].Length;

if (a <= 3)
{
    array[b] = array[i];
    b++;
}
}
Console.WriteLine($"[{string.Join(" ", array.OrderBy(x => b).Take(b))}]");
