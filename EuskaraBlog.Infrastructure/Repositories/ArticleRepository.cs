using EuskaraBlog.Domain.Articles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskaraBlog.Infrastructure.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _context;

        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateArticleAsync(Article article)
        {
            await _context.Articles.AddAsync(article);
            await _context.SaveChangesAsync();
            return article.Id;
        }

        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await _context.Articles
                .Where(a => a.IsPublished)
                .OrderByDescending(a => a.DatePublished)
                .ToListAsync();
        }
    }
}
