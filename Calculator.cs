class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 7;
		
		Console.Writeline("Hasil penambahan : {0} + {1} = {2} ",a ,b , Penambahan(a,b));
		ConsoleConsole.Writeline("Hasil penambahan : {0} + {1} = {2} ",a ,b , Penambahan(a,b));
		
		Console.Writeline("\n Tekan sembarang untuk keluar");
		Console.Readkey();
	}
	
	static int Penambahan (int a, int b)
	{
		return a + b;
	}
	static int Pengurangan (int a, intb)
	{
		return a - b;
	}
}