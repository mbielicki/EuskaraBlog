using EuskaraBlog.Domain.Articles;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskaraBlog.Application.Articles.GetArticles
{
    public class GetArticlesQuery : IRequest<List<Article>>
    {

    }
}
