using System;

namespace BDSA2018.Assignment01 {
	public class Program {
		public static void Main(string[] args) {
			if (args.Length < 2) {
				Console.WriteLine("Usage: dotnet run [command] \"[argument]\"");
				return;
			}

			var command = args[0];
			var param = args[1];

			switch (command) {
				case "add":
					Console.WriteLine(Calculator.Add(param));
					break;
				case "magnitude":
					Console.WriteLine(Calculator.Magnitude(param));
					break;
				default:
					Console.WriteLine("Command not found. The available commands are: \"add\" and \"magnitude\"");
					break;
			}
		}
	}
}
