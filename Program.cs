using System;

class Program
{
    static void Main()
    {
        // Khai báo biến
        string name;
        
        // Nhập tên từ người dùng
        Console.Write("Nhập tên của bạn: ");
        name = Console.ReadLine();
        
        // In ra tên đã nhập
        Console.WriteLine("Chào " + name + "!");
    }
}
