using EuskaraBlog.Domain.Articles;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskaraBlog.Application.Articles.GetArticle
{
    public class GetArticleQueryHandler : IRequestHandler<GetArticleQuery, Article?>
    {
        private readonly IArticleRepository _articleRepository;

        public GetArticleQueryHandler(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<Article?> Handle(GetArticleQuery request, CancellationToken cancellationToken)
        {
            return await _articleRepository.GetByIdAsync(request.Id);
        }

    }
}
