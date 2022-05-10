using DotNetExamTFT.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetExamTFT.Core.Contracts.Services
{
    public interface IUnitService
    {
        Task<IEnumerable<UnitDto>> GetUnitsAsync();
        Task<UnitDto> CreateUnitAsync(UnitDto unit);
        void UpdateUnitAsync(UnitDto unit);
        Task<bool> DeleteUnitAsync(UnitDto unit);
    }
}
