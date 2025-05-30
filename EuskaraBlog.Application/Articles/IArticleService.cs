using EuskaraBlog.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskaraBlog.Application.Articles
{
    public interface IArticleService
    {
        List<Article> GetAllArticles();
    }
}
