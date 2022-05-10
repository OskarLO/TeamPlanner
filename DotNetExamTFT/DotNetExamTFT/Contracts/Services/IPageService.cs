using System;

namespace DotNetExamTFT.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);
    }
}
