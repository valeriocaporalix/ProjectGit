using FluentAssertions;
using GitProject.Models;

namespace UnitTests.Models;

public class PeopleTests
{
    [Fact]
    public void InitializingPeopleShouldSetExampleMailWithNameAndLastName()
    {
        var prople = new People() { Name = "Mario", LastName = "Rossi" };
        prople.Email.Should().Be("mario.rossi@example.com");
    }

    [Fact]
    public void InitializingPeopleShouldSetExampleMailToNullWhenNameOrLastNameIsNotProvided()
    {
        var prople = new People() { Name = "Mario" };
        prople.Email.Should().BeNull();
    }
}