﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using denizdikbiyik_CET322_FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace denizdikbiyik_CET322_FinalProject.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginWithRecoveryCodeModel : PageModel
    {
        private readonly SignInManager<KermesUser> _signInManager;
        private readonly ILogger<LoginWithRecoveryCodeModel> _logger;

        public LoginWithRecoveryCodeModel(SignInManager<KermesUser> signInManager, ILogger<LoginWithRecoveryCodeModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [BindProperty]
            [Required]
            [DataType(DataType.Text)]
            public string RecoveryCode { get; set; }
        }

        public async Task<IActionResult> OnGetAsync(string returnUrl = null)
        {
            // Ensure the user has gone through the username & password screen first
            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                throw new InvalidOperationException($"İki faktörlü kimlik kullanıcısına ulaşılamıyor.");
            }

            ReturnUrl = returnUrl;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                throw new InvalidOperationException($"İki faktörlü kimlik kullanıcısına ulaşılamıyor.");
            }

            var recoveryCode = Input.RecoveryCode.Replace(" ", string.Empty);

            var result = await _signInManager.TwoFactorRecoveryCodeSignInAsync(recoveryCode);

            if (result.Succeeded)
            {
                _logger.LogInformation("Şu kullanıcı: '{UserId}' kurtarma kodu ile giriş yaptı.", user.Id);
                return LocalRedirect(returnUrl ?? Url.Content("~/"));
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning("Şu kullanıcı: '{UserId}' kilitlendi.", user.Id);
                return RedirectToPage("./Lockout");
            }
            else
            {
                _logger.LogWarning("Şu kullanıcı için geçersiz kurtarma kodu girildi: '{UserId}' ", user.Id);
                ModelState.AddModelError(string.Empty, "Geçersiz kurtarma kodu girdiniz.");
                return Page();
            }
        }
    }
}
