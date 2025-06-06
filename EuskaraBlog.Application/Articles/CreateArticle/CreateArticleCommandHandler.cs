using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuskaraBlog.Domain.Articles;
using MediatR;

namespace EuskaraBlog.Application.Articles.CreateArticle
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, int>
    {
        private readonly IArticleRepository _articleRepository;

        public CreateArticleCommandHandler(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<int> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            var article = new Article
            {
                Title = request.Title,
                Content = request.Content
            };

            return await _articleRepository.CreateArticleAsync(article);
        }
    }
}
