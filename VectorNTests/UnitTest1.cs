using lab1_3;
using Xunit;

namespace VectorNTests {
	public class Tests {
		[Theory]
		[InlineData(new double[] { 3, 2, 1 }, new double[] { 3, 2, 1 })]
		[InlineData(new double[] { 0, 3.1, -4 }, new double[] { 1.2, -3, 5 })]
		public void Method_Add_ReturnsCorrectValue(double[] a, double[] f) {
			// Arrange
			VectorN s = new VectorN();
			VectorN v = new VectorN();
			double[] res = new double[a.Length];
			s.Init(a.Length, a);
			v.Init(f.Length, f);
			for (int i = 0; i < a.Length; i++)
				res[i] = a[i] + f[i];

			// Act
			VectorN result = s.Add(v);

			// Assert
			Assert.Equal(res, result.A);
		}
		[Theory]
		[InlineData(new double[] { 3, 2, 1 }, new double[] { 3, 2, 1 })]
		[InlineData(new double[] { 0, 3.1, -4 }, new double[] { 1.2, -3, 5 })]
		public void Method_Substact_ReturnsCorrectValue(double[] a, double[] f) {
			// Arrange
			VectorN s = new VectorN();
			VectorN v = new VectorN();
			double[] res = new double[a.Length];
			s.Init(a.Length, a);
			v.Init(f.Length, f);
			for (int i = 0; i < a.Length; i++)
				res[i] = a[i] - f[i];

			// Act
			VectorN result = s.Substract(v);

			// Assert
			Assert.Equal(res, result.A);
		}
		[Theory]
		[InlineData(new double[] { 3, 2, 1 }, new double[] { 3, 2, 1 })]
		[InlineData(new double[] { 0, 3.1, -4 }, new double[] { 1.2, -3, 5 })]
		public void Method_Scalar_ReturnsCorrectValue(double[] a, double[] f) {
			// Arrange
			VectorN s = new VectorN();
			VectorN v = new VectorN();
			s.Init(a.Length, a);
			v.Init(f.Length, f);
			double result = 0;
			for (int i = 0; i < a.Length; i++)
				result += a[i] * f[i];

			// Act
			double actual = s.Scalar(v);

			// Assert
			Assert.Equal(result, actual);
		}
	}
}