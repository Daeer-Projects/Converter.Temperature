# README

> Converter.Temperature
> This project was created to extract out the main conversion code from the *Temperature Converter* applications in the other repositories.
> I am using this as a way to show how my development skills have changed over the years, as I get to be a better developer.

[![Build Status](https://dev.azure.com/DaeerProjects/Converter.Temperature/_apis/build/status/Daeer-Projects.Converter.Temperature?branchName=main)](https://dev.azure.com/DaeerProjects/Converter.Temperature/_build/latest?definitionId=12&branchName=main)

## Introduction

These extension methods will convert different types of temperatures to other types.

### Temperature types

* Celsius
* Fahrenheit
* Kelvin
* Gas
* Rankine

### Data types

* int
* long
* float
* double
* string

## Ideas

I had a few ideas on how to do the extension methods but decided on using a fluent style.

Originally, the extensions looked like this:

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.CelsiusToFahrenheit();
```

Then I thought that this looked a bit naf so, I went with setting up the *from* first, then the *to*.  This follows the *fluent* pattern.

Now it is used like this:

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromCelsius().ToFahrenheit();
```

The next stage for version 2 is to add an additional usage like this:

```csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.From<Celsius>().To<Fahrenheit>();
```

### What to do for edge cases

I'm working on what I want the library to do when an exception could be thrown.  This is when we have the edge cases of values that are too small or too large for the type being converted to.

E.g.:

From a float type with a value close to the max value of a float, converted from Celsius to Fahrenheit.  Because a Fahrenheit value is greater than the celsius value, then we can't convert correctly.

Should this throw an exception or just return the original value?

Well, returning the same value would seem like all is well, even though the converted value is wrong.  Thinking about this means that for me, it should throw an exception for the calling application to handle.

If anyone has any better ideas, then I would be willing to change this behaviour.

## More Information

For more information on the project and where it is heading, see the [wiki](https://github.com/daeer73/Converter.Temperature/wiki).
