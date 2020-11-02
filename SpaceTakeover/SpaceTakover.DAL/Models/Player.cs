namespace SpaceTakeover.DAL.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Stamina { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Mining { get; set; }
        public int TimeToSpendOnTask { get; set; }
        public Inventory Inventory { get; set; }
        

        public Player()
        {
            Name = "test";
            Stamina = 100;
            Health = 100;
            Attack = 10;
            Defense = 10;
            Mining = 10;
            Inventory = new Inventory();
        }

        public Player(string _name, int _stamina, int _health, int _attack, int _defense, int _mining)
        {
            Name = _name;
            Stamina = _stamina;
            Health = _health;
            Attack = _attack;
            Defense = _defense;
            Mining = _mining;
        }
    }
}
