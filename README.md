# Forza_workshop

## Prérequis : 

 - Installez Unity Hub https://unity.com/download#how-get-started
 - Créez vous un compte, et prennez une license gratuite.
 - Installez en local la dernière version LTS de 2020
 - Créez un nouveau projet 3D

## Overview

Si vous êtes bon, à la fin de ce workshop vous pourrez faire drifter votre voiture sur un terrain de course.

![](../Pictures/Screenshot from 2021-12-20 11-18-42.png)

## Unity Basics

Ecoutez nous là c'est important si vous n'avez jamais touché à Unity.

## Step 1

Le but de cette étape est d'avoir toute la physique de la voiture mise en place.
Utilisez un de nos asset de voiture. L'intégrer a une nouvelle scène vide. 
Ajoutez les composants ci dessous a cet objet :
 - Box collider
 - Wheel collider (x4)
 - RigidBody

Faites bien attention à ce que les wheel collider soit bien configurer.

## Step 2

A la fin de cette étape, votre voiture pourra aller en ligne droite.


Vous allez devoir créer un Script, l'intégrer à votre voiture.<br/>
Vous devez trouver un moyen d'accéder aux quatres roues de la voiture depuis votre script.<br/>
Ensuite, utilisez les composants mis dans le step 1 pour faire avancer la voiture.

Si vous avez des questions : https://docs.unity3d.com/Manual/index.html <br/>
Ou en dernier recours demander à Thomas Itel.

## Step 3

Allez à gauche et à droite.
Une fois de plus, vous devez modifier les paramètres des composants physiques de votre voiture.

Faites en sorte de lier les inputs de votre clavier à la direction que prend votre voiture (AMG classe 5 model A).

## Step 4

Normalement ici votre voiture peut se déplacer dans toutes les directions. Mais drift t-elle ?

Dans vos wheelCollider vous avez de nombreux paramètres : 
 - La friction
 - Les suspensions
 - La masse
 - ...

Faites en sorte que votre voiture ne fasse pas de tonneaux et soit stable même a une grande vitesse.<br/>
Pour cela vous devrez configurer des barres de stabilisation.

Si vous ne savez pas ce que c'est : https://youtu.be/N1EF-7-Wcvk

## Bonus

N'hésitez pas à modifier les paramètres de votre voiture :<br/>
- Pour qu'elle aille de plus en plus vite<br/>
- Qu'elle patine plus sur le sol<br/>
- Qu'elle freine lorsque l'accélerateur n'est plus pressé...

Ou encore :

- Animations des roues.
- Bruit de la voiture.
- Différentes vues de caméras


### PS : ça pourrait vous être utile

https://docs.unity3d.com/Manual/class-WheelCollider.html