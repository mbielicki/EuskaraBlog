using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuskaraBlog.Domain.Articles;
using MediatR;

namespace EuskaraBlog.Application.Articles.CreateArticle
{
    public record CreateArticleCommand(CreateArticleDto Article, Guid UserId) : IRequest<int>;
    
}
