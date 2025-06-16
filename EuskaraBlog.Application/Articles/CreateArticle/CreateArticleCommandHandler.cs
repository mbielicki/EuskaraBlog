using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuskaraBlog.Application.Users;
using EuskaraBlog.Domain.Articles;
using MediatR;

namespace EuskaraBlog.Application.Articles.CreateArticle
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, int>
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IUserService _userService;

        public CreateArticleCommandHandler(IArticleRepository articleRepository, IUserService userService)
        {
            _articleRepository = articleRepository;
            _userService = userService;
        }

        public async Task<int> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            var isAdmin = await _userService.IsUserInRoleAsync(request.UserId, "admin");
            if (!isAdmin)
                throw new UnauthorizedAccessException("Only admins can create articles.");
            
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
