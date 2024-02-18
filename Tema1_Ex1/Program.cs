/*Ex1
Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
paralelipiped dreptunghic, va afisa volumul lui*/
       
// Citirea dimensiunile
Console.WriteLine("Introduceti lungimea paralelipipedului:");
int lungime = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti latimea paralelipipedului:");
int latime = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti inaltimea paralelipipedului:");
int inaltime = Convert.ToInt32(Console.ReadLine());

// Calculul volumului ( lung * latime * inaltime)
int volum = lungime * latime * inaltime;

// Afișarea rezultatului
Console.WriteLine($"Volumul paralelipipedului este: {volum}");

// Așteapta ca utilizatorul sa apese o tasta pentru a inchide fereastra consolei
Console.ReadKey();
