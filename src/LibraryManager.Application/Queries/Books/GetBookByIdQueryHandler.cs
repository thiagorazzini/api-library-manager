using LibraryManager.Application.Models;
using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;
using MediatR;

namespace LibraryManager.Application.Queries.Books
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BaseResult<GetBookByIdViewModel>>
    {
        private readonly IBookRepository _repository;

        public GetBookByIdQueryHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<BaseResult<GetBookByIdViewModel>> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            Book? book = await _repository.GetBookByIdAsync(request.Id);

            if(book is null)
            {
                return new BaseResult<GetBookByIdViewModel>(null, false, string.Empty);
            }

            GetBookByIdViewModel viewModel = new GetBookByIdViewModel(book);

            return new BaseResult<GetBookByIdViewModel>( viewModel );
        }
    }
}
