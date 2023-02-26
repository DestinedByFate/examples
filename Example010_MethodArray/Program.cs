int[] array = { 25, 16, 31, 85, 48, 42, 16, 36, 48 };

int n = array.Length;
int find = 48;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}