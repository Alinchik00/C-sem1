Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int M = N * (-1);

if (N<0)
{
    int temp = N;
    N = M;
    M = temp;
}
while(M<=N)
{
    Console.WriteLine(M + " ");
    M++;
}