string [] array = {"Hello", "Hi", "323233", "5434343", ":)", "Привет", "The", "End"};
int b = 0;

for(int i = 0; i < array.Length; i++)
{
int a = array[i].Length;

if (a <= 3)
{
    b++;
}
}
string [] array2 = new string [b]; 

b = 0;
for(int i = 0; i < array.Length; i++)
{
int a = array[i].Length;

if (a <= 3)
{
    array2[b] = array[i];
    b++;
}
}

Console.WriteLine($"[{string.Join(", ", array2)}]");