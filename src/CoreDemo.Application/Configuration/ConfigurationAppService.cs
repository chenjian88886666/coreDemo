using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CoreDemo.Configuration.Dto;

namespace CoreDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CoreDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
