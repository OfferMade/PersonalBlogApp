using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services.Contracts;

namespace PersonalBlogApp.Components
{
    public class WritingSummaryViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public WritingSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager.WritingService.GetAllWritings(false).Count().ToString();
        }
    }
}
