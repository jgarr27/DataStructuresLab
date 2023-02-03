{
    string word = "";
    Console.WriteLine("Please enter a word you would like to reverse: ");
    word = Console.ReadLine();
    var stack = new Stack<char>();
    foreach(char c in word)
    {
        stack.Push(c);
    }
    word = String.Empty;

    while(stack.Count > 0)
    {
        word += stack.Pop();
    }
    Console.WriteLine(word);
}

