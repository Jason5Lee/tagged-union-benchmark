``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i5-8279U CPU 2.40GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


```
|        Method |     Mean |     Error |    StdDev |
|-------------- |---------:|----------:|----------:|
|    AreaSwitch | 1.332 ms | 0.0048 ms | 0.0042 ms |
| AreaMatchVoid | 4.882 ms | 0.0372 ms | 0.0348 ms |
|     AreaMatch | 1.787 ms | 0.0079 ms | 0.0074 ms |
