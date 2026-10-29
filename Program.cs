
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
