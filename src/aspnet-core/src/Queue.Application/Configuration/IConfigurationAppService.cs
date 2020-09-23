using System.Threading.Tasks;
using Queue.Configuration.Dto;

namespace Queue.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
