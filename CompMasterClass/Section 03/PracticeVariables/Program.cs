using System;
using System.Net.Security;

int age = 25;
Console.WriteLine(age);
float pi = 3.14f;
Console.WriteLine(pi);
double temperature = 36.6;
Console.WriteLine(temperature);
char dollar = '$';
Console.WriteLine(dollar);
string name = "Nixware Consulting";
Console.WriteLine(name);
byte variable_byte = 25;
Console.WriteLine(variable_byte);
sbyte SignedByteVariable = -30;
Console.WriteLine(SignedByteVariable);
short variable_short = 330;
Console.WriteLine(variable_short);
ushort variable_ushort = 20;
Console.WriteLine(variable_ushort);
long variable_long = 255;
Console.WriteLine(variable_long);

//Test result

//byte variable_byte = 50;
//Console.WriteLine("byte: " + variable_byte);
//sbyte signedByteVariable = -50;
//Console.WriteLine("sbyte: " + signedByteVariable);
//short variable_short = 500;
//Console.WriteLine("short: " + variable_short);
//ushort unsignedShortVariable = 200;
//Console.WriteLine("ushort: " + unsignedShortVariable);
//long variable_long = 5000;
//Console.WriteLine("long: " + variable_long);
//ulong variable_ulong = 2000000000000000000;
//Console.WriteLine("ulong: " + variable_ulong);

//char and strings

char uniCode = '\u0043';
Console.WriteLine(uniCode);
char ascii = (char)65;
Console.WriteLine(ascii);
string s1 = "hello";
string s2 = "world";
string s3 = "Program";
Console.WriteLine(s1);
Console.WriteLine(s2);  
Console.WriteLine(s3);

//Type Casting

int i = 123; double d;
d = i;
Console.WriteLine(d);
short s = 100;
int j;
j = s;
Console.WriteLine(j);
char c = 'A';
int k;
k = c;
Console.WriteLine(k);
int asciiCode = 65;
char ch = (char)asciiCode;
Console.WriteLine(ch);
float f = 3.14f;
int a;
a = (int)f;
Console.WriteLine(a);

//String Manipulation
int id = 10;
String coname = "Nixware";
Console.WriteLine("String Concatenation");
Console.WriteLine("Hello, my ID is" + id + " my company name is " + coname);
Console.WriteLine("String Composite");
Console.WriteLine("Hello, my ID is {0}, my company name is {1}", id, coname);
Console.WriteLine("String Interpolation");
Console.WriteLine($"Hello, my ID is {0}, my company name is {1}");

//public static void Main(string[] args)
//{
//    int employeeId = 20;
//    string companyName = "UTCLI";
//    Console.WriteLine("Hello, my employee ID is " + employeeId + " and my company name is " + companyName);
//    Cosole.WriteLine("Hello, my employee ID is {0} and my company name is {1}", employeeId, companyName);
//    Console.WritLine($"Hello, my employee ID is {employeeId} and my company name is {companyName}");
//}