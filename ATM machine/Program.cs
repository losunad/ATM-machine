using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму для снятия: ");
        int amount = int.Parse(Console.ReadLine());
        
        
        if (amount > 150000)
        {
            Console.WriteLine("Банкомат не может выдать более 150 000 рублей!");
            return;
        }
        
        
        if (amount % 100 != 0)
        {
            Console.WriteLine("Невозможно выдать ровно эту сумму!");
            return;
        }
        
        int remaining = amount;
        
        
        int count5000 = remaining / 5000;
        remaining = remaining % 5000;
        
        int count2000 = remaining / 2000;
        remaining = remaining % 2000;
        
        int count1000 = remaining / 1000;
        remaining = remaining % 1000;
        
        int count500 = remaining / 500;
        remaining = remaining % 500;
        
        int count200 = remaining / 200;
        remaining = remaining % 200;
        
        int count100 = remaining / 100;
        
        // Проверка, что вся сумма была разменяна
        if (count100 * 100 + count200 * 200 + count500 * 500 + 
            count1000 * 1000 + count2000 * 2000 + count5000 * 5000 == amount)
        {
            Console.WriteLine($"Сумма {amount} рублей выдана:");
            
            if (count5000 > 0) Console.WriteLine($"{count5000} по 5000 рублей");
            if (count2000 > 0) Console.WriteLine($"{count2000} по 2000 рублей");
            if (count1000 > 0) Console.WriteLine($"{count1000} по 1000 рублей");
            if (count500 > 0) Console.WriteLine($"{count500} по 500 рублей");
            if (count200 > 0) Console.WriteLine($"{count200} по 200 рублей");
            if (count100 > 0) Console.WriteLine($"{count100} по 100 рублей");
        }
        else
        {
            Console.WriteLine("Невозможно выдать ровно эту сумму!");
        }
    }
}