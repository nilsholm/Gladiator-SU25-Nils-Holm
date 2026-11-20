using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

internal class Program
{
    class Player
    {
        public string name { get; set; }
        public string Description { get; set; }
        public int dex { get; set; }
        public int str { get; set; }
        public HeavyWeapon HeavyWeapon { get; set; }
        public LightWeapon LightWeapon { get; set; }
        public Armour Armour { get; set; }
        public Shield Shield { get; set; }
    }
    class HeavyWeapon
    {
        public string name { get; set; }
        public int minHC { get; set; }
        public int maxHC { get; set; }
        public int minDmg { get; set; }
        public int maxDmg { get; set; }
        public int value { get; set; }
    }
    class LightWeapon
    {
        public string name { get; set; }
        public int minHC { get; set; }
        public int maxHC { get; set; }
        public int minDmg { get; set; }
        public int maxDmg { get; set; }
        public int value { get; set; }
    }
    class Armour
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int dmgReduction { get; set; }
        public int value { get; set; }
    }
    class Shield
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int blockChance { get; set; }
        public int value { get; set; }
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
        while (true)
        {
            switch (Console.ReadLine().ToLower())
            {
                case "attack":
                    Console.WriteLine("Which enemy would you like to attack?"); // skriv en parantes med hur många attacker som är kvar
                    break;
                default:
                    Console.WriteLine("Incorrect input, please choose one of the options");
                    break;
            }
        }
    }
    public static void CombatInfo()
    {

    }
    public static void Shop()
    {
        Dictionary<string, HeavyWeapon> HeavyWeapons = new()
        {
            ["spatha"] = new HeavyWeapon {name = "Spatha",minHC = 50,maxHC = 100,minDmg = 40,maxDmg = 80,value = 50,},
            ["flail"] = new HeavyWeapon { name = "Flail", minHC = 30, maxHC = 100, minDmg = 70, maxDmg = 100, value = 70, }, // glöm inte str multiplier
            ["fuscina"] = new HeavyWeapon { name = "Fuscina", minHC = 40, maxHC = 100, minDmg = 30, maxDmg = 70, value = 80, } // attackerar 3 gånger
        };
        Dictionary<string, LightWeapon> LightWeapons = new()
        {
            ["pugio"] = new LightWeapon { name = "Pugio", minHC = 80, maxHC = 100, minDmg = 30, maxDmg = 50, value = 20},
            ["gladius"] = new LightWeapon { name = "Gladius", minHC = 70, maxHC = 100, minDmg = 20, maxDmg = 60, value = 30},
            // SICA KNIFE NEEDS PROPER STATS
        };
        Dictionary<string, Armour> Armours = new()
        {
            ["cataphract"] = new Armour { name = "Cataphract", dmgReduction = 70, weight = 8, value = 100},
            ["segmenta"] = new Armour { name = "Segmenta", dmgReduction = 50, weight = 5, value = 70},
            ["hamata"] = new Armour { name = "Hamata", dmgReduction = 30, weight = 3, value = 50},
        };
        Dictionary<string, Shield> Shields = new()
        {
            ["scutum"] = new Shield { name = "Scutum", blockChance = 70, weight = 8, value = 100 },

        };
    }
    public static void Character()
    {

    }
}