namespace DeclarandoDelegados
{
	class Program
	{
		delegate bool EsPar(int a);

		static void Main(string[] args)
		{
			EsPar esPar = MetodoEsPar;
		}

		private static bool MetodoEsPar(int a)
		{
			return a % 2 == 0;
		}

	}
}
