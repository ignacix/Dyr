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
            RuleFor(palabra => palabra.word).NotEmpty().WithMessage("Ingrese una palabra");
            RuleFor(Palabra => Palabra.meaning).NotEmpty().WithMessage("Ingrese un significado");
            RuleFor(palabra => palabra.word).MaximumLength(50);
            RuleFor(palabra => palabra.meaning).MaximumLength(50);

        }
    }
}
