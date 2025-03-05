namespace HW3;

public class Ball
{
    private double size;
    private int throwCounter;
    public Color BallColor { get; set; }
    
    public Ball(double ballSize, Color color)
    {
        size = ballSize;
        BallColor = color;
        throwCounter = 0; 
    }

    public double GetSize()
    {
        return size;
    }

    public void SetSize(double value)
    {
        size = value;
    }
    
    public void Pop()
    {
        size = 0;
    }

    public void ThrowBall()
    {
        if (size != 0)
        {
            throwCounter++;
            Console.WriteLine($"The ball has been thrown {throwCounter} times.");
        }
        else
        {
            Console.WriteLine("This ball is popped! It can't be thrown.");
        }
    }

    public int GetThrowCounter()
    {
        return throwCounter;
    }
    
    public override string ToString() => $"Ball(Size={size}, {BallColor}, Throws={throwCounter})";
    
}