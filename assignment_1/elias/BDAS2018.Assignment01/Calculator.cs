using System;

namespace BDSA2018.Assignment01 {
	public class Calculator {
		public static int Add(string numbers) {
			if (string.IsNullOrWhiteSpace(numbers)) {
				return 0;
			}

			var tokens = numbers.Split(',');

			var result = 0;

			foreach (var token in tokens) {
				var number = int.Parse(token);

				if (number < 0) {
					throw new ArgumentException("Negative numbers are not allowed");
				}

				result += number;
			}

			return result;
		}

		public static int Magnitude(string number) {
			if (long.TryParse(number, out var x)) {
				return x == 0 ? 1 : (int) Math.Floor(Math.Log10(Math.Abs(x)) + 1);
			}

			return -1;
		}
	}
}
