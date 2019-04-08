# Test-Unitaire

Présentation du projet: le but est de gérer les tests unitaires nous avons pour cela realiser 2 projet , un GenCode et un jeu de grattage.

Les outils mis en oeuvre :

* git.
* Visual studio.

Un test unitaire va permettre:

1. -de créer un programme qui va tester l'ensemble des méthodes d'une classe. 
2. -Pour cela on va s'assurer qu'une méthode retourne le résultat attendu en fonction des paramètres qui lui sont transmis. 
3. -Une fois ce programme de test écrit et la classe testé on pourra relancer à volonté ce programme de test. 
4. -Il permettra d'effectuer ce que l'on nommme des tests de non regression. Ainsi si l'on doit effectuer une maintenance évolutive ou corrective on pourra rejouer cette séance de code de test afin de valider que la classe fonctionne toujours correctement. 


## Illustration ##
![CaptureSchema.png](http://image.noelshack.com/fichiers/2019/15/1/1554751336-capture.png) 

## Comment Créer un test unitaire ##
Visual studio permet de créer automatiquement les teste unitaire il suffit sur son projet de rajouter un nouvelle element "parametre de test".
### GENCODE ###
Ce projet on créer un code de 12 chiffres avec un traisieme chiffre qui sert a la véréfication de la bonne saisie du code.
```cs
public void Ean13ConstructorTest_Nombre()
        {
            try
            {
                Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8,18});
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Votre chiffre n'est pas compris entre 0 et 9");
                Assert.Fail(e.Message);
                return;
            }
            Assert.Fail("Aucune exception n'a été soulevée");
        }
```
Dans cette exemple nous testons la validiter du contructure et que l'argument soit bien valide ou pas grace aux asset.

### JEU DE GRATTAGE ###
Ce projet créer 9 cases sur lequelles est généré aléatoirment des chiffres de 1 a 3, si elle a 6 fois le meme numero elle gagne 50€, si elle aligne 3 meme chiffre en ligne colonne ou diagonal elle gagne 100€.
```cs
public void JeuConstructorTest()
        {
            Jeu target = new Jeu(new int[,] { { 3, 2, 2 }, { 2, 3, 3 }, { 1, 3, 3 } });
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }
```
Pareil que l'exemple ci-dessus dans ce cas nous etudions le constructeur. 
Afin de realiser c est projet nous avons besoin des assets voici  sa class: 

![CaptureSchema.png](http://image.noelshack.com/fichiers/2019/15/1/1554752776-capture2.png) 
