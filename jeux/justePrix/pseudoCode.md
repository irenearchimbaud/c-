# Le Juste Prix:
```csharp
TANT QUE (while) isInGame est vrai
    variable : maxTry (nombre d'essais maximum)
    variable : numberTries (nombre d'essais restants)
    variable : isGameWin (booléene pour vérifier si le joueur a gagné)

    TANT QUE vrai (isinGAme)
        Afficher message demandant à l'utilisateur de choisir un nombre de tours
        enregistrer la réponse dans une variable

        SI l'entrée peut être convertie en nombre
            Attribuer la valeur convertie à numberTries et maxTry
            Sortir de la boucle intérieure
        SINON SI l'entrée est "q"
            Quitter le jeu
        SINON
            Afficher un message d'erreur et demander à l'utilisateur de saisir un nombre valide

    variable générer un nombre aléatoire entre 1 et 10 000 et le stocker dans randomNumber

    POUR chaque essai allant de 0 à nombre d'essais max (non compris)
        Afficher le nombre d'essais restants et demander à l'utilisateur de deviner le nombre
        enregistrer la reponse dans une variable

        SI l'entrée peut être convertie en nombre
            SI le nombre de l'utilisateur est inférieur à randomNumber
                Afficher un message indiquant que c'est plus
                nombre d'essais rastants -1
                nombre d'essais en cours + 1
            SINON SI le nombre de l'utilisateur est supérieur à randomNumber
                Afficher un message indiquant que c'est moins
                nombre d'essais rastants -1
                nombre d'essais en cours + 1
            SINON SI le nombre de l'utilisateur est égal à randomNumber
                nombre d'essais rastants -1
                nombre d'essais en cours + 1
                Afficher un message de victoire avec le nombre de tentatives et le nombre de l'ordinateur
                Attribuer vrai à isGameWin
                Sortir de la boucle
        SINON SI l'entrée est "q"
            Quitter le jeu
        SINON
            Décrémenter i pour rester dans la même itération
            Afficher un message d'erreur et demander à l'utilisateur de saisir un nombre valide

    SI tries est égal à maxTry et isGameWin est faux
        Afficher un message indiquant que le joueur a perdu avec le nombre de l'ordinateur

    Afficher un message demandant au joueur s'il veut rejouer
    Lire l'entrée de l'utilisateur

    SI l'entrée est différente de "oui"
        Attribuer faux à isInGame
        Afficher un message de sortie
```