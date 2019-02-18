using Core.Services.NhanVien;
using System.Web.Mvc;
using Core;
using Unity;
using Unity.Mvc5;

namespace BugManager
{
    public static partial class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            container.RegisterType<IDmNhanVienServices, DmNhanVienServices>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}