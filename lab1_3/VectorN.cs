namespace lab1_3 {
	public class VectorN {
		int n;
		public int N {
			get => n;
			set {
				if (value >= 0) {
					n = value;
					A = new double[n];
				}
			}
		}
		public double[] A { get; set; }

		public bool Init(int N, double[] A) {
			if (N > 0) {
				this.N = N;
				this.A = A;
				return true;
			}
			return false;
		}
		
		public VectorN Add(VectorN v) {
			VectorN result = new VectorN();
			if (this.N != v.N) {
				Console.WriteLine("Vectors should have same size");
				return result;
			}
			result.N = this.N;
			for (int i = 0; i < this.N; i++) {
				result.A[i] = this.A[i] + v.A[i];
			}
			return result;
		}
		public VectorN Substract(VectorN v) {
			VectorN result = new VectorN();
			if (this.N != v.N) {
				Console.WriteLine("Vectors should have same size");
				return result;
			}
			result.N = this.N;
			for (int i = 0; i < this.N; i++) {
				result.A[i] = this.A[i] - v.A[i];
			}
			return result;
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
			bool initExecuted = false;
			do {
				Console.Write("Enter number of elements: ");
				int n = Convert.ToInt32(Console.ReadLine());
				double[] a = new double[n];
				for (int i = 0; i < n; i++) {
					Console.Write($"Enter numnber {i + 1}:");
					a[i] = Convert.ToDouble(Console.ReadLine());
				}
				Console.WriteLine();
				if (Init(n, a)) {
					initExecuted = true;
				}
				else {
					Console.WriteLine("Number of elements should be greater than zero!");
					Console.WriteLine("Please, try again");
				}
			} while (!initExecuted);
		}
		public void Display() {
			Console.WriteLine(this.VectorToString());
		}
		public string VectorToString()
				=> String.Join(" ", A.Select(c => $"{c}"));
	}
}
