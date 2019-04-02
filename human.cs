using System;
namespace human{
    public class human{
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        private int health;
        public human (string name){
            this.name = name;
            strength = dexterity = intelligence = 3;
            health = 100;
        }
        public human(string name, int strength, int intelligence, 
        int dexterity, int health){
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.health = health;
        }
        public string attack(object def){
            if (def is human){
                human rhs = (human) def;
                this.strength = 1;
                rhs.health -= 5;
                return this.name +"attack " +rhs;
            }
            else{
                Console.WriteLine("Error passed value is not a human");
                return "Error pass value is not a human";
            }
        }
        public string ToString(){
            return "Name: " +name+ ", health: " +health+ ", strength: " +strength;
        }
    }
}