using System.Runtime.CompilerServices;

public static class TempConverter 
{
    public static double FahrenheitToCelsius(double x)
    { 
       double y = (x- 32) * 5.0 / 9.0;
       return y;
    }
    public static double CelsiusToFahrenheit(double a)
    {   
        double b = (a * (9/5)) + 32;
        return b;
    }

}    