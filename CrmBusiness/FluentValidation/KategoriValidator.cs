using CrmEntity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBusiness.FluentValidation
{
    public class KategoriValidator:AbstractValidator<TblKategori>
    {
        public KategoriValidator() {
            RuleFor(x => x.KategoriAd).NotEmpty().WithMessage("Kategori Adı boş geçilemez !!!");
            RuleFor(x => x.KategoriAd).MinimumLength(3).WithMessage("Kategori Adı en az 3 Karakter olmalıdır !!!");
        }
    }
}
