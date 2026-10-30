
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










Inventory yaroslav_1 = new Inventory("щит", 60);
Inventory anastasia_1 = new Inventory("стрела", 15);
Inventory artem_1 = new Inventory("зелье", 20);

Console.WriteLine();

Console.WriteLine(">>> Герой <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Инвентарь: {yaroslav_1.Name}");
Console.WriteLine($"{yaroslav_1.Use}");
Console.WriteLine($"{yaroslav_1.Drop}");


Console.WriteLine();

Console.WriteLine(">>> Герой <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Инвентарь: {anastasia_1.Name}");
Console.WriteLine($"{anastasia_1.Use}");
Console.WriteLine($"{anastasia_1.Drop}");


Console.WriteLine();

Console.WriteLine(">>> Герой <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Инвентарь: {artem_1.Name}");
Console.WriteLine($"{artem_1.Use}");
Console.WriteLine($"{artem_1.Drop}");


Console.WriteLine();