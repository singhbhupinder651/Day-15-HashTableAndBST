namespace HashTableAndBST
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to HashTable and Binary Search Tree Problems");
            Console.WriteLine("Use Case #1: Create a Binary Search Tree");
            Console.WriteLine("Use Case #2: Create the Binary Tree shown in figure");
            Console.WriteLine("Use Case #3: Search 63 in Binary Tree");

            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BinarySearchTree<int> treeOne = new BinarySearchTree<int>(56);
                    treeOne.Insert(30);
                    treeOne.Insert(70);
                    treeOne.Display();
                    break;
                case 2:
                    BinarySearchTree<int> treeTwo = new BinarySearchTree<int>(56);
                    treeTwo.Insert(30);
                    treeTwo.Insert(70);
                    treeTwo.Insert(22);
                    treeTwo.Insert(40);
                    treeTwo.Insert(60);
                    treeTwo.Insert(95);
                    treeTwo.Insert(11);
                    treeTwo.Insert(65);
                    treeTwo.Insert(3);
                    treeTwo.Insert(16);
                    treeTwo.Insert(63);
                    treeTwo.Insert(67);
                    treeTwo.Display();
                    Console.WriteLine("-------------------------------");
                    treeTwo.GetSize();
                    Console.WriteLine("-------------------------------");
                    break;
                case 3:
                    BinarySearchTree<int> treeThree = new BinarySearchTree<int>(56);
                    treeThree.Insert(30);
                    treeThree.Insert(70);
                    treeThree.Insert(22);
                    treeThree.Insert(40);
                    treeThree.Insert(60);
                    treeThree.Insert(95);
                    treeThree.Insert(11);
                    treeThree.Insert(65);
                    treeThree.Insert(3);
                    treeThree.Insert(16);
                    treeThree.Insert(63);
                    treeThree.Insert(67);
                    bool result = treeThree.IfExists(63, treeThree);
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }


        }
    }
}