using System;

namespace TeamPlannerTFT.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);
    }
}
