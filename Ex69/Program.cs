// Console.WriteLine("Введите число: ");
// bool num1 = int.TryParse(Console.ReadLine(), out int a);
// Console.WriteLine("Введите число: ");
// bool num2 = int.TryParse(Console.ReadLine(), out int b);

// if (!num1 || !num2  )
// {
//     Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
// }
int a = 4;
int b = 10;
PrintResult(GetSum(a,b));
int GetSum(int a, int b,int i = 1)
{
    if(i<=b)
    {
    
    i++;
     return  a+ GetSum(a,b,i);
     
    }
   return a;
}

void PrintResult(int i)
{
    Console.WriteLine(i);
}