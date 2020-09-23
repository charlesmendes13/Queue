using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Queue.Authorization;

namespace Queue
{
    [DependsOn(
        typeof(QueueCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class QueueApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<QueueAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(QueueApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
