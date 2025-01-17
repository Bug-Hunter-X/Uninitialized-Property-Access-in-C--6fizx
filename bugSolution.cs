public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue;
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now the property is guaranteed to have a value
    }

    public void MyMethod2(){
        MyProperty = 5;
        Console.WriteLine(MyProperty); // Now the property is initialized
    }
}    