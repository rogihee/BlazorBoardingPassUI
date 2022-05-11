using System.Net.Http.Json;
using Microsoft.Extensions.Options;

namespace BoardingPassShared.Services;

public class BoardingPassService : IBoardingPassService
{
    private readonly HttpClient _http;
    private readonly JsonSerializerOptions _options;
    private const string ApiUrl = "https://localhost:7110";

    public BoardingPassService(HttpClient httpClient, IOptions<JsonSerializerOptions> jsonOptions)
    {
        _http = httpClient;
        _options = jsonOptions.Value;
    }
    
    public async Task<BoardingPass> GetBoardingPass(Guid passengerId)
    {
        //var response = await _http.GetAsync($"{ApiUrl}/boardingpass/{passengerId}");
        //var json = await response.Content.ReadAsStringAsync();
        //var res = JsonSerializer.Deserialize<ApiResponse>(json, _options);

        // TODO: why is this null?
        var res = await _http.GetFromJsonAsync<BoardingPass>($"{ApiUrl}/boardingpass/{passengerId}", _options);
        return res;
    }
}

public class ApiResponse
{
    public int Id { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsCanceled { get; set; }
    public BoardingPass? Result { get; set; }
}