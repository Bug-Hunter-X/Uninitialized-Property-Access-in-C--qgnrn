public class MyClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public MyClass()
    {
        MyProperty = 0; // Initialize MyProperty
    }

    public void MyMethod()
    {
        int value = MyProperty; 
    }
}