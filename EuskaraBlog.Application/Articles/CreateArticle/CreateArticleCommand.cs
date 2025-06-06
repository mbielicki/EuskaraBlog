using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace EuskaraBlog.Application.Articles.CreateArticle
{
    public record CreateArticleCommand(string Title, string Content) : IRequest<int>;
    
}
