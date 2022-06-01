using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaCSharpGaet.Model.Character
{
    internal class Character
    {
        #region model properties
        public string Name { get; set; }
        private string DecoratedName 
        { 
            get 
            { 
            
                return Name+"bitedenoir";
            } 
        }
        public int Health { get; set; }
        public decimal Strength { get; set; }
        #endregion

        #region constructor
        public Character (string name, int health, decimal strenght)
        {
            this.Name = name;
            this.Health = health;
            this.Strength = strenght;
        }

        public Character() { }
        #endregion

    }
}
