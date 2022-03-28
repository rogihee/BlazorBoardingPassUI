using Microsoft.JSInterop;

namespace BoardingPassComponents.Services;

public class JsBarcodeService
{
    private readonly IJSRuntime _jsRuntime;

    public JsBarcodeService(IJSRuntime runtime)
    {
        _jsRuntime = runtime;
    }
}