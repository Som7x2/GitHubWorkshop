public static bool IsSequenceSorted(List<int> numbers)
{
    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] < numbers[i - 1])
            return false;
    }
    return true;
}
