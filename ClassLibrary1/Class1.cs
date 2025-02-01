using ClassLibrary2;

namespace ClassLibrary1
{
    public class Class1
    {
        public static string GetMessage()
        {
            return Class2.GetMessage();
        }
    }
}
