# README

> Converter.Temperature
> This project was created to extract out the main conversion code from the *Temperature Converter* applications in the other repositories.
> I am using this as a way to show how my development skills have changed over the years, as I get to be a better developer.

## Introduction

These extension methods will convert different types of temperatures to other types.

### Temperature types

* Celsius
* Fahrenheit
* Kelvin
* Gas

## Ideas

I had a few ideas on how to do the extension methods, but decided on using a fluent style.

Originally, the extensions looked like this:

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.CelsiusToFahrenheit();
```

Then I thought that this looked a bit naf, so went with setting up the *from* first, then the *to*.

Now it is used like this:

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromCelsius().ToFahrenheit();
```

## Road Map

I have the code working mostly, but I am going through unit tests to check the code *does actually* work!

1. Add unit tests to prove the code base.
2. Add tests for extremes.
3. Add extra error checking for the extremes.
4. Set up the AppVeyor build.
5. Add to NuGet.