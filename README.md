##GroceryApp sprint2 

Om overzicht te houden, werk ik met een vaste branching-strategie.

##Branching Strategie

Ik werk met de volgende branchestructuur:

##Main branch 
Bevat altijd een stabiele versie van het project en wordt alleen bijgewerkt met releases.  

##Develop branch 
Hier doe ik de actieve ontwikkeling. Nieuwe feature branches worden hieraan toegevoegd en samengevoegd.  

##Feature branches 
Nieuwe functionaliteiten ontwikkel ik in feature branches die afgetakt zijn van `develop`.  

## Release branches
Wanneer ik een nieuwe versie voorbereid, maak ik een release branch aan.  
Daar kan ik nog laatste fixes of documentatie toevoegen voordat ik merge naar `main`.  

## Hotfix branches
Voor kritieke bugs in productie maak ik een aparte hotfix-branch.  
Deze fix merge ik direct naar `main` en daarna ook terug naar `develop`.  

## Workflow
1. Ik begin altijd vanaf `develop`.  
2. Ik maak een nieuwe branch (`feature/UCx` of `bugfix/...`).  
3. Ik commit en push mijn werk.  
4. Als ik klaar ben, maak ik een Pull Request naar `develop`.  
5. Alleen stabiele releases worden van `develop` → `release` →'main' gezet.  
  

## Docentversie  
In deze versie zijn de wijzigingen doorgevoerd en is de code compleet.  

## Studentversie:  
### UC04 Kiezen kleur boodschappenlijst  
Is compleet.

### UC05 Product op boodschappenlijst plaatsen:   
- `GetAvailableProducts()`  
	De header van de functie bestaat maar de inhoud niet.  
	Zorg dat je een lijst maakt met de beschikbare producten (dit zijn producten waarvan nog voorraad bestaat en die niet al op de boodschappenlijst staat).  
- `AddProduct()`   
	Zorg dat het gekozen beschikbare product op de boodschappenlijst komt (door middel van de GroceryListItemsService).  

### UC06 Inloggen  
Een collega is ziek maar heeft al een deel van de inlogfunctionaliteit gemaakt.  
Dit betreft het Loginscherm (LoginView) met bijbehorend ViewModel (LoginViewModel),  
maar ook al een deel van de authenticatieService (AuthServnn,mnmice in Grocery.Core),  
de clientrepository (ClientRepository in Grocery.Core.Data)  
en de client class (Client in Grocery.Core).  
De opdracht is om zelfstandig de login functionaliteit te laten werken.  

*Stappenplan:*  
1. Begin met de Client class en zorg dat er gebruik wordt gemaakt van Properties.  
2. In de ClienRepository wordt nu steeds een vaste client uit de lijst geretourneerd. Werk dit uit zodat de juiste Client wordt geretourneerd.  
3. Werk de klasse AuthService verder uit, zodat daadwerkelijk de controle op het ingevoerde password wordt uitgevoerd.
4. Zorg dat de LoginView.xaml wordt toegevoegd aan het Grocery.App project in de Views folder (Add ExistingItem). De file bevindt zich al op deze plek, maar wordt nu niet meegecompileerd.  
5. In MauiProgramm class van de Grocery.App staan de registraties van de AuthService en de LoginView in comment --> haal de // weg.  
6. In App.xaml.cs staat /*LoginViewModel viewModel*/ haal hier /* en */ weg, zodat het LoginViewModel beschikbaar komt.  
7. In App.xaml.cs staat //MainPage = new LoginView(viewModel); Haal hier de // weg en zet de regel erboven in commentaar, zodat AppShell wordt uitgeschakeld.  
8. Uncomment de route naar het Login scherm in AppShell.xaml.cs: //Routing.RegisterRoute("Login", typeof(LoginView)); 
 
