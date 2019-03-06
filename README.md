# CSharp-Book-1-Chapter-4-Common-Types-Lists-Random-Numbers
(Done)- Exercise for understanding common lists. Random Numbers.

Practice: Random Numbers
Instructions
Use the following code to create a list of random numbers. Each number will be between 0 and 9.
Random random = new Random();
List<int> numbers = new List<int> {
    random.Next(10),
    random.Next(10),
    random.Next(10),
    random.Next(10),
    random.Next(10),
};
Use a for loop to iterate over all numbers between 0 and numbers.Count - 1.
Inside the body of the for loop determine if the current loop index is contained inside of the numbers list. Print a message to the console indicating whether the index is in the list.
Example Output in the Terminal
numbers list contains 0
numbers list does not contain 1
numbers list does not contain 2
numbers list contains 3
numbers list contains 4
NOTE: Each run will produce different output.

Further Reading Random class in .net
