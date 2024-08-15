using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

public class HomeController : Controller
{
    private readonly HttpClient _httpClient;

    public HomeController()
    {
        _httpClient = new HttpClient();
    }

    public async Task<IActionResult> Index()
    {
        string apiUrl = "https://dummyjson.com/todos";
        var response = await _httpClient.GetStringAsync(apiUrl);

        // ���� �-JSON ������ ������ �-View
        return Content(response, "application/json");
    }
}
