namespace ClassLibrary2
{
    public interface IClass2
    {
        string GetMessage();
    }


    public class FaClass2: IClass2
    {
        public  string GetMessage()
        {
            return "from ClassLibrary1!";
        }
    }

    public class Class2: IClass2
    {
        public  string GetMessage()
        {
            return "1111111Hello from ClassLibrary1!";
        }
    }
}
