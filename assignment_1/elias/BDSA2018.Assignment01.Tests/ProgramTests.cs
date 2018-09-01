using System;
using System.IO;
using Xunit;

namespace BDSA2018.Assignment01.Tests {
	public class ProgramTests {
		[Fact]
		public void Main_given_add_and_numbers_prints_result() {
			// Arrange
			var writer = new StringWriter();
			Console.SetOut(writer);

			// Act
			Program.Main(new[] {"add", "1,2,3"});

			var output = writer.GetStringBuilder().ToString().Trim();

			// Assert
			Assert.Equal("6", output);
		}

		[Fact]
		public void Main_given_magnitude_and_number_prints_result() {
			// Arrange
			var writer = new StringWriter();
			Console.SetOut(writer);

			// Act
			Program.Main(new[] {"magnitude", "1234"});

			var output = writer.GetStringBuilder().ToString().Trim();

			// Assert
			Assert.Equal("4", output);
		}

		[Fact]
		public void Main_given_no_arguments_prints_help() {
			// Arrange
			var writer = new StringWriter();
			Console.SetOut(writer);

			// Act
			Program.Main(new string[0]);

			var output = writer.GetStringBuilder().ToString().Trim();

			// Assert
			Assert.Equal("Usage: dotnet run [command] \"[argument]\"", output);
		}

		[Fact]
		public void Main_given_bad_arguments_prints_help() {
			// Arrange
			var writer = new StringWriter();
			Console.SetOut(writer);

			// Act
			Program.Main(new[] {"unknown_command", "1,2,3"});

			var output = writer.GetStringBuilder().ToString().Trim();

			// Assert
			Assert.Equal("Command not found. The available commands are: \"add\" and \"magnitude\"", output);
		}
	}
}
