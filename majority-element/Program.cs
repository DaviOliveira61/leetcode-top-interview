int[] nums = [3, 2, 3];
int[] nums2 = [2, 3, 2, 3, 2, 3, 4, 5, 5, 5, 1, 2, 3, 1, 5, 3, 4, 5, 5]; // Teste que quebra geral

// MajorityElement(nums);
Console.WriteLine($"Final: {MajorityElement(nums2)}");

int MajorityElement(int[] nums)
{
    var dic = new Dictionary<int, int>();
    foreach (var num in nums)
    {
        if (!dic.ContainsKey(num))
            dic.Add(num, 1);
        else
            dic[num] += 1;
    }
    int majority = dic.Values.Max();

    return dic.First(k => k.Value == majority).Key;
}
