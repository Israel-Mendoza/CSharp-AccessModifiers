namespace Assembly2
{
    public class Dog : Animal
    {
        public void DogTest()
        {
            AnimalPublic();        // Public is available everywhere
            AnimalProtected();     // Dog is derived from animal. Same assembly
            AnimalInternal();       // We are in the same assembly as animal
            AnimalProtectedInternal(); // We are int the same assembly. Also Dog is derived from Animal
            AnimalPrivateProtected();  // We are in the same assembly AND Dog is derived from Animal
            
        }
    }
}