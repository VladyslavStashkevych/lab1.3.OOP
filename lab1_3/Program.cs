namespace lab1_3 {
	internal static class Program {
		static void Main(string[] args) {
			VectorN s = new VectorN();
			s.Init(3, new double[] { 1, 2, 3 });
			Console.WriteLine("Vector s:");
			s.Display();
			Console.WriteLine("Vector s after changes (s + s):");
			s = s.Add(s);
			s.Display();
			Console.WriteLine($"Scalar (s, s): {s.Scalar(s)}\n");

			VectorN v = new VectorN();
			v.Read();
			Console.WriteLine("Vector V:");
			v.Display();
			Console.WriteLine("Vector S:");
			s.Display();
			Console.WriteLine("Vector C = S - V:");
			s = s.Substract(v);
			s.Display();
			Console.WriteLine($"Scalar (s, v): {s.Scalar(v)}");
		}
	}
}