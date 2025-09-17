# AssetRipper.Conversions.Crunch

Translation of [crunch](https://github.com/Unity-Technologies/crunch/tree/master) for use in C#.

## Generation

### LLVM IR

```
clang -S source.cpp -o source.ll -emit-llvm -w -g -fno-discard-value-names -fstandalone-debug
```

### C# Code

```
AssetRipper.Translation.LlvmIR.exe
source.ll
--namespace AssetRipper.Conversions.Crunch
--module-name AssetRipper.Conversions.Crunch
--class-name Crunch
--decompile-directory
./AssetRipper.Conversions.Crunch/Generated
```
