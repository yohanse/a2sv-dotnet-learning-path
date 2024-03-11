class Task3 {
    static void Method() {
        Console.WriteLine("Enter Word: ");
        string String = Console.ReadLine() ?? "";
        int left = 0;
        int right = String.Length - 1;

        bool flag = true;
        while(right > left) {
            if (!char.IsLetterOrDigit(String[left])) {
                left++;
            }

            else if (!char.IsLetterOrDigit(String[right])) {
                right--;
            }
            else {
                if(char.ToLower(String[left]) != char.ToLower(String[right])){
                    flag = false;
                    break;
                }
                left++;
                right--;
            }
        }
        Console.WriteLine(flag);
    }
}
