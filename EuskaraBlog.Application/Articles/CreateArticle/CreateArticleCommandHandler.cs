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
                Title = request.Article.Title,
                Content = request.Article.Content,
                IsPublished = request.Article.IsPublished,

            };

            return await _articleRepository.CreateArticleAsync(article);
        }
    }
}
