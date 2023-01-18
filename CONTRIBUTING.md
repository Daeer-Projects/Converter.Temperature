# How to contribute

I'm really glad you're reading this because we (I) need volunteer developers to help this project get to the 'feature complete' stage.

I have done most of the temperature scales, but there are a few 'old' scales that still need adding.

More details of what the library does, and what features to add can be found on the [wiki](https://github.com/daeer73/Converter.Temperature/wiki).

## Testing

There are a few unit tests using the XUnit framework.

* Use XUnit
* Use FluentAssertions
* Use NSubstitute
* Use Arrange, Act and Assert pattern

## Submitting changes

We welcome changes and help with any of the issues that have been raised.  Some of the issues will have questions that can be answered by anyone.  Good suggestions will be considered and accepted by the repository owner.

We would like you to follow these guidelines:

1. Create a branch for the issue you are working on.
2. Create the change you feel is right.
3. Commit small and commit often.
4. Always write a clear log message for your commits.
5. Add unit tests around the changes you have made.

## Coding conventions

Start by reading the code base and you will notice how things should be laid out.  We optimise for readability.

* Use spaces, not tabs
* Don't use `var`, use the defined type and the new `new()` style
* Follow the SOLID/CUPID principles
* Investigate the options shown in the IDE/ReSharper -> if it looks good, use it, if it becomes unreadable, then don't
* Usings within the namespace
  * `System` usings first
* Constructors will be the first item in a class
* Write unit tests as much as possible using the "Arrange/Act/Asset" pattern.

## Conclusion

The project is here to help convert between temperature scales.  I'm trying to make the conversion scales as complete as possible.

All contributions will be appreciated.

Thanks,

David Clark.
