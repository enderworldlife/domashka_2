// zadanye 1

// Console.Write("Vvedite chsilo: ");
// int number = Convert.ToInt32(Console.ReadLine());
// bool numberdeleniyena7 = false;
// bool numberdeleniyena23 = false;
// if (number % 7 == 0) numberdeleniyena7 = true;
// if (number % 23 == 0) numberdeleniyena23 = true;
// if (numberdeleniyena7 == false && numberdeleniyena23 == false) Console.WriteLine("Chsilo ne kratno");
// else if (numberdeleniyena7 == true) Console.WriteLine("Chislo kratno tolko na 7");
// else if (numberdeleniyena23 == true) Console.WriteLine("Chislo kratno tolko na 23");
// else if (numberdeleniyena7 == true && numberdeleniyena23 == true) Console.WriteLine("Chislo kratno na 7 i na 23");

// zadanye 2

// Простите пожалуйста. Я не смог решить эту задачу(

// zadanye 3

// Console.Write("Vvedite chsilo: ");
// int number = Convert.ToInt32(Console.ReadLine());
using System.Diagnostics;
using System.Globalization;
using System.Security.Principal;

// Console.Write("Vvedite chsilo: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int n = num;

// while(n > 0){
    
//     n /= 10;
//     i++;
// }
// Console.Write("Vvedeno chislo: ");
// Console.WriteLine(num);
// Console.Write("Kolichestvo tsifer: ");
// Console.WriteLine(i);
// Console.Write("Tsifry: ");

// int max = 0;
// while(i > 0){
//     int last = num % 10;
//     if (max < last) max = last;
//     num /= 10;
//     Console.Write(last + ", ");
//     i--;
// }
// Console.WriteLine(" ");
// Console.Write("Maksimalnaya tsifra: ");
// Console.WriteLine(max);

// zadanye 4

Console.Write("Vvedite chsilo: ");
int num = Convert.ToInt32(Console.ReadLine());

string print = string.Empty;
while(num > 0){
    int last = num % 10;
    num /= 10;
    print = last + ", " + print;
}
Console.WriteLine(print);



