``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i5-8279U CPU 2.40GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-KPKPPE : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|        Method | nCases |       Mean |    Error |   StdDev | Rank |
|-------------- |------- |-----------:|---------:|---------:|-----:|
|    **AreaSwitch** |      **2** | **1,370.7 us** | **11.78 us** | **11.02 us** |    **6** |
| AreaMatchVoid |      2 | 3,438.7 us | 28.98 us | 27.10 us |   18 |
|     AreaMatch |      2 | 1,571.7 us |  5.62 us |  5.26 us |    7 |
| AreaVisitVoid |      2 | 3,171.6 us | 18.61 us | 17.41 us |   17 |
|     AreaVisit |      2 | 2,054.4 us |  6.37 us |  5.32 us |   13 |
|   AreaVirtual |      2 |   802.1 us |  2.19 us |  1.94 us |    1 |
| TagAreaSwitch |      2 |   893.9 us |  3.58 us |  3.35 us |    2 |
|  TagAreaMatch |      2 | 1,378.9 us |  5.79 us |  5.41 us |    6 |
|    **AreaSwitch** |      **3** | **1,623.6 us** |  **6.81 us** |  **6.37 us** |    **8** |
| AreaMatchVoid |      3 | 4,885.3 us | 37.42 us | 35.00 us |   20 |
|     AreaMatch |      3 | 1,986.6 us |  7.96 us |  6.65 us |   12 |
| AreaVisitVoid |      3 | 4,302.3 us | 45.26 us | 42.34 us |   19 |
|     AreaVisit |      3 | 2,595.5 us | 22.68 us | 21.21 us |   16 |
|   AreaVirtual |      3 |   984.2 us |  4.80 us |  4.49 us |    3 |
| TagAreaSwitch |      3 | 1,323.7 us |  5.72 us |  5.07 us |    5 |
|  TagAreaMatch |      3 | 1,669.3 us |  6.40 us |  5.68 us |    9 |
|    **AreaSwitch** |      **4** | **1,777.5 us** |  **7.11 us** |  **6.65 us** |   **11** |
| AreaMatchVoid |      4 | 5,507.9 us | 29.13 us | 25.82 us |   22 |
|     AreaMatch |      4 | 2,221.1 us |  5.67 us |  5.03 us |   14 |
| AreaVisitVoid |      4 | 5,000.4 us | 24.15 us | 21.41 us |   21 |
|     AreaVisit |      4 | 2,539.7 us |  9.03 us |  8.01 us |   15 |
|   AreaVirtual |      4 | 1,095.5 us |  5.84 us |  5.47 us |    4 |
| TagAreaSwitch |      4 | 1,390.2 us |  5.34 us |  4.99 us |    6 |
|  TagAreaMatch |      4 | 1,749.6 us |  6.79 us |  6.35 us |   10 |
