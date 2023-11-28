
Console.Write("Vvedite chsilo: ");
int number = Convert.ToInt32(Console.ReadLine());
bool numberdeleniyena7 = false;
bool numberdeleniyena23 = false;
if (number % 7 == 0) numberdeleniyena7 = true;
if (number % 23 == 0) numberdeleniyena23 = true;
if (numberdeleniyena7 == false && numberdeleniyena23 == false) Console.WriteLine("Chsilo ne kratno");
else if (numberdeleniyena7 == true) Console.WriteLine("Chislo kratno tolko na 7");
else if (numberdeleniyena23 == true) Console.WriteLine("Chislo kratno tolko na 23");
else if (numberdeleniyena7 == true && numberdeleniyena23 == true) Console.WriteLine("Chislo kratno na 7 i na 23");
