using System;
using System.Linq;

namespace DogGenetics.sln
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your dog's name? ");
            string dogName = Console.ReadLine();

            string[] dogBreeds = { "German Shepherd", "Bulldog", "Poodle", "Labrador Retriever", "Golden Retriever", "Beagle", "Yorkshire Terrier", "Dachshund", "Chihuahua", "Pug", "Siberian Husky", "Boxer", "Greyhound", "Shih Tzu", "Border Collie", "Great Dane", "St. Bernard", "Dobermann" };
            
            int[] dogGenes = new int[5];
            

            Random dogBreed = new Random();
            
            Random geneNumber = new Random();

            
                for (int i = 0; i < dogGenes.Length - 1; i++)
                {
                    
                        dogGenes[i] = geneNumber.Next(1, 20);
                    
                }
                 dogGenes[4] = 100 - dogGenes.Sum();


            


            if (!String.IsNullOrEmpty(dogName))
            {
                Console.WriteLine($"Well then, I have this highly reliable report on {dogName}'s prestigious background right here.");
                
              
                   

                
                Console.WriteLine($"{dogName} is:");
                for (int j = 0; j < dogGenes.Length; j++)
                {
                    int dIndex = dogBreed.Next(dogBreeds.Length);

                    Console.WriteLine($"{dogGenes[j]}% {dogBreeds[dIndex]}");
                }
            }
            else { Console.WriteLine("That is an empty name!"); }



        }
    }
}
