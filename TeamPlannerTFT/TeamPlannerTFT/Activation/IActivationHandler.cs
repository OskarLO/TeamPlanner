using System.Threading.Tasks;

namespace TeamPlannerTFT.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle(object args);

        Task HandleAsync(object args);
    }
}
