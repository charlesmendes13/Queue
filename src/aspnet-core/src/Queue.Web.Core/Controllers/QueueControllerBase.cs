using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Queue.Controllers
{
    public abstract class QueueControllerBase: AbpController
    {
        protected QueueControllerBase()
        {
            LocalizationSourceName = QueueConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
