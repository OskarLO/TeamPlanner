using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPlannerTFT.DataAccess.Model
{
    public class Trait
    {
        public int TraitId { get; set; }
        public string TraitName { get; set; }
        public string TraitEffect { get; set; }

        public List<Unit> Units { get; set; }

        public Trait(int traitId, string traitName, string traitEffect)
        {
            TraitId = traitId;
            TraitName = traitName;
            TraitEffect = traitEffect;
        }


        public void AddUnit(Unit unit)
        {
            Units.Add(unit);
        }
    }
}
