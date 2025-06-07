using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuskaraBlog.Domain.Articles;
using MediatR;

namespace EuskaraBlog.Application.Articles.GetArticle
{
    public class GetArticleQuery : IRequest<Article?>
    {
        public int Id { get; set; }
        public GetArticleQuery(int id)
        {
            Id = id;
        }
    }
}
