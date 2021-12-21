# Forza_workshop

## Prérequis : 

 - Installez Unity Hub https://unity.com/download#how-get-started
 - Créez vous un compte, et prennez une license gratuite.
 - Installez en local la dernière version LTS de 2020
 - Créez un projet de type 3D

## Overview

Si vous êtes bon, à la fin de ce workshop vous pourrez avoir un jeu complet et detaillé, interfaces graphiques, level design, bonus dans le jeu.

## Unity Basics

Ecoutez nous là c'est important si vous n'avez jamais touché à Unity.

## UI (Menu + UI in game)

![](https://github.com/tomasit/ForzaWorkshop/blob/main/Screenshot%20from%202021-12-21%2011-59-06.png)

### Step 1

A la fin de cette étape vous devrez afficher différents menus.<br/>
Depuis une nouvelle scène "Menu" créez une interface graphique à l'aide des objets UI de Unity :
    
 - Canvas (Pour contenir tout vos objets de type UI)
 - Boutons
 - Text
 - Images

Vous pouvez proposer à l'utilisateur :

 - Différentes voitures
 - Différentes courses

### Step 2

Maintenant que vous avez une interface graphique fonctionnelle vous pouvez ajouter un décors a votre menu.<br/>
Vous avez un asset de garage si vous voulez (Workshop2/levelDesign/garage/). <br/>
Vous pouvez aussi afficher les voitures selectionées par l'utilisateur.(Cars/)<br/>
etc...

## Level design et power up

### Step 1

Nous vous avons donné un ensemble de circuits.(Workshop2/levelDesign/races)<br/> 
Et un .zip avec une voiture a l'interieur.(Workshop2/Car/)<br/>
Vous pouvez créer une scène avec l'une d'elle.<br/>
Faites ensuite en sorte que la voiture ne puisse jamais sortir de la course.
Pour ça vous aurez besoins de **BoxCollider(s)** pour délimiter les limites de la course.

![](https://github.com/tomasit/ForzaWorkshop/blob/main/Screenshot%20from%202021-12-21%2013-34-37.png)

### Step 2

A la fin de cette partie vous pourrez prendre des power up avec votre voiture.
Et avancer plus vite, ou au contraire avec un malus et ralentir, etc. (libre à vous de donner les effets que vous voulez).

 - Créez un nouvel objet Power up.<br/>Dans cet objet mettez un **Box Collider**. /!\ (Attention les voitures devront pouvoir passer a travers ces bonus.)<br/>
 - Ensuite avec un script dans ce même objet Power up, trouvez un moyen de savoir quand la voiture est passée à travers et ajoutez lui de la vitesse (et un effet de nitro pourquoi pas).

PS: allez voir dans Workshop2/PowerUp pour les assets de powerUp.

### Step 3

Un bon game designer est censé faire en sorte que le joueur ai une bonne experience de jeu. La plus immersive possible. Cela passe en premier par ce que le joueur voit a l'écran.<br/>
Un moyen simple d'améliorer cette experience utilisateur est la mise en place de caméras.<br/>

![](https://github.com/tomasit/ForzaWorkshop/blob/main/Screenshot%20from%202021-12-21%2013-37-15.png)

Dans cette étapes ajoutez un script *CameraController* à la base de votre voiture.<br/>
 - Faites en sorte que lorsque la touche *C* du clavier est préssée l'angle de la caméra change.<br/>
 
Si vous voulez aller plus loin :
 - Faites en sorte que lorsque la voiture recule la caméra nous montre l'avant de la voiture.
 
## Bonus Game design

 - Sound design (Boutons UI, voitures, collisions de celle ci...)
 - Avoir le choix de selectionner la voiture que l'on veut avec la course que l'on veut
 
## Bonus physiques de la voiture ++

N'hésitez pas à modifier les paramètres de votre voiture :<br/>
- Pour qu'elle aille de plus en plus vite<br/>
- Qu'elle patine plus sur le sol<br/>
- Qu'elle freine lorsque l'accélerateur n'est plus pressé...

