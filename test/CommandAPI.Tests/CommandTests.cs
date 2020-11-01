using System;
using CommandAPI.Models;
using Xunit;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some platform",
                CommandLine = "Some commandline"
            };

        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            // arrange

            // act
            testCommand.HowTo = "Execute Unit Tests";

            // assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatfom()
        {
            // arrange

            // act
            testCommand.Platform = "xUnit";

            // assert
            Assert.Equal("xUnit", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            // arrange

            // act
            testCommand.CommandLine = "dotnet test";

            // assert
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }
    }
}
