Console.Write("Введиме меньшее число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введиме большее число: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for(int i = m; i < (n+1); i++){
    sum += i;
}

Console.WriteLine($"сумма чисел от {m} до {n} равна {sum}");