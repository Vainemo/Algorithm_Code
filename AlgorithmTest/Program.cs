namespace AlgorithmTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aa = new int[] { 1,2,3,4,5,6,7,8};
            int b=Search(aa, -1);
            Console.WriteLine(b);
        }
        public static int Search(int[] ints, int Target)
        {
            
            int left = 0;
            int right=ints.Length-1;
            int Middle;
            //定搜索边界
           while (left <= right) 
            {
                Middle =left+(right- left) / 2;
                if (Target<ints[Middle]) 
                {
                    right = Middle-1;
                }
                if (Target> ints[Middle])
                {
                    left = Middle+ 1;
                }
                if (Target == ints[Middle])
                {
                    return Middle;
                }
            }
            return -1;
        }
    }
    
}