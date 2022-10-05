namespace Bubble_Sort_APP;

public class Program
{
    static void Main()
    {

    }
    public static int[] BubleSort(int[] intArr)
    {
        if (intArr == null) throw new ArgumentNullException();
        if (intArr.Length <= 0) throw new ArgumentOutOfRangeException();

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
        int[] result = new int[num.Length];
        if(num.Length == 1)
        {
            return num;
        }
        else
        {
            int[] lArray = num.Take(num.Length/2).ToArray();
            int[] rArray = num.Skip(num.Length/2).ToArray();

            var lTemp = MergeSort(lArray);
            var rTemp = MergeSort(rArray);

            #region Mess...
            //int lIndex = 0; int rIndex = 0; int resultIndex = 0;
            //int smallLValue = 0; int smallRValue = 0;

            //int lIndexTemp = 0;
            //while (lTemp.Length > lIndex || rTemp.Length > rIndex)
            //{
            //    lIndexTemp = lIndex;

            //    lIndex = 0;
            //    // Smallest in lArr...
            //    for(int i = 0; i < lTemp.Length; i++)
            //    {
            //        if (lTemp[lIndex] > lTemp[i])
            //        {
            //            smallLValue = lTemp[i];
            //            lTemp[i] = int.MaxValue;
            //        }
            //        else
            //        {
            //            smallLValue = lTemp[lIndex];
            //            lTemp[lIndex] = int.MaxValue;
            //        }
            //    }

            //    lIndex = 0;
            //    // Smallest in rArr...
            //    for (int i = 0; i < rTemp.Length; i++)
            //    {
            //        if (rTemp[lIndex] > rTemp[i])
            //        {
            //            smallRValue = rTemp[i];
            //            rTemp[i] = int.MaxValue;
            //        }
            //        else
            //        {
            //            smallRValue = rTemp[lIndex];
            //            rTemp[lIndex] = int.MaxValue;
            //        }
            //    }

            //    lIndex.t
            //    if (smallLValue > smallRValue)
            //    {
            //        result[]
            //    } 
            #endregion

            return BubleSort2(lTemp, rTemp);
        }
    }
}