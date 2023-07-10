namespace GenericsPractiseList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till min PractisList class!");

            // Int
            var myPractiseListClassInt = new PracticeList<int>();
            myPractiseListClassInt.Add(1);
            myPractiseListClassInt.Add(2);
            myPractiseListClassInt.Add(3);

            var itemsInt = myPractiseListClassInt.GetItems();

            for (int i = 0; i < itemsInt.Length; i++)
            {
                Console.WriteLine($"int List index position {i}: {itemsInt[i]}");
            }

            // String
            var myPractiseListClassString = new PracticeList<string>();
            myPractiseListClassString.Add("Richard");
            myPractiseListClassString.Add("Stefan");
            myPractiseListClassString.Add("Sebastian");

            var itemString = myPractiseListClassString.GetItem(2);

            Console.WriteLine($"string List {2+1} item: {itemString}");
        }
    }
}