using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class animals //animals
    {
        string name;
        public animals(string name)
        {
            this.name = name;
        }
    }
    class unicellular : animals //одколеточные 
    {
        bool movement;
        public unicellular(string name, bool movement) : base(name)
        {
            this.movement = movement; }
    }
    class multicellular : animals //многоклеточные
    {
        bool in_woter;
        public multicellular(string name, bool in_woter) : base(name)
        {
            this.in_woter = in_woter;
        }

    }
    class vertebrates : multicellular //позвоночные
    {
        bool fish;
        public vertebrates(string name, bool in_woter,bool fish) : base(name,in_woter)
        {
            this.fish = fish; 
        }
    }
    class invertebrates : multicellular //безпозвоночные
    {
        bool ground;
        public invertebrates(string name, bool in_woter, bool ground) : base(name, in_woter)
        {
            this.ground = ground;
        }
    }
}
