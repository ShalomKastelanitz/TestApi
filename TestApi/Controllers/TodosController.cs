
//public class TodosController : Controller
//{
//    private readonly HttpClient _httpClient;

//    public TodosController()
//    {
//        _httpClient = new HttpClient();
//    }

//    public async Task<IActionResult> Index()
//    {
//        string apiUrl = "https://dummyjson.com/todos";
//        var response = await _httpClient.GetStringAsync(apiUrl);

//        // הצגת ה-JSON הגולמי ישירות ב-View
//        return Content(response, "application/json");
//    }
//}
