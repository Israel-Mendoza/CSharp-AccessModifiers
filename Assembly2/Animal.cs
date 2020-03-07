using System;

namespace Assembly2
{
    public class Animal
    {
        public void AnimalPublic(){ Console.WriteLine("Hello from the AnimalPublic method!!!");}
        protected void AnimalProtected(){ Console.WriteLine("Hello from the AnimalProtected method!!!");}
        internal void AnimalInternal() { Console.WriteLine("Hello from the AnimalInternal method!!!"); }
        protected internal void AnimalProtectedInternal() { Console.WriteLine("Hello from the AnimalProtectedInternal method!!!");}
        private protected void AnimalPrivateProtected() { Console.WriteLine("Hello from the AnimalPrivateProtected method!!!");}
        private void AnimalPrivate() { Console.WriteLine("Hello from the AnimalPrivate method!!!");}
        
        // Tests

        public void AnimalTest()
        {
            AnimalPublic();
            AnimalProtected();
            AnimalInternal();
            AnimalProtectedInternal();
            AnimalPrivateProtected();
            AnimalPrivate();
        }
    }
}