using BoardingPassShared.Converters;
using Microsoft.Extensions.Options;

namespace BoardingPassShared.Helpers;

public class ConfigureJsonOptions : IConfigureOptions<JsonSerializerOptions>
{
    public void Configure(JsonSerializerOptions options)
    {
        options.Converters.Add(new DateOnlyJsonConverter());
        options.Converters.Add(new TimeOnlyJsonConverter());
    }
}