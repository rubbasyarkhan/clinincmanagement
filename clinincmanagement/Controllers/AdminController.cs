using clinincmanagement.Models;
using clinincmanagement.Models.ViewModels; 
using Microsoft.AspNetCore.Mvc;

namespace clinincmanagement.Controllers
{
    public class AdminController : Controller
    {
        private readonly ClinicManagementDbContext _context;

        public AdminController(ClinicManagementDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            var model = new AdminDashboardViewModel
            {
                TotalUsers = _context.Users.Count(),
                TotalDoctors = _context.Users.Count(u => u.RoleId == 4), // Assuming RoleID 4 is for Doctors
                TotalAppointments = _context.Appointments.Count(),
                TotalOrders = _context.Orders.Count(),
                TotalProducts = _context.Products.Count()
            };

            return View(model);
        }
    }
}
