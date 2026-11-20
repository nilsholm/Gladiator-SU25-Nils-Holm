internal class Program
{
    class Player
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public HeavyWeapon HeavyWeapon { get; set; }
        public LightWeapon LightWeapon { get; set; }
        public Armour Armour { get; set; }
        public Shield Shield { get; set; }
    }
    class HeavyWeapon
    { 
        public int maxDamage { get; set; }
        public int minDamage { get; set; }
        public int minHitChance { get; set; }
        public int maxHitChance { get; set; }
    }
    class LightWeapon
    {
        public int maxDamage { get; set; }
        public int minDamage { get; set; }
        public int minHitChance { get; set; }
        public int maxHitChance { get; set; }
    }
    class Armour
    {
        
    }
    class Shield
    {

    }
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("========" +
            "Gladiator" +
            "========");
        Console.WriteLine("\nPress any button to continue");
        Console.ReadKey();
        // LÄGG TILL KARAKTÄRVAL OCH SEDAN VAPEN OCH ETC

        Combat();
    }
    public static void Combat ()
    {
        while (true)
        {
            Player1Turn();
            Player2Turn();
        }
    }
    public static void Player1Turn ()
    {
        ChooseAction();
    }
    public static void Player2Turn ()
    {
        ChooseAction();
    }
    public static void BotTurn()
    {

    }
    public static void ChooseAction()
    {

    }
}