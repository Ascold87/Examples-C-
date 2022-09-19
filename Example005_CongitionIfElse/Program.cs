Console.Write("Назовись, смертный!!! - ");
string username = Console.ReadLine();

if(username.ToLower() == "ascold")
{
    Console.WriteLine("Приветствую тебя, мой лорд!!!");
}
else
{
    Console.Write("Что привело тебя сюда, ");
    Console.Write(username);
    Console.WriteLine(" ?");
}