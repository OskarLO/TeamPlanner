using System.Threading.Tasks;

namespace DotNetExamTFT.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
