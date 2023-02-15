public class Meta
{
    public Dictionary<int, int> D2d { get; set; } = new Dictionary<int, int>();

    public int this[int i]
    {
        get { return D2d[i]; }
        set { D2d[i] = value; }
    }
}
