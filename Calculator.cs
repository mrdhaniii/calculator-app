class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penjumlahan: {0} + {1} = {2}", a, b, Penjumlahan(a, b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar")
		Console.ReadKey();
	}
	static int Penjumlahan(int a, int b)
	{
		return a + b;
	}
}