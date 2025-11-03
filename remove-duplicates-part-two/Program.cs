int[] numbers = [1, 1, 1, 2, 2, 3];

int k = RemoveDuplicates(numbers);

Console.WriteLine(k);

int RemoveDuplicates(int[] nums)
{
    int count = 0, current = 1;

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i - 1])
        {
            count = 0;
            nums[current++] = nums[i];
        }
        else
        {
            count++;
            if (count <= 1)
            {
                nums[current++] = nums[i];
            }
        }
    }
    return current;
}
