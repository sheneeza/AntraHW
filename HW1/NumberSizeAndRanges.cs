using System;

class NumberSizeAndRanges
{
   // 1. Number of bytes for num types 
    public void PrintTypeInfo<T>(string typeName) where T : struct
    {
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", 
            typeName, 
            System.Runtime.InteropServices.Marshal.SizeOf<T>(), 
            GetMinValue<T>(), 
            GetMaxValue<T>());
    }

    static object GetMinValue<T>() where T : struct
    {
        return typeof(T).GetField("MinValue")?.GetValue(null);
    }

    static object GetMaxValue<T>() where T : struct
    {
        return typeof(T).GetField("MaxValue")?.GetValue(null);
    }
    
    // 2. Conversion of centuries
    public void PrintCenturyConversion(int centuries)
    {
        int years = centuries * 100;
        int days = (int)(years * 365.24);
        int hours = days * 24;
        long minutes = hours * 60L;
        long seconds = minutes * 60L;
        long milliseconds = seconds * 1000L;
        long microseconds = milliseconds * 1000L;
        decimal nanoseconds = microseconds * 1000M; 

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        Console.WriteLine($"= {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}