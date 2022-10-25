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
                var myClass = new Cat();

                Console.WriteLine("Enter the value for ");
                myClass. = Console.ReadLine();


                recordList.Add(Cat);
            }

            // Print out the list of records using Console.WriteLine()
        }
    }
}