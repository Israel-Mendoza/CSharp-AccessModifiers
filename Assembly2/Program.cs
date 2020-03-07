namespace Assembly2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animalAssembly2 = new Animal();
            animalAssembly2.AnimalPublic();    // Public is available everywhere
            animalAssembly2.AnimalInternal();  // We are in the same assembly
            animalAssembly2.AnimalProtectedInternal(); // We are in the same assembly
        }
    }
}