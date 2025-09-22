using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        
        // Vòng lặp từ 1 đến 10
        for (int i = 1; i <= 10; i++)
        {
            sum += i; // Cộng dồn vào biến sum
        }
        
        // In ra kết quả tổng
        Console.WriteLine("Tổng của các số từ 1 đến 10 là: " + sum);
    }
}
