using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Snake.API.Application.AddSnake
{

    public class AddSnakeValidator: AbstractValidator<AddSnakeRequest>
    {
        public AddSnakeValidator() { 
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Color).NotEmpty();
            RuleFor(x => x.Point).NotEmpty();
        }
    }
}
