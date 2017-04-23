using Abp.Web.Mvc.Views;

namespace NetCraft.Web.Views
{
    public abstract class NetCraftWebViewPageBase : NetCraftWebViewPageBase<dynamic>
    {

    }

    public abstract class NetCraftWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected NetCraftWebViewPageBase()
        {
            LocalizationSourceName = NetCraftConsts.LocalizationSourceName;
        }
    }
}