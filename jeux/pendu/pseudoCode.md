# Le Pendu:

```csharp
variable : nombre Essais Maximum
variable : nombre Essais En Cours
variable tableau : liste de mots qui peuvent être choisis par l'ordinateur
variable : taille du tableau de liste de mots
variable random
variable mot choisi en utilisant la variable random avec la variable de la taille du tableau
variable bool avec true si le mot est choisi
variable liste pour la liste des lettres trouvées

Message bienvenue etc ...
Message choisir la difficulté

variable difficulté choisie (valeur de la difficulté que l'utilisateur a choisi)

TANT QUE (while) la difficulté != (différent) 1 ET difficulté != 2 ET difficulté != 3
    SI difficulté == (égale) !
        message confirmation pour quitter le jeu
        enregistrer reponse utilisateur dans variable
        SI réponse != null ET reponse == oui
            message vous avez quitté le jeu
            return
        SINON
            message vous n'avez pas quitté le jeu
    SINON
        message erreur : séléctionner chiffre entre 1 et 3
    Message choisir la difficulté
    variable difficulté choisie = valeur que l'utilisateur a choisi

SWITCH pour la valeur de la variable difficulté choisie
    CASE 1
        variable nombre essais maximum = 14
        break
    CASE 2
        variable nombre essais maximum = 12
        break
    CASE 3
        variable nombre essais maximum = 10
        break

TANT QUE nombre essais en cours < (plus petit) que nombre essais maximum
    message choisir lettre
    variable : récupérer la lettre choisie

    SI la lettre choisie est égale à '!'
        message confirmation pour quitter le jeu
        enregistrer réponse utilisateur dans variable
        SI réponse != null ET réponse == oui
            message vous avez quitté le jeu
            return
        SINON
            message vous n'avez pas quitté le jeu

    SINON SI la lettre choisie est vide ou n'est pas une lettre seule 
        message merci d'entrer une lettre valide
        continuer avec la prochaine itération de la boucle

    SINON
        stocker la lettre choisie en minuscule dans une variable

        POUR chaque lettre dans le mot sélectionné

            SI la lettre actuelle est égale à la lettre choisie
                marquer la lettre comme devinée
                indiquer que la lettre a été trouvée dans le mot

        SI la lettre n'a pas été trouvée dans le mot

            POUR chaque lettre dans les lettres déjà tentées

                SI la lettre est identique à la lettre choisie
                    indiquer que la lettre a été déjà choisie
                    
            SI la lettre n'a pas été déjà choisie
                augmenter le nombre d'essais
                dessiner une partie supplémentaire du pendu selon la difficulté choisie
                afficher un message indiquant que la lettre n'est pas dans le mot
                ajouter la lettre aux lettres déjà tentées

        SINON SI la lettre a déjà été choisie
            afficher un message indiquant que la lettre a déjà été entrée
            dessiner une partie supplémentaire du pendu selon la difficulté choisie

    SI la lettre est trouvée dans le mot
        dessiner une partie supplémentaire du pendu selon la difficulté choisie
        afficher un message indiquant que la lettre est dans le mot

    afficher le mot actuel avec les lettres devinées et des _ pour les lettres non devinées

    POUR chaque lettre dans les lettres devinées
        SI une lettre n'est pas devinée
            indiquer que le mot n'est pas entièrement deviné
            sortir de la boucle

    SI le mot est entièrement deviné
        afficher un message de victoire
        sortir de la boucle

SI le nombre d'essais atteint le nombre d'essais maximum
    afficher un message de défaite
```