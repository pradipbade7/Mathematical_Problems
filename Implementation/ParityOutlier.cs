namespace Implementation
{
    public class ParityOutlier
    {
        /// <summary>
        /// Method receives list of integers as a parameter where all other numbers have same parity(even or odd),
        /// but one number differs from the rest return that number.
        /// </summary>
        /// <param name="integers"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int Outlier(IReadOnlyCollection<int> integers)
        {
            int modsum = integers.Take(3).ToArray().Select(i => i % 2).Sum();
            int mod = modsum>1 ? 0 : 1; //if mod=0 odd list, if mod = 1 even list  
            return integers.FirstOrDefault(i => Math.Abs(i) % 2 == mod);
        }
    }
}
