namespace SortedListCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //creation of sortedlist  
            SortedList<int, string> goalsList = new()
            {
                //add the elements in sortedlist  
                { 1, "Finish School" },
                { 2, "Vacation" },
                { 3, "Dream Job" },
                { 4, "Travel" },
                { 5, "Become a kick-ass grandma" }
            };
            //display the elements of the sortedlist  
            Console.WriteLine("The items in the sorted goal list are:");
            foreach (KeyValuePair<int, string> gl in goalsList)
            {
                Console.WriteLine($"Key = {gl.Key}  Value = {gl.Value}");
            }
            Console.WriteLine("What is the priority number of the goal you want to add?");
            int priority = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your goal?");
            string goal = Console.ReadLine();
            //check for value in list
            if (goalsList.ContainsValue(goal))
            {
                Console.WriteLine($"{priority} is one of the values in your list");
            }
            else
            {
                // check for goal key in list (can't have dups)
                if (goalsList.ContainsKey(priority))
                {
                    Console.WriteLine($"You can only have 1 priority level {priority} ");
                    _ = goalsList.Remove(priority);
                    goalsList.Add(priority, goal);
                    Console.WriteLine($"Your current goal, in priority {priority} has been removed and {goal} has been added");
                }
                else
                {
                    goalsList.Add(priority, goal);
                    Console.WriteLine("{priority} {goal} was added to your list");
                }
            }
            Console.WriteLine("The items in the new goal list are:");
            foreach (KeyValuePair<int, string> gl in goalsList)
            {
                Console.WriteLine($"Key = {gl.Key}  Value = {gl.Value}");
            }
        }
    }
}