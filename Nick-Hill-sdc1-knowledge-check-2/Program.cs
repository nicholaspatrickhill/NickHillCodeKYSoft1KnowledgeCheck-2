namespace Nick_Hill_sdc1_knowledge_check_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Cat>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var cat = new Cat();

                Console.WriteLine("Enter the value for Name");
                cat.Name = Console.ReadLine();

                Console.WriteLine("Enter the value for Color");
                cat.Color = Console.ReadLine();

                recordList.Add(new Cat() { Name = cat.Name, Color = cat.Color });
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var cat in recordList)
            Console.WriteLine("Your cat is named " + cat.Name + " and it is " + cat.Color + " in color.");
        }
    }
}