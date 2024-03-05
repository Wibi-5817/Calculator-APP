class Calculator
{
	static void Main(string[] args)
	{
		 if (menu == 1)
            {
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + penambahan(a, b));
            }
            else(menu == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, pengurangan(a, b));
            }
	}
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	 static int penambahan(int a, int b)
    {
            return a + b;
    }
        static int pengurangan(int a, int b)
    {
            return a - b;
    }
}