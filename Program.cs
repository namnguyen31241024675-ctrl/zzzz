using System;

class Program
{
    static void Main()
    {
        int number;
        
        // Nhập số từ người dùng
        Console.Write("Nhập một số: ");
        number = int.Parse(Console.ReadLine());
        
        // Kiểm tra số chẵn hay lẻ
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " là số chẵn.");
        }
        else
        {
            Console.WriteLine(number + " là số lẻ.");
        }
    }
}
