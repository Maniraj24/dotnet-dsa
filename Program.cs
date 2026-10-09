
class Program
{
    static string ReverseString(string value)
    {
        char[] chars = value.ToCharArray();
        string reverse = "";
        for (int i = chars.Length - 1; i >= 0; i--)
        {
            reverse += chars[i];
        }
        return reverse;
    }

    static bool IsPalidrome(string value)
    {
        char[] chars = value.ToLower().ToCharArray();
        string reverse = "";
        for (int i = chars.Length - 1; i >= 0; i--)
        {
            reverse += chars[i];
        }
        if (reverse.Equals(value.ToLower()))
            return true;
        else
            return false;
    }

    static string ReverseWord(string value)
    {
        string[] chars = value.Split(" ").ToArray();
        string reverse = "";
        for (int i = chars.Length - 1; i >= 0; i--)
        {
            reverse += $" {chars[i]}";
        }
        return reverse;
    }

    static string ReverseEachWord(string value)
    {
        string[] chars = value.Split(" ").ToArray();
        string reverse = "";
        for (int i = chars.Length - 1; i >= 0; i--)
        {
            reverse = $"{reverse} ";
            for (int j = chars[i].Length - 1; j >= 0; j--)
            {
                reverse += $"{chars[i][j]}";
            }
        }
        return reverse;
    }

    static void CharacterCount(string value)
    {
        Dictionary<char, int> counts = new Dictionary<char, int>();
        foreach (char c in value)
        {
            if (c != ' ')
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts.Add(c, 1);
                }
            }
        }

        foreach (var character in counts)
        {
            Console.WriteLine("{0} - {1}", character.Key, character.Value);
        }
    }

    static string RemoveDuplicate(string value)
    {
        Dictionary<char, int> duplicates = new Dictionary<char, int>();
        string removedStrin = "";
        foreach (char c in value)
        {
            if (!duplicates.ContainsKey(c))
            {
                duplicates.Add(c, 1);
                removedStrin += c;
            }
        }

        return removedStrin;
    }

    static string RemoveDuplicateWords(string value)
    {
        Dictionary<string, int> duplicates = new Dictionary<string, int>();
        string removedStrin = "";
        foreach (string c in value.ToLower().Split(' '))
        {
            if (!duplicates.ContainsKey(c))
            {
                duplicates.Add(c, 1);
                removedStrin += $" {c}";
            }
        }

        return removedStrin;
    }

    static decimal NthHighestSalary(int nthValue)
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee { EmployeeID = 1, Name = "Tom", Salary = 20000 });
        employees.Add(new Employee { EmployeeID = 2, Name = "Bob", Salary = 10000 });
        employees.Add(new Employee { EmployeeID = 3, Name = "Rob", Salary = 30000 });
        employees.Add(new Employee { EmployeeID = 4, Name = "Adam", Salary = 40000 });
        employees.Add(new Employee { EmployeeID = 5, Name = "Tim", Salary = 50000 });
        employees.Add(new Employee { EmployeeID = 6, Name = "Cook", Salary = 55000 });

        decimal nthHighest = employees.OrderByDescending(x => x.Salary).Select(x => x.Salary).Take(nthValue).Skip(nthValue - 1).FirstOrDefault();
        return nthHighest;
    }

    static string ReverseStringinDS(string word)
    {
        string str = "";
        Stack<char> chars = new Stack<char>(word.ToCharArray());
        str = new string(chars.ToArray());
        return str;
    }

    static string ReverseWordinDS(string word)
    {
        string str = "";
        Stack<string> strings = new Stack<string>(word.Split(" "));
        str = string.Join(" ", strings);
        return str;
    }

    static string RemoveDuplicateDS(string value)
    {
        List<char> chars = new List<char>(value.ToCharArray());
        HashSet<char> chars2 = new HashSet<char>(chars);
        return new string(chars2.ToArray());
    }

    static string RemoveDuplicateWordsDS(string value)
    {
        HashSet<string> strings2 = new HashSet<string>(value.ToLower().Split(' '));
        return string.Join(" ", strings2);
    }

    static int[] TwoSumDS(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }
        return [0, 0];
    }

    static string FindPairsWithSum(int[] nums, int target)
    {
        Array.Sort(nums);
        int left = 0; int right = nums.Length - 1; string pairs = "";
        while (left < right)
        {
            int sum = nums[left] + nums[right];
            if (target == sum)
            {
                pairs += $" [{nums[left]}({left}),{nums[right]}({right})]";
                left++; right--;
            }
            else if (target > sum)
                left++;
            else
                right--;
        }
        return pairs;
    }

    static bool PalindromeDS(int x)
    {
        string left = x.ToString();
        Stack<char> chars = new Stack<char>(left.ToCharArray());
        string right = string.Join("", chars);
        return left == right ? true : false;
    }

    static void BinarySearchNumberDS(int target)
    {
        int[] nums = new int[] { 24, 35, 77, 11, 23, 99, 1, 4, 63, 94, 53, 33, 45 };
        Array.Sort(nums);

        int left = 0;
        int right = nums.Length - 1;
        bool found = false;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            Console.WriteLine($"Checking middle index {mid}, value {nums[mid]}");

            if (nums[mid] == target)
            {
                Console.WriteLine($"Found {target} at index {mid}");
                found = true;
                break;
            }
            else if (target < nums[mid])
            {
                Console.WriteLine($"{target} is less than {nums[mid]} → Search LEFT half");
                right = mid - 1;
            }
            else
            {
                Console.WriteLine($"{target} is greater than {nums[mid]} → Search RIGHT half");
                left = mid + 1;
            }
        }

        if (!found)
            Console.WriteLine($"{target} not found in array.");
    }

    public static int RomanToInterger(string s)
    {
        Dictionary<char, int> romanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int currentValue = romanMap[s[i]];

            if (currentValue < prevValue)
            {
                total -= currentValue;
            }
            else
            {
                total += currentValue;
            }

            prevValue = currentValue;
        }

        return total;
    }


    public static int FirstOccurrence(int target)
    {
        int[] arr = { 24, 35, 33, 77, 11, 23, 99, 1, 4, 63, 94, 53, 33, 45 };
        int low = 0, high = arr.Length - 1, ans = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target)
            {
                ans = mid;
                high = mid - 1; // go left
                // low = mid + 1; // go right for last occurence
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return ans;
    }

    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    interface IContractA
    {
        void Show();
    }

    interface IContractB
    {
        void Show();
    }

    class ContractA : IContractA, IContractB
    {
        void IContractA.Show()
        {
            Console.WriteLine("Contract from IContractA");
        }

        void IContractB.Show()
        {
            Console.WriteLine("Contract from IContractB");
        }
    }

    public static void Main(string[] args)
    {
        /*
        string reverse = ReverseString("hello world!");
        bool isPalidrome = IsPalidrome("step on no pets");
        string reverseWord = ReverseWord("Hello, Good Morning!");
        string reverseEachWord = ReverseEachWord("Hello, Good Morning!");
        CharacterCount("Hello");
        string removedString = RemoveDuplicate("Heelloooo");
        string removedStringWords = RemoveDuplicateWords("Hello all, hello everyone!");
        ContractA obj = new ContractA();
        ((IContractA)obj).Show();
        ((IContractB)obj).Show();
        decimal nthHighest = NthHighestSalary(4);
        string reverseStringinDS = ReverseStringinDS("Hello");
        string reverseWordinDS = ReverseWordinDS("Hello all good morning");
        string removedStringDS = RemoveDuplicateDS("Heelloooo");
        string removedStringWordsDS = RemoveDuplicateWordsDS("Hello all, hello everyone!");
        int[] result = TwoSumDS([11, 2, 15, 3, 7, 4], 9); //        Console.WriteLine($"[{result[0]}, {result[1]}]");
        bool palindromeDS = PalindromeDS(-121);
        int romanToInterger = RomanToInterger("MCMXCIV"); 
        BinarySearchNumberDS(33);
        int result = FirstOccurrence(33);
        string findPairsWithSum = FindPairsWithSum([11, 2, 15, 3, 7, 6, 4], 9);
        */
    }
}
