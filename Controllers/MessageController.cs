using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalRChat.Data;
using SignalRChat.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChat.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly string _currentUserId;
        private readonly ApplicationUser _currentUser;

        public MessageController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
            _currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).ToString();
            _currentUser = _context.Users.Where(u => u.Id == _currentUserId).FirstOrDefault();
        }

        public async Task<IActionResult> Index()
        {
            List<ApplicationUser> users = await _context.Users.Where(u => u.Id != _currentUserId).ToListAsync();

            return View(users);
        }

        [Route("message/{userId}")]
        public IActionResult Index(string userId)
        {
            List<string> messages = new List<string>();

            return View("ChatUi", messages);
        }
    }
}
