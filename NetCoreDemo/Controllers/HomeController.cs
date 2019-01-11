using Microsoft.AspNetCore.Mvc;
using NetCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly NetCoreDBContext _netCoreDBContext;
        public HomeController(NetCoreDBContext netCoreDBContext)
        {
            _netCoreDBContext = netCoreDBContext;
        }

        /*
            动作名称(类)              行为
            ContentResult           返回一串字符串
            FileContentResult       返回文件的内容
            FilePathResult          返回路径文件的内容
            FileStreamResult        返回流文件的内容
            EmptyResult             返回空
            JavaScriptResult        返回一段 JavaScript 代码
            JsonResult              返回 JSON 格式的数据
            RedirectToResult        重定向到某个 URL
            HttpUnauthorizedResult  返回 403 未授权状态码
            RedirectToRouteResult   重定向到不同的控制器或方法
            ViewResult              从视图引擎中返回一个响应
            PartialViewResult       从视图引擎中返回一个响应
        */

        //public ContentResult Index()
        //{
        //    return Content("你好，世界! 这条消息来自使用了 ActionResult 的 Home 控制器");
        //}

        //public ObjectResult Index()
        //{
        //    Employee employee = new Employee { ID = 1, Name = "Vinson" };
        //    return new ObjectResult(employee);
        //}

        public ViewResult Index()
        {
            var model = new HomePageViewModel();
            SQLEmployeeData sqlData = new SQLEmployeeData(_netCoreDBContext);
            model.Employees = sqlData.GetAll();
            return View(model);
        }

        public ViewResult Detail(int Id)
        {
            SQLEmployeeData sqlData = new SQLEmployeeData(_netCoreDBContext);
            Employee employee = sqlData.Get(Id);
            return View(employee);
        }
    }

    public class SQLEmployeeData
    {
        private NetCoreDBContext _netCoreDBContext { get; set; }

        public SQLEmployeeData(NetCoreDBContext netCoreDBContext)
        {
            _netCoreDBContext = netCoreDBContext;
        }

        public void add(Employee employee)
        {
            _netCoreDBContext.Employees.Add(employee);
            _netCoreDBContext.SaveChanges();
        }
        public Employee Get(int ID)
        {
            return _netCoreDBContext.Employees.FirstOrDefault(e => e.ID == ID);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _netCoreDBContext.Employees.ToList<Employee>();
        }
    }

    public class HomePageViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
    }
}
