using System.Threading.Tasks;

namespace TeamPlannerTFT.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
