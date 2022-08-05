// See https://aka.ms/new-console-template for more information
using ClassLibraryAssurance;

Console.WriteLine("Tapez votre age");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Depuis quand avez vous votre permis ?");
int duree = int.Parse(Console.ReadLine());
Console.WriteLine("Combien avez vous fait d'accident ?");
int nbrAccident = int.Parse(Console.ReadLine());

Tarif myTarif = new Tarif() {Age = age, Duree = duree, NombreAccident = nbrAccident };

Console.WriteLine(myTarif.NomduTarif);