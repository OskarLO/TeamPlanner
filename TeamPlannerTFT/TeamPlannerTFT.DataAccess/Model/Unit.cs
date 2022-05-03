using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TeamPlannerTFT.DataAccess.Model
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Mana { get; set; }
        public string UnitImage { get; set; }

        public List<Trait> Traits { get; set; }

        public Unit()
        {
        }

        public Unit(int id, string name, int cost, int mana)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Mana = mana;
        }

        public void SetUnitImage(string fileName) 
        {
            UnitImage = fileName;
        }

        public void AddTrait(Trait trait) 
        {
            Traits.Add(trait);
        }
    }
}
