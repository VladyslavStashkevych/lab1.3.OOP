using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3 {
	public class VectorN {
		int N { get; set; }
		public double[] A { get; set; }

		public void Init(int N, double[] A) {
			this.N = N;
			this.A = A;
		}

		public bool Add(VectorN v) {
			if (this.N != v.N) {
				Console.WriteLine("Vectors should have same size");
				return false;
			}
			for (int i = 0; i < this.N; i++) {
				this.A[i] += v.A[i];
			}
			return true;
		}

		public bool Substract(VectorN v) {
			if (this.N != v.N) {
				Console.WriteLine("Vectors should have same size");
				return false;
			}
			for (int i = 0; i < this.N; i++) {
				this.A[i] -= v.A[i];
			}
			return true;
		}

		public double Scalar(VectorN v) {
			double result = 0;
			if (this.N != v.N) {
				Console.WriteLine("Vectors should have same size");
				return result;
			}
			for (int i = 0; i < this.N; i++) {
				result += this.A[i] * v.A[i];
			}
			return result;
		}

		public void Read() {
			Console.Write("Enter number of elements: ");
			this.N = Convert.ToInt32(Console.ReadLine());
			this.A = new double[N];
			for (int i = 0; i < this.N; i++) {
				Console.Write($"Enter numnber {i + 1}:");
				A[i] = Convert.ToDouble(Console.ReadLine());
			}
			Console.WriteLine();
		}

		public void Display() {
			Console.WriteLine(this.VectorToString());
		}

		public string VectorToString() => String.Join(" ", A.Select(c => $"{c}"));
	}
}
