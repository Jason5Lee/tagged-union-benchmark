#!/bin/bash
dotnet restore
for CASES in CASE1 CASE2 CASE3 CASE4
do
    dotnet msbuild Jason5Lee.TaggedUnionPatterns.sln /p:DefineConstants="$CASES" /t:Rebuild /p:Configuration=Release || exit
    pushd ./Jason5Lee.TaggedUnionPatterns.Tests
    dotnet test --no-build -c Release || exit
    popd
    pushd Jason5Lee.TaggedUnionPatterns.Benchmarks
    sudo dotnet run --no-build -c Release || exit
    mv -f BenchmarkDotNet.Artifacts/results/Jason5Lee.TaggedUnionPatterns.Benchmarks.BenchmarkArea-report-github.md ../../results/csharp/$(echo "$CASES" | awk '{print tolower($0)}').md || exit
    popd
done
