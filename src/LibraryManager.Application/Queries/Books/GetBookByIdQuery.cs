using LibraryManager.Application.Models;
using MediatR;

namespace LibraryManager.Application.Queries.Books
{
    public class GetBookByIdQuery : IRequest<BaseResult<GetBookByIdViewModel>>
    {
        public GetBookByIdQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
