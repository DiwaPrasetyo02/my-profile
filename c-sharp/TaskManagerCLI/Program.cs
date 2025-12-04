// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("==========================");
// Tipe Variabel
int nilai = 80;
bool isNilai = false;
var angka = 10;

// Operator Matematika
int a = 10;
int b = 20;
int c = a + b;
int d = a * b;
int e = b / a;

// Buat PrinLN
Console.WriteLine(nilai);
Console.WriteLine(isNilai);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
bool hasil = a > b;
Console.WriteLine(hasil);

Console.WriteLine("==========================");
// buat IF
// cara memasukan nilai variabel nilai
if (nilai >= 75)
{
    Console.WriteLine("Selamat Anda Lulus");
}
else if (nilai <75 && nilai >=60)
{
    Console.WriteLine("Nilai Anda Cukup");
}
else
{
    Console.WriteLine("Maaf Anda Tidak Lulus");
}
Console.WriteLine("==========================");

// buat LOOPING
var n = 0;
while (n < 5)
{
    Console.WriteLine("Perulangan ke-" + n);
    n++;
}
Console.WriteLine("==========================");
// membuat list
string[] nama = { "diwa", "prasetyo", "Diwa", "Paradaya" };
foreach(var name in nama)
{
    Console.WriteLine("Nama: " + name);
}

// Switch Case
Console.WriteLine("==========================");
var day = "Mon";
switch (day)
{
    case "Mon": Console.WriteLine("Start"); break;
    case "Fri": Console.WriteLine("ayoo liburr"); break;
    default: Console.WriteLine("midWeek"); break;
}

Console.WriteLine("==========================");

// FizzBuzz
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

// Functions
Console.WriteLine("==========================");
static int Add(int a, int b)
{
    return a + b;
}

int result = Add(10, 20);
Console.WriteLine("Hasil Penjumlahan: " + result);
Console.WriteLine("==========================");

// Class dan Object


