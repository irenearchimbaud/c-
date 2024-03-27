# Le Juste Prix:

Définir liste de mots prédéfinis dans un tableau

Utiliser random pour choisir un element du tableau aléatoirement

definir le nombre d'essais max

definir booleenne lettre trouvée 

definir le nombre d'essais effectués

message de bienvenue + message pour selectionner la difficulté

definir liste de lettres essayées mais fausses

SI c'est 1

essais max = 14

SINON SI c'est 2

essais max = 12

SINON SI c'est 3

essais max = 10

TANT QUE (boucle while) le nombre d'essais effectué est plus petit que le nombre d'essais max

definir booleenne false pour les lettres essayées mais fausses

message: essai restant

choisir une lettre et recuperer la lettre choisie dans une variable

SI la lettre choisie est ! quitter le jeu

SI la taille de la saisie de l'user depasse 1 , afficher erreur

BOUCLE FOR autant de fois qu'il y a de lettres dans le mot choisi par l'ordinateur 

definir booleenne lettres trouvees

si oui lettre trouvee (bool) = true



SI la booleenne lettre trouvee est false

FOREACH pour chaque lettre dans le tableau de lettres essayées 

SI la lettre est la même que la lettre entree par l'utilisateur

afficher message qui dit que la lettre a deja ete essayée et l'ajouter au tableau de lettres deja essayées

SI le nombre max d'essai est 10: afficher le pendu du niv 3

SI le nombre max d'essai est 12: afficher le pendu du niv 2

SI le nombre max d'essai est 14: afficher le pendu du niv 1

SINON 

SI le nombre max d'essai est 10: afficher le pendu du niv 3

SI le nombre max d'essai est 12: afficher le pendu du niv 2

SI le nombre max d'essai est 14: afficher le pendu du niv 1

afficher le message de lettre trouvée


afficher le message de l'état du mot actuel :

boucle FOR du nombre de lettres du mot séléctionnée

SI la lettre est trouvée

on ecrit la lettre a l'index de la lettre trouvéé

SINON on ecrit _


SI le mot est trouvé entièrement: afficher message BRAVO avec le mot



SI le nombre d'essai de l'utilisateur est = au nombre max de tentatives :

afficher le message de défaite



créér les 3 dessins de pendus selon le niveau donc le nombre d'essai max

(case 1, case 2, case 3...)

break