
//MULTIPLE INTERFACES
interface IFirstInterface // das I vor der Interface hilft beim Unterscheiden von Klassen
{
  void myMethod(); // Die Interface Methode wird defineirt auch gennant Methodenkopf
}

interface ISecondInterface 
{
  void myOtherMethod(); //  Die Interface Methode wird defineirt auch gennant Methodenkopf
}


class DemoClass : IFirstInterface, ISecondInterface 
{
  public void myMethod() // Hier wird der Methoden "Körper" implementiert
  {
    Console.WriteLine("Some text.."); 
  }
  public void myOtherMethod() // Hier wird der Methoden "Körper" implementiert
  {
    Console.WriteLine("Some other text..."); 
  }
}

class Program 
{
  static void Main(string[] args)
  {
    DemoClass myObj = new DemoClass(); // Neues Objekt wird erstellt
    myObj.myMethod();                   // die oben angelegten Interface Methoden werden Benutzt
    myObj.myOtherMethod();
  }
}