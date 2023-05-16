using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class AboutValidator :AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını Boş Geçemezsiniz");
            RuleFor(x => x.Description).NotEmpty().MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik bir açıklama giriniz");
            RuleFor(x => x.Description).NotEmpty().MaximumLength(1000).WithMessage("En fazla 1000 karakterlik bir açıklama girilebilir.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz");
        }
    }
}
