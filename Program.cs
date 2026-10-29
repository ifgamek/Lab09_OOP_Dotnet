
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артем", 120);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");


Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.level}");
Console.WriteLine($"Опыт: {artem.Experience}");



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