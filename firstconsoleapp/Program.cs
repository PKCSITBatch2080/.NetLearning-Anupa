//case sensiive
using System;
//Numbers
byte age = 255;//0 to 256
byte dayOfWeek = 11; //camel case
byte DayOfWeek = 13; //pascal case

short b =29242;//greater than 256
int c = 323142353;//greater than 32000
long d =23214234535333222; //greater than int

float weight1 = 45.64f;
double weight2 = 45.64;
decimal weight = 45.64m;

//Text
char initial = 'd';
string name = "bfdbd jvnwiuvb";

bool isFemale =false;
DateTime date =DateTime.Now;

//nullable
bool? ismale = null;

Console.WriteLine(age);
Console.WriteLine(dayOfWeek);
Console.WriteLine(DayOfWeek);
Console.WriteLine(date);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
