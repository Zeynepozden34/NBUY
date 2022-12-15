using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers
{
    [AutoValidateAntiforgeryToken] //İlgili cookinn sadece ait olduğu tarayıcıdan gönderilesi halinde geçerli olmasını sağlar. tüm controllerde olmasını istiyoruz.
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signManager;
        private readonly IEmailSender _emailSender;
        public AccountController(UserManager<User> userManager, SignInManager<User> signManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signManager = signManager;
            _emailSender = emailSender;
        }

        public IActionResult Login(string returnUrl=null)
        {
            return View(new LoginDto { ReturnUrl=returnUrl});
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginDto.UserName);
                if (user == null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı.");
                    return View(loginDto);
                }
                // Bu noktada e-mail onayı yapılıp yaplmadıpnı kontrol edeceğiz.
                var result = await _signManager.PasswordSignInAsync(user, loginDto.Password, true, true);
                if (result.Succeeded)
                {
                    return Redirect(loginDto.ReturnUrl ?? "~/");
                }
                ModelState.AddModelError("", "Email adresi yada parola hatalı");
            }
            return View(loginDto);
        }
        public IActionResult Register()
        {
       
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // İlgili cookinn sadece ait olduğu tarayıcıdan gönderilesi halinde geçerli olmasını sağlar. tek postta olmasını istiyorsak.
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    UserName = registerDto.UserName,
                    Email = registerDto.Email,
                };
               var result= await _userManager.CreateAsync(user, registerDto.Password);
                if (result.Succeeded)
                {
                    //generate token(mail onayı için)
                    var tokenCode=await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Account", new
                    {
                        userId= user.Id,
                        token=tokenCode
                    });
                    Console.WriteLine(url);
                    //mailin gönderilme, onaylanma
                    await _emailSender.SendEmailAsync(user.Email, "ShoppingApp Hesap Onaylama", $"<h1>Merhaba</h1>" +
                        $"<br>" +
                        $"<p>Lütfen hesabınızı onaylamak için entere basınız </p>" +
                        $"<a href='https://localhost:5178{url}'></a>");
                    ViewBag("Kayıt işlemini tamamlamak için mailinize gönderilen onaylama linkine tıklayınız.");
                    return RedirectToAction("Login", "Account");
                }
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata oluştu, lütfen tekrar deneyiniz.");
            return View(registerDto);
        }
        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId==null || token==null)
            {
                ViewBag.Message("Geçersiz user veya token bilgisi!");
                return View();
            }
            var user=await _userManager.FindByIdAsync(userId);
            if (user!=null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    ViewBag.Message("Hesabınız başarıyla onaylandı.");
                    return View();
                }
            }
            ViewBag.Message("Bir sorun oluştu ve hesabınız onaylanmadı. Tekrar deneyiniz.");
            return View();
        }
    }
}
