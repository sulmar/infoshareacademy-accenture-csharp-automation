

Stack<Operation> operations = new Stack<Operation>();

operations.Push(new Rotate(45));
operations.Push(new Rotate(90));
operations.Push(new Translate(10, 20));

while(operations.Count > 0)
{
    Operation operation = operations.Pop();

    operation.Execute();
}


public class Rotate : Operation
{
    private double _angle;

    public Rotate(double angle)
    {
        this._angle = angle;
    }

    public override void Execute()
    {
        Console.WriteLine($"Obrót o {_angle} stopni.");
    }
}

public class Translate : Operation
{
    private double _x;
    private double _y;

    public Translate(double x, double y)
    {
        this._x = x;
        this._y = y;
    }

    public override void Execute()
    {
        Console.WriteLine($"Przesunięcie o x: {_x} y: {_y}");
    }
}

public abstract class Operation
{
    public abstract void Execute();
}

