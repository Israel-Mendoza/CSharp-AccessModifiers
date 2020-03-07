using Assembly2;

namespace Assembly1
{
    public class Cat : Animal
    {
        public void CatTest()
        {
            AnimalPublic();    // Public is available everywhere
            AnimalProtected(); // Cat is derived from Animal
            AnimalProtectedInternal(); // Cat is derived from Animal
        }
    }
}