using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Queue.Configuration.Dto;

namespace Queue.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : QueueAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
