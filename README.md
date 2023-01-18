# README

> Converter.Temperature
> This project was created to extract out the main conversion code from the *Temperature Converter* applications in the other repositories.
> I am using this as a way to show how my development skills have changed over the years, as I get to be a better developer.

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

[![Build Status](https://dev.azure.com/DaeerProjects/Converter.Temperature/_apis/build/status/Daeer-Projects.Converter.Temperature?branchName=main)](https://dev.azure.com/DaeerProjects/Converter.Temperature/_build/latest?definitionId=12&branchName=main)

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#introduction">Introduction</a>
      <ul>
        <li><a href="#temperature-types">Temperature Types</a></li>
        <li><a href="#data-types">Data Types</a></li>
        <li><a href="#built-with">Built With</a></li>
        <li><a href="#how-to-get-setup">How to get setup</a></li>
      </ul>
    </li>
    <li>
        <a href="#how-to-use-the-library">How to use the library</a>
        <ul>
            <li><a href="#ideas">Ideas</a></li>
            <li><a href="#what-to-do-for-edge-cases">What to do for edge cases</a></li>
      </ul>
    </li>
    <li>
        <a href="#credits">Credits</a>
        <ul>
            <li><a href="#acknowledgments">Acknowledgments</a></li>
        </ul>
    </li>
    <li><a href="#license">License</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#testing">Testing</a></li>
  </ol>
</details>

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

### Built With

This library is built using the following tech stacks.

* ![DotNet](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
* ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

### How to get setup

The project is a Visual Studio solution (`.sln`).

1. Fork, clone or download the repo.
2. Open the solution in your favourite IDE (VS, Rider, VSCode, etc).
3. Build the solution.
4. Run the unit tests.

## How to use the library

There are more details on the project [wiki](https://github.com/Daeer-Projects/Converter.Temperature/wiki).

The details contained on the [wiki](https://github.com/Daeer-Projects/Converter.Temperature/wiki) are more comprehensive.  This document is to show you how I decided the library should be consumed.

### Ideas

To start with, I had a few ideas on how to do the extension methods but decided on using a fluent style.  This is a common style used in development.  I also think it looks nicer.

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

For version 2 I added an additional usage like this:

```csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.From<Celsius>().To<Fahrenheit>();
```

Before you decide which one is best for you, don't forget to check the benchmark results [here](https://github.com/Daeer-Projects/Converter.Temperature/wiki/Benchmark-Results).

### What to do for edge cases

I'm working on what I want the library to do when an exception could be thrown.  This is when we have the edge cases of values that are too small or too large for the type being converted to.

E.g.:

From a float type with a value close to the max value of a float, converted from Celsius to Fahrenheit.  Because a Fahrenheit value is greater than the celsius value, then we can't convert correctly.

Should this throw an exception or just return the original value?

Well, returning the same value would seem like all is well, even though the converted value is wrong.  Thinking about this means that for me, it should throw an exception for the calling application to handle.

If anyone has any better ideas, then I would be willing to change this behaviour.

## More Information

For more information on the project and where it is heading, see the [wiki](https://github.com/daeer73/Converter.Temperature/wiki).

## Credits

I am the sole creator of this library/project.  However, I should credit "Google" and "Wikipedia" for helping with the conversion calculations.

## Acknowledgements

* [Othneil Drew - Best README Template](https://github.com/othneildrew/Best-README-Template/blob/master/README.md)
* [Shields IO](https://shields.io)

## License

This repo and library are using the MIT license.

## Contributing

See the included [Contributing File](https://github.com/Daeer-Projects/Converter.Temperature/blob/main/CONTRIBUTING.md) for more information.

## Contact

David Clark - [@CoderDaeer](https://twitter.com/CoderDaeer)

Daeer-Projects - [Daeer Projects](https://github.com/Daeer-Projects)

## Testing

The project does have a unit test project that covers as much as possible of the code base.

There is also a benchmark project that shows how the conversions perform.

This will show more usages and examples of how to consume the library.

[contributors-shield]: https://img.shields.io/github/contributors/Daeer-Projects/Converter.Temperature?style=flat-square
[contributors-url]: https://github.com/Daeer-Projects/Converter.Temperature/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Daeer-Projects/Converter.Temperature?style=flat-square
[forks-url]: https://github.com/Daeer-Projects/Converter.Temperature/network/members
[stars-shield]: https://img.shields.io/github/stars/Daeer-Projects/Converter.Temperature?style=flat-square
[stars-url]: https://github.com/Daeer-Projects/Converter.Temperature/stargazers
[issues-shield]: https://img.shields.io/github/issues/Daeer-Projects/Converter.Temperature?style=flat-square
[issues-url]: https://github.com/Daeer-Projects/Converter.Temperature/issues
[license-shield]: https://img.shields.io/github/license/Daeer-Projects/Converter.Temperature?style=flat-square
[license-url]: https://github.com/Daeer-Projects/Converter.Temperature/blob/main/LICENSE
