using EuskaraBlog.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskaraBlog.Domain.Articles
{
    public class Article : Entity
    {
        public required string Title { get; set; }
        public string? Content { get; set; }
        public DateTime DatePublished { get; set; } = DateTime.Now;
        public bool IsPublished { get; set; } = false;

        public string Summary
        {
            get
            {
                if (string.IsNullOrEmpty(Content))
                    return string.Empty;
                var summary = Content.Length > 100 ? Content[..100] : Content;
                return summary + (Content.Length > 100 ? "..." : string.Empty);
            }
        }
    }
}
