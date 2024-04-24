using MediatR;

namespace Snake.API.Application.AddSnake
{
    public class AddSnakeHandler : IRequestHandler<AddSnakeRequest, AddSnakeResponse>
    {
        public Task<AddSnakeResponse> Handle(AddSnakeRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> AddSnake(AddSnakeRequest addSnakeRequest, CancellationToken cancellationToken)
        {

        }
    }
}
