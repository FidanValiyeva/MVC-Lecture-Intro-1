using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers
{
    public class HomeController:Controller
    {
        public string Hi(string name,int age )
        {
            return "salamlarr:)" + name+ "----" + age;
        }

    }
}
