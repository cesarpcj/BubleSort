using Bubble_Sort_APP;
using NUnit.Framework.Internal;

namespace Bubble_Sort_Tests;

public class Tests
{
    #region BubleSort...
    [Test]
    public void GivenAnNullArray_BubleSort_Throws_ArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Program.BubleSort(null));
    }

    [Test]
    public void GivenAnEmptyArray_BubleSort_Throws_ArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Program.BubleSort(new int[] { }));
    }

    [TestCase(new int[] { 5, 2, 5, 7, 12 }, new int[] { 2, 5, 5, 7, 12 })]
    [TestCase(new int[] { 8, 22, 15, 40, 65 }, new int[] { 8, 15, 22, 40, 65 })]
    [TestCase(new int[] { 500, 100, 1002, 750, 1 }, new int[] { 1, 100, 500, 750, 1002 })]
    public void GivenAnOnlyPositiveIntArray_BubleSort_Returns_SortedArray(int[] inputArr, int[] outputArr)
    {
        Assert.That(Program.BubleSort(inputArr), Is.EqualTo(outputArr));
    }

    [TestCase(new int[] { -25, -132, -51, -74, -12 }, new int[] { -132, -74, -51, -25, -12 })]
    [TestCase(new int[] { -18, -21, -35, -40, -42 }, new int[] { -42, -40, -35, -21, -18 })]
    [TestCase(new int[] { -300, -450, -12, -150, -1043 }, new int[] {-1043, -450, -300, -150, -12 })]
    public void GivenAnOnlyNegativeIntArray_BubleSort_Returns_SortedArray(int[] inputArr, int[] outputArr)
    {
        Assert.That(Program.BubleSort(inputArr), Is.EqualTo(outputArr));
    }

    [TestCase(new int[] { -21, 50, -221, 74, 143 }, new int[] { -221, -21, 50 ,74, 143 })]
    [TestCase(new int[] { 150, 500, -2, 13, 150 }, new int[] { -2, 13, 150, 150, 500 })]
    [TestCase(new int[] { -43, 450, -69, -123, 102 }, new int[] { -123, -69, -43, 102, 450 })]
    public void GivenAnNegativePositiveIntArray_BubleSort_Returns_SortedArray(int[] inputArr, int[] outputArr)
    {
        Assert.That(Program.BubleSort(inputArr), Is.EqualTo(outputArr));
    }
    #endregion

    #region BubleSort2...
    [Test]
    public void GivenNullArrays_BubleSort2_Throws_ArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Program.BubleSort2(null, null));
    }

    [Test]
    public void GivenArrayLength0_BubleSort2_Returns_EmptyIntArray()
    {
        int[] emptyArr = new int[] { };
        Assert.That(Program.BubleSort2(emptyArr, emptyArr), Is.EqualTo(emptyArr));
    }

    [TestCase(new int[] { 2, 5, 7, 12 }, new int[] { 8, 15, 22, 40, 65 }, new int[] { 2, 5, 7, 8, 12, 15, 22, 40, 65 })]
    [TestCase(new int[] { 8, 15, 22, 40, 65 }, new int[] { 4, 7, 12, 15, 21 }, new int[] { 4, 7, 8, 12, 15, 15, 21, 22, 40, 65 })]
    [TestCase(new int[] { -9, -38, -4, 12, 11 }, new int[] { 13, -2, -13, 14, 21 }, new int[] { -38, -13, -9, -4, -2, 11, 12, 13, 14, 21 })]
    public void GivenTwoIntArray_BubleSort2_Returns_SingleSortedArray(int[] arr1, int[] arr2, int[] outputArr)
    {
        Assert.That(Program.BubleSort2(arr1, arr2), Is.EqualTo(outputArr));
    }
    #endregion

    #region MergeSort...
    [Test]
    public void GivenAnNumArray_MergeSort_Returns_SortedArray()
    {
        int[] inputArr = new int[] { 1000, 5, 2, 1, 14 };
        int[] outputArr = new int[] { 1, 2, 5, 14, 1000 };

        Assert.That(Program.MergeSort(inputArr), Is.EqualTo(outputArr));
    }

    #endregion
}
