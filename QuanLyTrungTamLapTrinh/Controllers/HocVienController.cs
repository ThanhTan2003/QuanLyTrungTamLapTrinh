using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyTrungTamLapTrinh.Data;

namespace QuanLyTrungTamLapTrinh.Controllers
{
    public class HocVienController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HocVienController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HocVien
        public async Task<IActionResult> Index()
        {
            return View(await _context.HocVien.ToListAsync());
        }

        // GET: HocVien/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
