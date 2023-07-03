using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
	{
		SendMessageManager messageManager = new SendMessageManager(new EfMessageDal());
		[HttpGet]
		public IViewComponentResult Invoke()
		{
			return View();
		}
		//[HttpPost]
		//public IViewComponentResult Invoke(Message p)
		//{
			
		//	return View();
		//}
	}
}
