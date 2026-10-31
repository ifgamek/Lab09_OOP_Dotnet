
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артем", 120);


Console.WriteLine($"До вызова : {yaroslav.Health}, {anastasia.Health} , {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"\nПосле вызова {yaroslav.Health}, {anastasia.Health} , {artem.Health}");


yaroslav.TakeDamage(-20);
Console.WriteLine($"\nПосле неверного урона : {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артем :{artem.Health}");

yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);


Console.WriteLine($"\nПосле лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослав : {yaroslav.Experience}");


bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"\nЯрослав жив {yaroslavAlive}");
Console.WriteLine($"Анастасия жива {anastasia.IsAlive()}");
Console.WriteLine($"Артем жив {artem.IsAlive()}");


if (yaroslavAlive) {
    Console.WriteLine("\nЯрослав может продолжать приключение");
}
else {
    Console.WriteLine("Ярослав больше не может сражаться");
}



string info = yaroslav.GetInfo();
Console.WriteLine("\n \n Строка получена. Сейчас выведем ее:");
// Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());



Console.WriteLine("\n \n \n");




Inventory yar_inv = new Inventory("доспех", 1);
Inventory ana_inv = new Inventory("еда", 5);
Inventory art_inv = new Inventory("камень", 8);

yar_inv.Plus_i(1);
ana_inv.Plus_i(-2);
art_inv.Plus_i(3);


Console.WriteLine($"\n\n\n Яр имеет у себя в инвентаре данное кол-во {yar_inv.Name} {yar_inv.Count}");
Console.WriteLine($"Анастасия имеет у себя в инвентаре данное кол-во {ana_inv.Name} {ana_inv.Count}");
Console.WriteLine($"Артем имеет у себя в инвентаре данное кол-во {art_inv.Name} {art_inv.Count}");

yar_inv.Drop(1);
Console.WriteLine($"\n Ярослав выбросил предмет {yar_inv.Name} и у него теперь в инвентаре  {yar_inv.Count } данного предмета");


Console.WriteLine($"\n{yaroslav.Name}: {yar_inv.INFO_i()}");
Console.WriteLine($"{anastasia.Name}: {ana_inv.INFO_i()}");
Console.WriteLine($"{artem.Name}: {art_inv.INFO_i()}");