//Работа со строками, символами
//char, string, string Builder

//CHAR
char ch = 'q';
char p = '\n';
char d = (char)999;
Console.WriteLine(d);
int first = (int)'А';
int lasr = (int)'я';
for(int i=first; i<=lasr; i++)
{
    Console.WriteLine($"{i}-{(char)i}");
}
char А = 'A';
char Z = 'z';
for (int i = А; i <= Z; i++)
{
    Console.WriteLine($"{i}-{(char)i}");
}
for (int i = (int)'0'; i <= (int)'9'; i++)
{
    Console.WriteLine($"{i}-{(char)i}");
}
if (char.IsDigit('5')) Console.WriteLine("Цифра");
else Console.WriteLine("Не цифра");
if (char.IsLetter('A')) Console.WriteLine("Буква");
else Console.WriteLine("Не буква");
if (char.IsControl('\xA')) Console.WriteLine("Управляющий");
else Console.WriteLine("Не управляющий");
