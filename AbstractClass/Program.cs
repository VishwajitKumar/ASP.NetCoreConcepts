using System;

namespace AbstractClass
{
    //Normal Class cannot have abstract members
    public class NormalClass
    {
        //public abstract void PrintMessage();
    }


    //if a member is defined as abstract then the class should be marked as abstract
    abstract class AbstractClass
    {
        public abstract void PrintMessage();
    }
    //abstract class can not be sealed
    //abstract sealed class AbstractSealedClass
    //{
        //public abstract void PrintMessage();
    //}
    class Program:AbstractClass
    {
        static void Main(string[] args)
        {
           
        }

        public override void PrintMessage()
        {
            throw new NotImplementedException();
        }
    }
}
