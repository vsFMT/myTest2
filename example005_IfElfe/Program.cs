Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();

//if(userName == "Маша")// В данной задаче есть проблема с вводом (имеется некоторое количество вариантов написания имени)
// Но эта проблема решается командой .ToLower() переводящей все символы нашей строки в нижний регистр
if(userName.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}