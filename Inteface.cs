interface IAnimal // das I vor der Interface hilft beim Unterscheiden von Klassen
{
  void animalSound(); // Hier wird die Methotde animalSound erstellt
}

// Pig holt sich die Methode AnimalSound
class Pig : IAnimal 
{
  public void animalSound() // Die in IAnimal definierte Methode
  {
    // Hier wird der Methoden "Körper" implementiert
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Pig myPig = new Pig();  // Pig Objekt wird erstellt
    myPig.animalSound();    //Die ausgabe ist The pig says: wee wee
  }
}