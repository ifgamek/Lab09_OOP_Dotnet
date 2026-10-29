public class Inventory {


    public string Name;
    public int Massa;
    public string Use;
    public string Drop;

    public Inventory(string name, int massa){

        Name = name;
        Massa = massa;
        Use = "Использовать";
        Drop = "Выбросить";
    }
}