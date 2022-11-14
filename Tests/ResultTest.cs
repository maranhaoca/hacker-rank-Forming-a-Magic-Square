using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var s = new List<List<int>> {new List<int>{5,3,4},
                                    new List<int>{1,5,8},
                                    new List<int>{6,4,2}};
        var expected = 7;
        var actual = Result.formingMagicSquare(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var s = new List<List<int>> {new List<int>{4,9,2},
                                    new List<int>{3,5,7},
                                    new List<int>{8,1,5}};
        var expected = 1;
        var actual = Result.formingMagicSquare(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var s = new List<List<int>> {new List<int>{4,8,2},
                                    new List<int>{4,5,7},
                                    new List<int>{6,1,6}};
        var expected = 4;
        var actual = Result.formingMagicSquare(s);

        Assert.Equal(expected, actual);
    }
}