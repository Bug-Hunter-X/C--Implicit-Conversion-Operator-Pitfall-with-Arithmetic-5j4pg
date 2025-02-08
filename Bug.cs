public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int value = obj1;   // Implicit conversion from MyClass to int
        Console.WriteLine(value); // Output: 10

        MyClass obj2 = new MyClass(20);
        int value2 = obj2 + 5; //compiler error: Operator '+' cannot be applied to operands of type 'MyClass' and 'int'.
        Console.WriteLine(value2); //this line will cause compiler error
    }
}