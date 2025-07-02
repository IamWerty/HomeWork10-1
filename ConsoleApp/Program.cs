using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть ім’я та прізвище (через пробіл): ");
string userName = Console.ReadLine();
#region 1 спосіб, Split
/*
string[] parts = userName.Split(' ');

if (parts.Length >= 2)
{
    string firstName = parts[0];
    string lastName = parts[1];

    if (char.ToLower(firstName[0]) == char.ToLower(lastName[0]))
    {
        Console.WriteLine("Прізвище і ім'я починаються на одну літеру");
    }
    else
    {
        Console.WriteLine("Прізвище і ім'я не починаються на одну літеру");
    }
}
else
{
    Console.WriteLine("Будь ласка, введіть ім’я і прізвище через пробіл");
}
*/
#endregion

#region 2 спосіб, IndexOf

int spaceIndex = userName.IndexOf(' ');
if (spaceIndex != -1)
{
    if (userName[0] == userName[spaceIndex + 1])
    {
        Console.WriteLine("Прізвище і ім'я починаються на одну літеру");
    }
    else
    {
        Console.WriteLine("Прізвище і ім'я не починаються на одну літеру");
    }
}
else
{
    Console.WriteLine("Будь ласка, введіть ім’я і прізвище через пробіл");
}
#endregion