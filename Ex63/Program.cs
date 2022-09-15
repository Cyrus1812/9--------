Console.WriteLine("Введите число: ");
bool line = int.TryParse(Console.ReadLine(), out int a);
// Console.WriteLine("Введите количество строк в массиве: ");
// bool column = int.TryParse(Console.ReadLine(), out int n);

if (!line || a < 1 )
{
    Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
}

int[] newArray = new int[a]; 
newArray = Recursive(a,0,1,newArray);
PrintArray(newArray);
int[] Recursive(int a , int i,int m ,int[]array )
{
    if (i>a-1)
    {
        return array;
    }
     array[i] = m;
    Recursive(a,i+1,m+1, array);
    return  array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}
