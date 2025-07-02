// Practice Question (Basic C#)
// Indian Income‑Tax Calculator (New Régime, FY 2024‑25)

// FOR USER INPUT: 

// Console.WriteLine("Enter your name:");
// string name = Console.ReadLine();
// Console.WriteLine("Enter your salary:");
// int salary = int.Parse(Console.ReadLine());
// Console.WriteLine($"Hello {name}, your salary is {salary}");

// EXAMPLE VALUES:

int salary = 500000;
Console.WriteLine($"Your Salary is: {salary}");
decimal tax = 0;

// New‑Regime Slabs (FY 2024‑25)
if (salary >= 1500000)
{
    tax = (decimal)(salary * 0.30);
}
if (salary >= 1200001 && salary < 1500000)
{
    tax = (decimal)(salary * 0.20);
}
if (salary >= 900001 && salary < 1200000)
{
    tax = (decimal)(salary * 0.20);
}
if (salary >= 600001 && salary < 900000)
{
    tax = (decimal)(salary * 0.20);
}
if (salary >= 300001 && salary < 600000)
{
    tax = (decimal)(salary * 0.20);
}
else
{
    tax = 0;
}

decimal cess = tax * 0.04m;
int totalTax = (int)(cess + tax);
Console.WriteLine($"Total Tax Payable (Including 4% cess): {totalTax}");