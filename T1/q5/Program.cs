using System;
namespace CodeCombat
{
    public class Character
    {
        public string name;
        public double xpos;
        public double ypos;
        public int hp;
        public Character(string _name, double _xpos, double _ypos)
        {
            this.name = _name;
            this.xpos = _xpos;
            this.ypos = _ypos;
            this.hp = 100;
        }
        public void move(double _xpos, double _ypos)
        {
            this.xpos = _xpos;
            this.ypos = _ypos;
        }
        public void attack(Character _target)
        {
            _target.hp = Math.Max(0, _target.hp - 10);
        }
    }
    public class Ogre : Character
    {
        public string specie;
        public Ogre(string _name, double _xpos, double _ypos) :
        base(_name, _xpos, _ypos)
        {
            this.specie = "Ogre";
        }


        static void Main(String[] args)
        {
            Ogre o = new Ogre("StrongOne", 0, 0);
            Console.WriteLine(o.name);
        }
    }

}