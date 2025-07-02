# 🇮🇳 BharatTaxCLI‑FY25 (Made By sidhantMalik)

A C# console application to calculate Indian income tax (including 4% health & education cess) under the **New Tax Regime for Financial Year 2024–25**.

This project is built using only basic C# constructs like `Console.WriteLine`, `Console.ReadLine`, and `if` statements — making it ideal for beginners who want to understand decision-making in programming.

---

## 💡 Features

- Input annual salary directly via console
- Compute tax using latest FY 2024–25 slabs under the new regime
- Calculates additional 4% health & education cess
- Displays final tax payable in rupees
- Beginner-friendly code using only `if`, no loops or advanced syntax

---

## 🧮 Tax Slabs Used (FY 2024–25 - New Regime)

| Salary Range (₹)         | Tax Rate |
|--------------------------|----------|
| Up to 3,00,000           | 0%       |
| 3,00,001 – 6,00,000      | 5%       |
| 6,00,001 – 9,00,000      | 10%      |
| 9,00,001 – 12,00,000     | 15%      |
| 12,00,001 – 15,00,000    | 20%      |
| Above 15,00,000          | 30%      |

> Note: A 4% cess is added to the final calculated tax amount.

---

## 🖥 Sample Console Output

Your Salary is: 500000
Total Tax Payable (Including 4% cess): 10400


---

## 🚀 How to Run

1. Clone the repo:

```bash
git clone https://github.com/your-username/BharatTaxCLI-FY25.git
cd BharatTaxCLI-FY25


Open in terminal and run:
dotnet run

Make sure you have .NET SDK installed.
