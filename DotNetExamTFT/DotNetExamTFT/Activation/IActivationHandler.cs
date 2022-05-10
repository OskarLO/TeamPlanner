using System.Threading.Tasks;

namespace DotNetExamTFT.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle(object args);

        Task HandleAsync(object args);
    }
}
