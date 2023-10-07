int recurse_output(int n){
    if(n==0) return n;
    Console.WriteLine(n);
    return recurse_output(n-1);
}


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
recurse_output(n);
