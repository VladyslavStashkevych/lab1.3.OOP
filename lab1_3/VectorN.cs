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

		public void Init(int N, double[] A) {
			this.N = N;
			this.A = A;
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
		public string VectorToString()
				=> String.Join(" ", A.Select(c => $"{c}"));
	}
}
