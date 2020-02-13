``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i5-8279U CPU 2.40GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-TWYRFV : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-ZNSJJL : .NET CoreRT 1.0.28612.02 @BuiltBy: runner-Mac-237.local @Branch: master @Commit: 9acd955fbdb619e99ab441a3d5ca20a2e6052f09, X64 AOT


```
|        Method |       Runtime | nCases |       Mean |     Error |   StdDev | Rank |
|-------------- |-------------- |------- |-----------:|----------:|---------:|-----:|
|    **AreaSwitch** | **.NET Core 3.1** |      **2** | **1,382.6 us** |   **7.07 us** |  **5.91 us** |   **10** |
| AreaMatchVoid | .NET Core 3.1 |      2 | 3,466.3 us |  26.75 us | 25.02 us |   24 |
|     AreaMatch | .NET Core 3.1 |      2 | 1,605.6 us |  11.92 us | 11.15 us |   11 |
| AreaVisitVoid | .NET Core 3.1 |      2 | 3,137.1 us |  15.56 us | 14.55 us |   23 |
|     AreaVisit | .NET Core 3.1 |      2 | 1,925.2 us |   9.21 us |  7.69 us |   17 |
|   AreaVirtual | .NET Core 3.1 |      2 |   753.2 us |   5.22 us |  4.88 us |    2 |
| TagAreaSwitch | .NET Core 3.1 |      2 |   740.0 us |   4.65 us |  4.35 us |    1 |
|  TagAreaMatch | .NET Core 3.1 |      2 | 1,181.1 us |  11.65 us | 10.89 us |    8 |
|    AreaSwitch |    CoreRt 3.1 |      2 |   933.6 us |   8.00 us |  7.49 us |    4 |
| AreaMatchVoid |    CoreRt 3.1 |      2 | 3,096.6 us |  24.43 us | 22.85 us |   23 |
|     AreaMatch |    CoreRt 3.1 |      2 | 1,360.1 us |  12.98 us | 12.14 us |   10 |
| AreaVisitVoid |    CoreRt 3.1 |      2 | 3,094.0 us |  24.56 us | 22.97 us |   23 |
|     AreaVisit |    CoreRt 3.1 |      2 | 1,779.5 us |   5.56 us |  4.93 us |   14 |
|   AreaVirtual |    CoreRt 3.1 |      2 |   764.6 us |   5.13 us |  4.80 us |    3 |
| TagAreaSwitch |    CoreRt 3.1 |      2 |   768.6 us |   8.08 us |  7.56 us |    3 |
|  TagAreaMatch |    CoreRt 3.1 |      2 | 1,237.3 us |  13.69 us | 12.81 us |    9 |
|    **AreaSwitch** | **.NET Core 3.1** |      **3** | **1,665.4 us** |   **7.71 us** |  **7.21 us** |   **12** |
| AreaMatchVoid | .NET Core 3.1 |      3 | 4,571.9 us |  39.08 us | 36.55 us |   28 |
|     AreaMatch | .NET Core 3.1 |      3 | 1,859.2 us |   6.92 us |  6.13 us |   16 |
| AreaVisitVoid | .NET Core 3.1 |      3 | 4,144.8 us |  17.95 us | 16.79 us |   25 |
|     AreaVisit | .NET Core 3.1 |      3 | 2,325.5 us |   8.31 us |  7.36 us |   21 |
|   AreaVirtual | .NET Core 3.1 |      3 | 1,077.9 us |   9.01 us |  8.43 us |    6 |
| TagAreaSwitch | .NET Core 3.1 |      3 | 1,141.6 us |   5.82 us |  4.86 us |    7 |
|  TagAreaMatch | .NET Core 3.1 |      3 | 1,698.7 us |  11.09 us | 10.38 us |   12 |
|    AreaSwitch |    CoreRt 3.1 |      3 | 1,246.5 us |  13.56 us | 12.68 us |    9 |
| AreaMatchVoid |    CoreRt 3.1 |      3 | 4,327.3 us |  23.86 us | 22.32 us |   27 |
|     AreaMatch |    CoreRt 3.1 |      3 | 1,652.6 us |   9.21 us |  8.62 us |   12 |
| AreaVisitVoid |    CoreRt 3.1 |      3 | 4,245.8 us |  29.95 us | 28.02 us |   26 |
|     AreaVisit |    CoreRt 3.1 |      3 | 2,042.9 us |   4.91 us |  4.35 us |   18 |
|   AreaVirtual |    CoreRt 3.1 |      3 |   967.6 us |   4.82 us |  4.51 us |    5 |
| TagAreaSwitch |    CoreRt 3.1 |      3 | 1,153.4 us |   9.63 us |  9.00 us |    7 |
|  TagAreaMatch |    CoreRt 3.1 |      3 | 1,686.3 us |  12.09 us | 11.31 us |   12 |
|    **AreaSwitch** | **.NET Core 3.1** |      **4** | **1,801.4 us** |   **5.47 us** |  **4.85 us** |   **15** |
| AreaMatchVoid | .NET Core 3.1 |      4 | 5,275.4 us |  25.53 us | 23.88 us |   31 |
|     AreaMatch | .NET Core 3.1 |      4 | 2,097.2 us |   6.16 us |  5.77 us |   19 |
| AreaVisitVoid | .NET Core 3.1 |      4 | 4,817.2 us |  30.82 us | 28.83 us |   29 |
|     AreaVisit | .NET Core 3.1 |      4 | 2,493.1 us |  10.24 us |  9.58 us |   22 |
|   AreaVirtual | .NET Core 3.1 |      4 | 1,071.5 us |   7.50 us |  7.02 us |    6 |
| TagAreaSwitch | .NET Core 3.1 |      4 | 1,348.0 us |  10.31 us |  9.64 us |   10 |
|  TagAreaMatch | .NET Core 3.1 |      4 | 1,703.1 us |  13.10 us | 12.25 us |   12 |
|    AreaSwitch |    CoreRt 3.1 |      4 | 1,367.6 us |  19.74 us | 18.46 us |   10 |
| AreaMatchVoid |    CoreRt 3.1 |      4 | 5,220.6 us |  25.02 us | 23.41 us |   31 |
|     AreaMatch |    CoreRt 3.1 |      4 | 1,772.7 us |  10.58 us |  9.89 us |   14 |
| AreaVisitVoid |    CoreRt 3.1 |      4 | 5,083.8 us | 100.36 us | 98.57 us |   30 |
|     AreaVisit |    CoreRt 3.1 |      4 | 2,183.6 us |  42.53 us | 43.68 us |   20 |
|   AreaVirtual |    CoreRt 3.1 |      4 |   924.8 us |   2.79 us |  2.61 us |    4 |
| TagAreaSwitch |    CoreRt 3.1 |      4 | 1,230.6 us |   6.27 us |  5.87 us |    9 |
|  TagAreaMatch |    CoreRt 3.1 |      4 | 1,737.4 us |   5.17 us |  4.83 us |   13 |
