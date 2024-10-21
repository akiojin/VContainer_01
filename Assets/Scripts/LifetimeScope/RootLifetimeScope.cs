using VContainer;
using VContainer.Unity;

/// <summary>
/// Application のルートのライフタイムスコープ。
/// このライフタイムスコープは、ヒラエルキー上に配置されるのではなく、
/// <see cref="VContainerSettings"/> にプレハブとして登録しておく。
/// 実体化は、それぞれのシーンで配置されているライフタイプスコープで行われる。
/// </summary>
public class RootLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<Startup>();
        builder.Register<ILogger, Logger>(Lifetime.Singleton);
    }
}
