namespace Bubble_Sort_APP;

public class Program
{
    static void Main()
    {
        
    }

    public static int[] BubleSort(int[] intArr)
    {
        if (intArr == null) throw new ArgumentNullException();

        int swapValue = 0;
        bool isDone = false;
        while (!isDone)
        {
            isDone = true;
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                if (intArr[i] > intArr[i + 1])
                {
                    swapValue = intArr[i];
                    intArr[i] = intArr[i + 1];
                    intArr[i + 1] = swapValue;
                    isDone = false;
                }
            }
        }

        return intArr;
    }

    public static int[] BubleSort2(int[] arr1, int[] arr2)
    {
        if (arr1 == null || arr2 == null) throw new ArgumentNullException();
        else if (arr1.Length == 0 && arr2.Length == 0) return new int[] { };

        int[] resultArr = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            resultArr[i] = arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            resultArr[arr1.Length + i] = arr2[i];
        }

        return BubleSort(resultArr); ;
    }


    public static int[] MergeSort(int[] num)
    {
        //int[] result = new int[num.Length];
        if(num.Length == 1)
        {
            return num;
        }
        else
        {
            //split the array
            int[] leftArray = num.Take(num.Length/2).ToArray();
            int[] rightArray = num.Sk(num.Length/2).ToArray();

            //merge sort left
            //merge sort right

            //merge both arrays

            //return merged array
        }

        return result;
    }
}