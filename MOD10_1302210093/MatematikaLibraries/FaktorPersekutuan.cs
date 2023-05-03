namespace MatematikaLibraries
{
    public class FaktorPersekutuan
    {
        public int FaktorPersekutuanTerbesar(int input1, int input2)
        {
            int temp;
            while (input2 != 0)
            {
                temp = input2;
                input2 = input1 % input2;
                input2= temp;
            }
            return input1;
        }
        public int KelipatanPersekutuanTerkecil(int input1, int input2)
        {
            int max;
            int min;
            int result;
            max = Math.Max(input1, input2);
            min = Math.Min(input1, input2);
            result = max;
            while (result % min != 0)
            {
                result = result + max;
            }
            return result;
        }
        public string Turunan(int[] persamaan)
        {
            int n;
            int i;
            string result;
            n = persamaan.Length - 1;
            int[] turunan = new int[n];
            for (i = 1; i < n; i++)
            {
                turunan[i] = persamaan[i] * (n - i);
            }
            result = turunan[0] + "x^" + (n - 1);
            for (i = 1; i < n; i++)
            {
                if (turunan[i] > 0)
                {
                    result = result + " + " + turunan[i] + "x" + (n - i - 1);
                } 
                else if (turunan[i] < 0)
                {
                    result = result + " - " + (-turunan[i]) + "x" + (n - i - 1);
                }
            }
            return result; 
        }
        public string Integral(int[] persamaan)
        {
            int n;
            int i;
            string result;
            n = persamaan.Length;
            int[] integral = new int[n + 1];
            for (i = 1; i <= n; i++)
            {
                integral[i] = persamaan[i - 1] / i;
            }
            result = "C";
            for (i = n; i >= 0; i--)
            {
                if (integral[i] > 0)
                {
                    result = "+" + integral[i] + "x" + (i + 1) + result;
                }
                else if (integral[i] < 0)
                {
                    result = integral[i] + "x^" + (i + 1) + result;
                }
            }
            return result;
        }
    }
}