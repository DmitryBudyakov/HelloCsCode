// задача поиска максимума из 9 гирь
// традиционный способ
Console.Clear();
int a1 = 15;
int b1 = 25;
int c1 = 5;
int a2 = 10;
int b2 = 14;
int c2 = 50;
int a3 = 311;
int b3 = 24;
int c3 = 13;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);