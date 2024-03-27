# **Premier cours c#**

## Introduction:

L'algorithmie est une série d'instruction. Il faut dotnet pour faire fonctionner C#. La classe main est la classe principale de notre projet. Elle représente notre programme.
La methode main est la methode principale de notre projet. C'est son point d'entrée. Une methode est représentée par sa signature.

Pour créer un projet C# :

`dotnet new console --use-program-main -o nomDuProjet`

Pour exécuter le programme:

`dotnet run`

### Compilation

Pour compiler le code, il suffit de lancer la commande:

`dotnet build`

## Déclaration de variables:

On peut déclarer le type de la variable, ou pas. On déclare les variables en camelCase.

**Exemple:**
```csharp
int myNumber = 2;
bool myBoolean = true;
string myString = 'my string';
var myNumber2 = 6; //type non déclaré
```
### Variables :
- `int` : Nombre entier
- `uint` : Nombre entier non signé
- `float` ou `double` : Nombre à virgule
- `bool` : Booléen, peut prendre la valeur true ou false
- `char` : Caractère unique
- `string` : Chaîne de caractères

Pour les entiers, on utilise principalement **int** et **long**, et pour les nombres a virgule on utilise principalement **float** et/ou **double**.

Un caractère occupe un octet. Un octet est un ensemble de 8 bits. Pour chaque valeur de 0 à 255 il existe un caractère. On déclare un caractère avec **char**.

Les constantes sont des valeurs qui ne changent pas. On doit les écrire tout en majuscule.

**Exemple:**
```csharp
const double PI = 3.14;
```

On ne peut pas réattribuer de valeur de valeur a la constante **PI**.

## Les opérateurs arithmétiques

- `%` : Modulo, c'est le reste d'une division
- `*` `/` `+` `-` : Pour les nombres réels et entiers
- `==` `<` `>` `<=` `>=` : Pour les comparaisons entre nombres réels et entiers

Pour les nombres a virgule (exemple **3.0**) sont des doubles par défaut. De ce fait, des erreurs peuvent apparaitre avec ce genre de notations:

```csharp
float z = 10 / 3.0;
```
Il faudrait alors écrire:
```csharp
float z = 10 / (float)3.0; //ou
float a = 10 / 3.0f;
```

## Instructions de séléction:

- `if` : si ...
- `else if` : sinon si ...
- `else` : sinon ...
- `switch` : L’instruction switch sélectionne une liste d’instructions à exécuter en fonction de critères spéciaux

**Exemple:**

```csharp
int day = 4;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
}
// "Thursday" (day 4)
```

## Opérateurs booléens:

- `&&` : Et
- `||` : Ou
- `!` : Non

## Boucles (for, whilew do-while):

- `boucle for` : C'est une boucle qui répète une instruction un nombre déterminé de fois
```csharp
int i = 20;
for(int  a = 0; a < i; a++) {
    //code a exécuter
}
```
- `boucle while` : C'est une boucle qui répète le code tant que la condition est vrai
```csharp
let i = 0;
while (i < 5) {
    Console.WriteLine("Valeur de i: " + 1);
    i++;
}
```
- `boucle do while` : On vérifie la condition APRES avoir fait un tour de boucle
```csharp
do {
    Console.WriteLine(x);
    x++;
} while (x < 10);
```

## Méthode et passage de paramètres

Les méthodes C# sont des blocs de codes qui exécutent des instructions.

On écrit une méthode comme ceci:

```csharp
static void print(string message) {
    ConsoleWriteLine(message);
}

static int add(int a, int b) {
    return a + b;
}

print("Hello World!");
print("Bonjour le monde");

int result = add(5, 6);

print(result.toString());
```
### Modificateur:
- `static`
### Type de retour:
- `void` : la méthode ne retourne rien
- `int` : la méthode retourne un nombre
- `string` : la méthode retourne une String

Le type de retour est toujours le meme que la variable dans lequel est stocké le résultat. Pour print le result de la method add, on doit préciser qu'il doit etre en String car la méthode print demande une String dans ses paramètres.

## Tableaux :

Un tableau est une structure de données qui permet de stocker plusieurs valeurs

**Exemple:**
```csharp
type[] <nom du tableau> = new <type>[taille du tableau]

int[] tab = new int[5];

string[] joursDeLaSemaine = ["Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"]

Console.WriteLine(jourDeLaSemaine[2]);

// "Mercredi"
```
