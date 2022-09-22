using System.Collections.Immutable;

namespace Implementation
{
    public class Permutation
    {
        /// <summary>
        /// In mathematics, a permutation of a set is, loosely speaking, an arrangement of its members into a sequence
        /// or linear order, or if the set is already ordered, a rearrangement of its elements. The word "permutation"
        /// also refers to the act or process of changing the linear order of an ordered set.
        ///
        /// Function receives a string as an input and it is supposed to create all possible permutations of characters
        /// in that string.
        ///
        /// Output list should not contain duplicates
        /// Permutations should have same length as a input and contain same characters
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static IReadOnlyCollection<string> Permutate(string str)
        {
            var permutations = new List<string>();
            if (str.Length == 1)
            {
                permutations.Add(str);
            }
            else
            {
                foreach (var item in str)
                {
                    var tail = str.Remove(str.IndexOf(item), 1); // Remove one occurrence of the char (not all)
                    foreach (var tailItems in Permutate(tail))
                    {
                        if (!permutations.Contains(item + tailItems)) //check for duplicate
                        {
                            permutations.Add(item + tailItems);
                        }
                    }
                }
            }
            return permutations;
        }
    }
}
