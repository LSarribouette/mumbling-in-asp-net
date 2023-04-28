# Dojo

Une application Web ASP.NET Core MVC (Modèle-Vue-Contrôleur) en C#, dans un contexte d'application en couches basé sur la _Clean Architecture_.

## Spécifications

> Un site qui recense des Samouraïs, des armes et des arts martiaux.

3 entités : Samouraï, Arme, Art Martial avec un CRUD pour chacune.

Relation one to one : un Samouraï peut avoir zéro ou une arme -- une arme peut avoir zéro ou un propriétaire.

Relation many to many : un Samouraï peut maîtriser zéro à plusieurs arts martiaux -- un art martial peut être maîtrisé par zéro à plusieurs Samouraï.

## Implémentation

La solution est scindée en quatre projets : Domain, Infrastructure, Web et Tests.

**Domain** porte la logique métier, avec le modèle (entités), les interfaces des services et des repositories, l'implémentation des services. Il n'est dépendant d'aucun projet.

**Infrastructure** porte l'accès aux données, avec les migrations, le contexte (accesseur à la base de données), l'implémentation des repositories. Il est dépendant de Domain.

**Web** porte l'interface utilisateur, avec les vues, les contrôleurs, les ViewModels. Il est dépendant de Domain et de Infrastructure.

**Tests** porte un test d'intégration qui vérifie l'accès à la base de données (SQLServer), des tests unitaires sur les services et sur les contrôleurs, des tests end-to-end sur la création d'un compte utilisateur et la connexion de l'utilisateur (avec PlayWright).

## Authentification

ASP.NET Core Identity est utilisé pour la mise en place de l'authentification et de l'autorisation.

Le BaseController porte l'attribut d'accès `[Authorize]` et les contrôleurs en héritent. Seules les actions Index() portent l'attribut d'accès sans connexion `[AllowAnonymous]`.


## API

La liste des Samouraïs et la liste paginée des Samouraïs sont rendues accessibles par une API, aux urls suivantes : "/Api/Samourais" et "/Api/Samourais/{pageNumber}/{pageSize}".

## Ressources 

- https://learn.microsoft.com/fr-fr/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures
- les précieux conseils et le soutien de [Quentin Martinez](https://github.com/AzRunRCE)
