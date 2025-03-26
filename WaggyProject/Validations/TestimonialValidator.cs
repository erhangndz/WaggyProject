using FluentValidation;
using WaggyProject.Entities;

namespace WaggyProject.Validations
{
    public class TestimonialValidator: AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Soyad boş bırakılamaz");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Yorum bölümü boş bırakılamaz")
                                   .MinimumLength(5).WithMessage("Yorum en az 5 karakterden oluşmalıdır.")
                                   .MaximumLength(150).WithMessage("Yorum en fazla 150 karakterden oluşmalıdır.");
        }

    }
}
