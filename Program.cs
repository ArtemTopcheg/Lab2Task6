//Task6

int[] nums = new int[100];
int count = 0;
Console.WriteLine("Введите массив из 10 значений");
for (int i = 0; i < 10; i++)
{
    int iElement = Convert.ToInt32(Console.ReadLine());
    nums[i] = iElement;

    if (iElement < 0)
    {
        nums[i] = iElement;
        nums[i + 1] = iElement;
        i++;
        count += 2;
    }
    else
    {
        nums[i] = iElement;
        count++;
    }
}
Console.WriteLine("Итоговый массив");
for (int i = 0; i < count; i++)
{
    Console.Write(nums[i] + " ");
}