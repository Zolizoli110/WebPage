using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Services;

namespace WebApplication3.ViewComponents;

public class NewsViewComponent(NewsService newsService, List<News> newsList) : ViewComponent
{
    private async Task GetAllNews()
    {
        await newsService.GetAllByDate(DateTime.UtcNow.AddDays(-7));
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        await GetAllNews();
        return View(newsList);
    }
}