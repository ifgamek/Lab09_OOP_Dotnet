public class Inventory {

    public string Name;
    public int Count;

    public Inventory(string name, int count) {
        Name = name;
        Count = count;
    }

    public void Plus_i(int plus) {
        if (plus <= 0) { return; }

        Count += plus;
    }

    public void Drop(int drop) {
        if (drop <= 0) { return; }

        Count -= drop;
    }

    public string INFO_i() {
        return $"у данного персонажа {Count} {Name}";
    }
}