int[] array = {15, 22, 34, 4, 81, 75, 62, 57, 81, 96};

int n = array.Length;
int find = 81;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index +1;
    index++;
}

