using System;
using System.Collections.Generic;
using System.Text;

namespace TeamPlannerTFT.Core.Dtos
{
    public class UnitDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Mana { get; set; }
        public string UnitImage { get; set; }

        public List<TraitDto> Traits { get; set; }
    }
}
