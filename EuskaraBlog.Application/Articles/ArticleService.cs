using EuskaraBlog.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskaraBlog.Application.Articles
{
    public class ArticleService : IArticleService
    {
        public List<Article> GetAllArticles()
        {
            return new List<Article>
            {
                new Article { Id = 1, Title = "Learn Euskara", Content = "The Basque langue (euskara) is the oldest language in Europe..."},
                new Article { Id = 2, Title = "Our methodology", Content = "Our approach to teaching Euskara is immersive and practical..."},
                new Article { Id = 3, Title = "Pronounciation guide", Content = "Euskara pronunciation is straightforward and mostly phonetic..."}
            };
        }
    }
}
