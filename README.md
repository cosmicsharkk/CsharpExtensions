# Functionalities:

## Array Extensions:
### 1. Converts an array to string
        Usage:
            var myArrray = new int[] {2,7,11,15}; // could be of any type
            myArray.ArrayToString();
### 2. Converts a Jagged array to string
        Usage:
            int[][] input = {
                new int[] {1,5},
                new int[] {7,3},
                new int[] {3,5}
            };
            Console.WriteLine($"Input is {input.JaggedArrayToString()}");
### 3. Converts a integer Array to LinkedList
        Usage: 
            var head = (new int[] {1,3,6,7,878,8,9,34}).ArrayToLinkedList();

## Linked List Extensions
### 1. Converts a LinkedList to string
        Usage:
            Console.WriteLine($"LinkedList = {head.LinkedListToString()}");

## List Extensions:
### 1. Converts IList to string
        Usage:
            var input = new ArrayList();
            input.Add(45);
            input.Add("Hello");
            input.Add(new List<int>(){34,5,6});
            input.Add(new List<List<int>>(){ new List<int> {1,2,3,4}, new List<int>(){56,67,56,89}});
            input.Add(new List<int>());

            Console.WriteLine($"The output is {input.ListToString()}");
            //The output is [ 45, Hello, [ 34, 5, 6 ], [ [ 1, 2, 3, 4 ], [ 56, 67, 56, 89 ] ], [  ] ]

## Diagnostics:
### 1. Logs execution time of any method to console
        Usage:
            var result = Diagnostics.GetExecutionTime(() => AnyMethod(args));
            //result contains returned values, execution time is logged to console  

