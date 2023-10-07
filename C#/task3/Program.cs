Console.Write("Введиме меньшее число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введиме большее число: ");
int m = Convert.ToInt32(Console.ReadLine());

int acker(int n, int m){
    if (n == 0){
        return (m+1);
        }
    else if (m == 0){
        return acker((n-1), 1);
    }
    else {
        return acker((n-1), acker(n, (m - 1)));
    }
}

Console.WriteLine(acker(m, n));