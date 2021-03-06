﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Areas.Identity.Pages.Account
{
    [Authorize(Roles = "Admin")]
    public class RegisterCustomerModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _dbContext;

        public RegisterCustomerModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _dbContext = dbContext;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "電子メールフィールドは必須です。")]
            [EmailAddress(ErrorMessage = "電子メール]フィールドは有効な電子メールアドレスではありません。")]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "パスワード]フィールドは必須です。")]
            [StringLength(16, ErrorMessage = "パスワードは{2}文字以上{1}文字以下である必要があります。", MinimumLength = 4)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "パスワードと確認パスワードが一致しません。")]
            public string ConfirmPassword { get; set; }

            public Customer Customer { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {


            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var resultU = await _userManager.CreateAsync(user, Input.Password);

                if (resultU.Succeeded)
                {
                    try
                    {
                        var resultR = await _userManager.AddToRoleAsync(user, "Customer");
                        if (resultR.Succeeded)
                        {
                            Input.Customer.UserId = user.Id;
                            await _dbContext.Customers.AddAsync(Input.Customer);
                            var resultCustomer = _dbContext.SaveChangesAsync();

                            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                            var callbackUrl = Url.Page(
                                "/Account/ConfirmEmail",
                                pageHandler: null,
                                values: new { userId = user.Id, code = code },
                                protocol: Request.Scheme);

                            await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                            //await _signInManager.SignInAsync(user, isPersistent: false);
                            _userManager.AddToRoleAsync(user, "Customer").Wait();
                            return RedirectToAction("CustomerPage", "Admin");
                        }
                        
                    }


                    catch (AggregateException)
                    {
                        return RedirectToAction("CustomerPage", "Admin");
                    }
                }

                foreach (var error in resultU.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }


            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
