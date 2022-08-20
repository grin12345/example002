Console.WriteLine("input number");
string numberStr;
numberStr = Console.ReadLine();
int n = int.Parse(numberStr);
int a = n* (-1);
while (a<=n)
{
    Console.WriteLine (a);
    a=a+1;
    }
