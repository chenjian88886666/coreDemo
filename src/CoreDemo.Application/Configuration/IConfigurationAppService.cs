using System.Threading.Tasks;
using CoreDemo.Configuration.Dto;

namespace CoreDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
