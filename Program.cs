using static System.Net.Mime.MediaTypeNames;
// Rekürsif metot
static int FibonacciSerisi(int sayi)
{
    if (sayi == 0)
    {
        return 0;
    }
    else if(sayi == 1){
        return 1;
    }
    else
    {
        return FibonacciSerisi(sayi - 1) + FibonacciSerisi(sayi - 2);
    }
}

//Extension metot
public static class MyExtensionClass
{
    public static bool IsEventNumber(this int value)
    {
        if (value % 2 == 0)
            return true;
        else
            return false;
    }
}