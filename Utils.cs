public class Utils
{
	
	public int Greater(int a, int b)
	{

		if (a>b)
		{
			return a;
		} else if (a<b)
		{
			return b;
		}
		
		return 0;
	}

	public static void Swap(ref int a, ref int b)
	{
		(a, b) = (b, a);
	}

	public static Boolean Factorila(int factorial, out int answ)
	{
		answ = 1;

		try
		{
			checked {
				for (int i = 1; i < factorial  +1; i++)
				{
					answ *= i;
				}
			}
			return true;

		} catch (System.OverflowException ex)
		{
			Console.WriteLine(ex.Message);
		}
			
		return false;
	}

}
