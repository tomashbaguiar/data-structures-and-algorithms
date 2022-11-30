namespace DevTraining.Codility.TimeComplexity;

public static class FrogImp
{
    public static int Solution(int x, int y, int d)
    {
        var result = (y - x) / d;
        result += (y - x) % d == 0 ? 0 : 1;
        return result;
    }
}