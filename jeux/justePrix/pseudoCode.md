# Le Juste Prix:

**INPUT** : nombre de tentatives

nbrTentative = nombre de tentatives

tentativesMax = nbrTentative

tentatives = 0

randomNumber = nombre séléctionné par l'ordinateur

**BOUCLE FOR** selon tentativesMax

**INPUT** : Deviner le nombre

userNumber = le nombre entré par l'utilisateur (string)

**SI** la string = "q"

**QUITTER LA BOUCLE ET LE CODE**

**SINON**

convertir la string en int dans une nouvelle variable (userNumber2)

**SI** nombre de l'utilisateur plus petit que nombre de l'ordinateur

afficher "le nombre est plus grand"

tentatives + 1

**SI** nombre de l'utilisateur plus grand que nombre de l'ordinateur

afficher "le nombre est plus petit"

tentatives + 1

**SI** nombre de l'utilisateur est égal au nombre de l'ordinateur

afficher "Vous avez gagné"

tentatives + 1

*fin de la boucle for*

**SI** tentatives = tentatives max

afficher "vous avez perdu !"