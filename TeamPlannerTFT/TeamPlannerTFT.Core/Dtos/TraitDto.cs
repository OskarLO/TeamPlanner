using System;
using System.Collections.Generic;
using System.Text;

namespace TeamPlannerTFT.Core.Dtos
{
    public class TraitDto
    {
        public int TraitId { get; set; }
        public string TraitName { get; set; }
        public string TraitEffect { get; set; }

        public List<UnitDto> Units { get; set; }
    }
}
