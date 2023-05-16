using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("soyad alanı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("mail alanı boş geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("şifre alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("şifre tekrar alanı boş geçilemez");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("lütfen en az 5 karekter veri girişi yapınız");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("lütfen en fazla 20 karekter veri girişi yapınız");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("şifreler birbiri ile uyuşmuyur.");
            RuleFor(x => x.Password).Matches(@"[A-Z]+").WithMessage("şifreniz büyük harf içermeli.");
            RuleFor(x => x.Password).Matches(@"[a-z]+").WithMessage("şifreniz küçük harf içermeli.");
            RuleFor(x => x.Password).Matches(@"[0-9]+").WithMessage("şifreniz rakam içermeli.");
            RuleFor(x => x.Password).Matches(@"[\!\?\*\.]*$").WithMessage("şifreniz karakter içermeli (!? *.).");

        }
    }
}
