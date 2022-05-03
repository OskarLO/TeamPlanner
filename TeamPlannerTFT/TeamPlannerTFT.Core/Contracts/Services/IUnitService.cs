using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamPlannerTFT.Core.Dtos;

namespace TeamPlannerTFT.Core.Contracts.Services
{
    public interface IUnitService
    {
        Task<IEnumerable<UnitDto>> GetUnitsAsync();
        Task<UnitDto> CreateUnitAsync(UnitDto unit);
        void UpdateUnitAsync(UnitDto unit);
        Task<bool> DeleteUnitAsync(UnitDto unit);
    }
}
