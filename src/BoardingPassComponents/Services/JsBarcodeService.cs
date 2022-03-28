using Microsoft.JSInterop;

namespace BoardingPassComponents.Services;

public class JsBarcodeService
{
    private readonly IJSRuntime _jsRuntime;
    private readonly JsBarcodeOptions _defaultOptions;

    public JsBarcodeService(IJSRuntime runtime)
    {
        _jsRuntime = runtime;
        _defaultOptions = new JsBarcodeOptions();
    }

    public ValueTask Generate(string value, JsBarcodeOptions? options = null)
    {
        options ??= _defaultOptions;
        return _jsRuntime.InvokeVoidAsync("JsBarcode", "#barcode", value, options);
    }
}

public class JsBarcodeOptions
{
    public string? Format { get; set; }
    public string? LineColor { get; set; } = "black";
    public string? Background { get; set; } = "transparent";
    public int Width { get; set; } = 2;
    public int Height { get; set; } = 60;
    public bool DisplayValue { get; set; } = false;
}
