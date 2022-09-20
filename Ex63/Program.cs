Console.WriteLine("Введите число: ");
bool line = int.TryParse(Console.ReadLine(), out int m);


if (!line || m < 1 )
{
    Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
}

int[] newArray = new int[m]; 
newArray = Recursive(m,0,1,newArray);
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
