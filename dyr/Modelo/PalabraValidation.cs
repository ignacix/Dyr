using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace Modelo
{
    public class PalabraValidation : AbstractValidator<Palabra>
    {
        public PalabraValidation() 
        {
            RuleFor(palabra => palabra.word).NotNull();
        }
    }
}
