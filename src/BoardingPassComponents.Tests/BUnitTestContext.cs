using System;
using Bunit;
using Bunit.Rendering;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using TestContext = Bunit.TestContext;

namespace BoardingPassComponents.Tests;

public abstract class BUnitTestContext : IDisposable
{
    public TestContext? Context;
    public ITestRenderer Renderer => Context?.Renderer ?? throw new InvalidOperationException("NUnit has not started executing tests yet");
    public TestServiceProvider Services => Context?.Services ?? throw new InvalidOperationException("NUnit has not started executing tests yet");
    public BunitJSInterop JsInterop => Context?.JSInterop ?? throw new InvalidOperationException("NUnit has not started executing tests yet");

    [SetUp]
    public void Setup()
    {
        Context = new Bunit.TestContext();
        Context.Services.AddLogging();
        // setup our services with mocks if needed
        Context.JSInterop.Mode = JSRuntimeMode.Loose;
    }

    public void Dispose()
    {
        Context?.Dispose();
        Context = null;
    }

    [TearDown]
    public void TearDown() => Dispose();

    public IRenderedComponent<TComponent> RenderComponent<TComponent>(params ComponentParameter[] parameters) where TComponent : IComponent
        => Context?.RenderComponent<TComponent>(parameters) ?? throw new InvalidOperationException("NUnit has not started executing tests yet");

    public IRenderedComponent<TComponent> RenderComponent<TComponent>(Action<ComponentParameterCollectionBuilder<TComponent>> parameterBuilder) where TComponent : IComponent
        => Context?.RenderComponent<TComponent>(parameterBuilder) ?? throw new InvalidOperationException("NUnit has not started executing tests yet");
}