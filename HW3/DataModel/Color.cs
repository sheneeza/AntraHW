namespace HW3;

public class Color
{
    // Instance variables
    private int red;
    private int green;
    private int blue;
    private int alpha;

    public Color(int red, int green, int blue, int alpha)
    {
        SetRed(red);
        SetGreen(green);
        SetBlue(blue);
        SetAlpha(alpha);
    }

    public Color(int red, int green, int blue)
    {
        SetRed(red);
        SetGreen(green);
        SetBlue(blue);
        SetAlpha(255);
        
    }
    
    public int GetRed() => red;
    public int GetGreen() => green;
    public int GetBlue() => blue;
    public int GetAlpha() => alpha;
    
    public void SetRed(int value) => red = ValidateColor(value);
    public void SetGreen(int value) => green = ValidateColor(value);
    public void SetBlue(int value) => blue = ValidateColor(value);
    public void SetAlpha(int value) => alpha = ValidateColor(value);
    
    private int ValidateColor(int value) => Math.Clamp(value, 0, 255);

    public int GetGrayscale(int red, int green, int blue)
    {
        return (red + green + blue) / 3;
    }
    
    public string GetRGBA() => $"rgba({red}, {green}, {blue}, {alpha})";
    public override string ToString() => $"Color(R={red}, G={green}, B={blue}, A={alpha})";
}
