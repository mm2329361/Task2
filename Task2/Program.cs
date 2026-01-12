namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("R - search for a number");
                Console.WriteLine("C - clear the list");
                Console.WriteLine("V - reverse the list");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("Enter your choice:");

                char ch = Convert.ToChar(Console.ReadLine());
                char UpperCh = char.ToUpper(ch);

                if (UpperCh == 'Q')
                {
                    Console.WriteLine("Ok,Good bye!!!");
                    break;
                }


                switch (UpperCh)
                {
                    case 'A':
                        Console.WriteLine("Please enter the size of list:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < x; i++)
                        {
                            Console.WriteLine($"Enter number {i + 1}");
                            int num = Convert.ToInt32(Console.ReadLine());
                            if (!numbers.Contains(num)) { 
                                
                                numbers.Add(num);
                            }
                            else
                            {
                                Console.WriteLine("number is already exist");
                            }
                            

                        }
                        break;

                    case 'P':
                        if (numbers.Count() == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("numbers in list are :");
                            for (int i = 0; i < numbers.Count(); i++)
                            {
                                Console.WriteLine(numbers[i]);
                            }
                        }
                        break;

                    case 'M':
                        if (numbers.Count() == 0)
                        {
                            Console.WriteLine("cannot calculate the mean ,the list is empty");
                            break;
                        }
                        else
                        {
                            int sum = 0;
                            for(int i = 0 ; i < numbers.Count(); i++)
                            {
                                sum += numbers[i];
                            }
                            int mean = sum / numbers.Count();
                            Console.WriteLine($"the mean is : {mean}");
                        }
                        break;
                
                    case 'S':
                        int smallest = numbers[0];
                        for (int i = 0;i<numbers.Count();i++)
                        {
                            if(numbers[i]<smallest)
                            {
                                smallest = numbers[i];
                            }
                        }
                        Console.WriteLine($"The smalest number is :{smallest}");
                        break;

                    case 'L':
                        int largest = numbers[0];
                        for(int i = 0; i < numbers.Count(); i++)
                        {
                            if (numbers[i] > largest)
                            {
                                largest = numbers[i];
                            }
                        }
                        Console.WriteLine($"The largest number is :{largest}");
                        break;

                    case 'C':
                        numbers.Clear();
                        Console.WriteLine("the list is cleared");
                        break;

                    case 'R':
                        Console.WriteLine("Enter the number to search");
                        int searchNum = Convert.ToInt32(Console.ReadLine());
                        bool found = false;
                        for (int i = 0; i < numbers.Count(); i++)
                        {
                            if (numbers[i] == searchNum)
                            {
                                Console.WriteLine($"the index is {i}");
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("The number isn't exist");
                        }
                        break;

                    case 'V':
                        for(int i = 0; i < numbers.Count()/2; i++)
                        {
                            int swap = numbers[i];
                            numbers[i] = numbers[numbers.Count() - i - 1];
                            numbers[numbers.Count() - i - 1] = swap;
                        }
                        break;

                   


                }

            }
        }
    }
}
