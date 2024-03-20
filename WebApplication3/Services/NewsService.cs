using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using WebApplication4.DataBase;

namespace WebApplication3.Services;

public class NewsService(Context context) : Controller
{
    public async Task<List<News>> GetAllByDate(DateTimeOffset date)
    {
        return await context.News
            .Where(n => n.Published >= date && n.Published < DateTime.UtcNow)
            .ToListAsync();
    }

    public int Add(News news)
    {
        context.News.Add(news);
        return context.SaveChanges();
    }
}