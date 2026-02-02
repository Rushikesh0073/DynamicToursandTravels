using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToursAndTravelsManagement.Data;
using ToursAndTravelsManagement.Models;

namespace ToursAndTravelsManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminPaymentSettingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminPaymentSettingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminPaymentSettings
        public async Task<IActionResult> Index()
        {
            var setting = await _context.PaymentSettings.FirstOrDefaultAsync();
            return View(setting ?? new PaymentSetting());
        }

        // POST: Save / Update UPI (SINGLE RECORD)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(PaymentSetting model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            var existing = await _context.PaymentSettings.FirstOrDefaultAsync();

            if (existing == null)
            {
                // INSERT
                _context.PaymentSettings.Add(model);
            }
            else
            {
                // UPDATE
                existing.UpiId = model.UpiId;
                existing.UpiName = model.UpiName;
            }

            await _context.SaveChangesAsync();
            TempData["Success"] = "UPI details saved successfully";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePaymentSetting(PaymentSetting model)
        {
            var setting = await _context.PaymentSettings.FirstOrDefaultAsync();

            if (setting == null)
            {
                _context.PaymentSettings.Add(model);
            }
            else
            {
                setting.UpiId = model.UpiId;
                setting.UpiName = model.UpiName;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeletePaymentSetting()
        {
            var setting = await _context.PaymentSettings.FirstOrDefaultAsync();
            if (setting != null)
            {
                _context.PaymentSettings.Remove(setting);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }










    }
}
