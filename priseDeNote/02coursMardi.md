# **Deuxième cours c#**

## Les chaînes de caractères:

Les chaines de caractère sont crées avec des guillemets double.

**Exemple** :
```csharp
string salutations = "Bonjour le monde!";
```
### Concaténation de chaînes

```csharp
string nom = "Irène ";
Console.WriteLine = "Coucou " + nom + "!";

```
### Interpolation de chaînes

```csharp
string nom = "Marie";
Console.WriteLine($"Bonjour, {nom}!");
```

### Acceder aux caractères dans une chaîne

On peut acceder a un caractère spécifique dans une chaine comme pour un tableau (commence à l'index 0).

```csharp
string myString = coucou;
char accessToIndexZero = coucou[0];
```

### Sous-chaînes

`Substring` :
```csharp 
string maChaine = "lorem impsu";
string sousChaine = maChaine.Substring(0, 5);
// à partir du caractère 0, je veux les 5 premiers charactères
```

### Autres méthodes:

- `Replace` : Pour remplacer toutes les instances d'une sous chaine, par une autre
- `ToUpper` : Convertir une chaîne en majuscule
- `ToLower` : Convertir une chaine en minuscule

Il en existe pleins d'autres sur la documentation de microsoft !

## Tableaux:

### Tableaux multidimentionnels:

Les tableaux multidimentionnels sont déclarés avec plusieurs ensembles de crochets, chacun représentant une dimension

## L'entrée clavier:

### Lire une ligne complète:

```csharp
Console.Write("Appuyez sur une touche : ");
ConsoleKeyInfo touche = Console.ReadKey();
Console.WriteLine($"\nVous avez appuyé sur la touche : {touche.Key}");
```

## Traitement des erreurs d'entrée

`try-catch` : Peut servir pour gérer les erreurs de conversion 

```csharp
try {
    Console.Write("Entrez un nombre : ");
    int nombre = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Le nombre est: {nombre}");
}
catch (FormatException)
{
    Console.WriteLine("Format incorrect, veuillez entrer un nombre entier.");
}
```

En utilisant `Console.ReadLine()` , `Console.ReadKey()` , et en effectuant des conversions de types appropriées, vous pouvez créer des interfaces utilisateur robustes et conviviales. Toujours anticiper et gérer les erreurs potentielles d'entrée permet de rendre vos applications plus stables et fiables.