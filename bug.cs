public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that has not been initialized
        int value = MyProperty; // Bug: Potential NullReferenceException
    }
}