using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Snake.API.Application.AddSnake
{
    public class AddSnakeRequest: IRequest<AddSnakeResponse>
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public float Point {  get; set; }

    }
}
