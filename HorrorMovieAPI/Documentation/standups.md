## Standups 

# 2020-06-03

**Generalsekreterare:** Fredrika

### Gjort färdigt tills idag*

Fredrika:

* SKRAC-234

* SKRAC-240

* SKRAC-252, 254, 255 (ta bort horrorcontext fält som var överflödiga och inte användes)

* Kommentar: Färdigställt cleanup av XML-kommentarer (SKRAC-219). 

  Pagination för ActorController (SKRAC-213) är klar, även autentiseringen för ActorController  (SKRAC-229). Även lagt till Dynamic includes för actor getAllActor().

  

Sebastian:

* SKRAC-208.
* SKRAC-237 (Med fyra subtasks)
* Kommentar: La till props i movies, gjorde även dynamic includes på director.


Aron:

* SKRAC-239
* SKRAC-235
* Kommentar: Lägga till logger och cleanade up dataseed. Nor och jag ändrade i datafilen så att den skulle följa Sebastians nya tillägg av nya props i Movie-model. Detta för att kunna få med ytterligare data till de nya propsen i Movie-modellen. Fick bort en package-varning för swashbuckle som inte användes.

Nor:

* SKRAC-211
* Kommentar: Pagination för MovieController. Satt även med Aron och fixade dataseeding för att få med ytterligare data till de nya propsen i movie-modellen. Redigerade parametrar i MovieController och GenreController, bytte från pagecount till pagesize så att de matchade för i de utskrivna länkarna i HATEOAS så hette de pagecount så det blev fel när man tryckte på länken. 

**Gemensamt:**

* Vi diskuterade ett tag på morgonen för att komma fram till vad vi ville göra med projektet och få med ytterligare då vi var klara med alla issues i sprinten. Vi la då in några fler issues i sprinten.

### Göra till nästa gång*

Fredrika:

* Kommentar: Fortsätta på related movies.
* SKRAC-240

Sebastian:

* SKRAC-208
* Kommentar:  


Nor:

* SKRAC-211

* Kommentar: Pagination för MovieController, dubbelkolla alla XML-kommentarer.

  

Aron:

* Kommentar: Kika på och läsa om att hantera Authorization Policies.



**Göra gemensamt**: 
Städa koden.
Skulle kunna kika på att hantera Authorization Policies.
Man skulle kunna kika på att lägga till mer filtrering, eller kolla på DTOerna om de visar relevant information.

# 2020-06-02

**Generalsekreterare:** Fredrika

### Gjort färdigt tills idag*

Fredrika:

* SKRAC-219

* SKRAC-229

* SKRAC-213

* SKRAC-205

* Kommentar: Färdigställt swagger-dokumentation och XML-kommentarer (SKRAC-219). 

  Pagination för ActorController (SKRAC-213) är klar, även autentiseringen för ActorController  (SKRAC-229). Även lagt till Dynamic includes för actor getAllActor().

  

Sebastian:

* SKRAC-212.
* Satt med pagination för GenreController som nu är klar.


Aron:

* SKRAC-214
* Pagination för DirectorController, jag och Nor satt med arvshierarkin för det generiska repositoriet. 

Nor:

* SKRAC-231
* SKRAC-215
* SKRAC-216
* SKRAC-232
* SKRAC-233
* Ändrade implementationen av det generiska repositoriet (Tillsammans med Aron), löste även testerna (repository-testerna). Tog även bort alla varningar för XML-kommentarerna. Satt också med att fixa generisk GetByID() med dynamic includes. 

Gemensamt:

* Vi satt tillsammans och implementerade paginering, det höll vi på med ända fram till lunch. 

### Göra till nästa gång*

Fredrika:

* Kommentar: Kolla lite på relaterade filmer.

Sebastian:

* SKRAC-208
* Kommentar:  Göra Dynamic include på Director GetAll()


Nor:

* SKRAC-211

* Kommentar: Pagination för MovieController, dubbelkolla alla XML-kommentarer.

  

Aron:

* Kommentar: Kolla på logger i dataseed? kolla generellt på dataseeding, se om man kan få in fler data från den. 



**Göra gemensamt**: 
Städa koden.
Kolla så att alla kommentarer följer samma struktur. Kolla så att alla DTO:er visar relevant information.
Få bort package-referens-warnings. 
Kolla på att fixa relaterade filmer till en film.
Kanske fixa fler filtreringar på requests??





# 2020-06-02

**Generalsekreterare:** Nor

### Gjort färdigt tills idag*

Fredrika:

* SKRAC-219
* Satt med Swagger-dokumentation och XML-kommentarer (SKRAC-219), just nu är den ofärdig. 
* 

Sebastian:

* SKRAC-221
* SKRAC-225
* SKRAC-230
* Lade till kommentarer till Swagger-dokumentation och autentisering för Genre.


Aron:

* SKRAC-228
* SKRAC-222
* SKRAC-230
* Lade till kommentarer till Swagger-dokumentation och autentisering för Director.

Nor:

* SKRAC-223
* SKRAC-227
* Lade till kommentarer till Swagger-dokumentation (endast för DTO) och autentisering för Movie.

Gemensamt:

* Vi satt tillsammans och implementerade Auth0-autentisering till vår API.

### Göra till nästa gång*

Fredrika:

* SKRAC-229
* SKRAC-213
* Kommentar: Implementera Auth0-autentisering (SKRAC-229) och kolla på pagination (SKRAC-213).

Sebastian:

* SKRAC-212
* Kommentar:  Göra pagination för Genre-controller (SKRAC-212).


Nor:

* SKRAC-218

* SKRAC-231

* Kommentar: Lägga till xml-kommentarer (Swagger-dokumentation) för Movie-controller (SKRAC-218) och ändra implementationen för Generiska repository (SKRAC-231).

  

Aron:

* SKRAC-214
* Kommentar: Kolla på pagination (SKRAC-214) och läsa mer om Auth0.

# 2020-06-01

**Generalsekreterare:** Aron	

### Gjort färdigt tills idag*

Fredrika:

* xxx

Sebastian:

* xxx


Aron:

* xxx

Nor:

* xxx

### Göra till nästa gång*

Fredrika:

* SKRAC-229
* SKRAC-219
* SKRAC-224
* Kommentar: Lägga till authentification till ActorController och lägga till Comments for ActorController och Descriptions for ActorDTO Properties.

Sebastian:

* SKRAC-230
* SKRAC-225
* SKRAC-221
* Kommentar:  Lägga till authentification till GenreController och lägga till Comments for GenreController och Descriptions for GenreDTO Properties.


Nor:

* SKRAC-227

* SKRAC-223

* SKRAC-218

* Kommentar: Lägga till authentification till MovieController och lägga till Comments for MovieController och Descriptions for MovieDTO Properties.

  

Aron:

* SKRAC-220
* SKRAC-222
* SKRAC-228
* Kommentar: Lägga till authentification till DirectorController och lägga till Comments for DirectorController och Descriptions for DirectorDTO Properties.

# 2020-05-29

**Generalsekreterare:** Fredrika	

### Gjort färdigt tills idag*

Fredrika:

* SKRAC-195
* SKRAC-193
* SKRAC-207
* Kommentar: Filtrering på movie och genre. Dynamic include för genre. 

Sebastian:

* SKRAC-180
* SKRAC-194
* Kommentar: Filtrering på specifikt år, tester för moviecontroller ( tester för getAll() och GetById()).


Aron:

* SKRAC-203
* Kommentar: Satt och ändrade så att allt såg likadant ut, alla returns ser nu lika dana ut (om jag inte missat nåt). Satt med att försöka lösa paging för projektet. Fixat data seeding för movies. 

Nor:

* SKRAC-192
* Kommentar: Filtrera efter titel på filmer (SKRAC-192). Dynamic include för movies getAll() (SKRAC-206), gjorde detta under samma issue/branch som 192.

## Gjort tillsammans 

Vi gjorde inget större ihop igår, hjälpte varandra när vi behövde hjälp typ. Eftersom att vi lagt till dynamic include bör vi kika över testerna.  



### Göra till nästa gång*

## Sista standupen för denna sprint (Sprint 9).







# 2020-05-28

**Generalsekreterare:** Sebastian	

### Gjort färdigt tills idag*

Fredrika:

* SKRAC-177
* SKRAC-149
* SKRAC-201
* Kommentar: Tester på actor controller och logger för director samt fixade med swagger .

Sebastian:

* SKRAC-195
* Kommentar: Lade HATEOAS i genre controller och börjademed tester .


Aron:

* SKRAC-186
* SKRAC-121
* SKRAC-202
* Kommentar: Gjorde tester för director controller ändrade props i dto-klasserna. 

Nor:

* SKRAC-183
* Kommentar: Gjorde tester för genrecontroller.

## gjort tillsammans 

vi satt alla gemensamt med dependency injection och så satt Nor fredrika och Aron med Swagger 



### Göra till nästa gång*

Fredrika:

* SKRAC-195
* Kommentar: Lägga till filtrering för genre.

Sebastian:

* SKRAC-180
* SKRAC-194
* Kommentar:  Göra färdigt unit tester för Movie-controller (SKRAC-180) och lägga till filtrering för år på filmer.


Aron:



* SKRAC-203

* Kommentar: städa upp koden, läsa på mer om swagger och börja kolla med paging och kanske implementera csv data seed .

  

Nor:

* SKRAC-192
* Kommentar: Lägga till filtrering för movie title och göra om det generiska repot lite.

# 2020-05-27

**Generalsekreterare:** Nor		

### Gjort färdigt tills idag*

Fredrika:

* SKRAC-128
* SKRAC-129
* SKRAC-173
* SKRAC-137
* SKRAC-135
* SKRAC-160
* SKRAC-161
* Kommentar: Har gjort klart SKRAC-126 (grupp), CRUD-funktioner för Movie-controller.

Sebastian:

* SKRAC-165 (150)
* SKRAC-167 (150)
* SKRAC-136
* Kommentar: Lade till Logger och exception-handling till Genre-controller och repository.


Aron:

* SKRAC-131
* SKRAC-176
* SKRAC-142
* Kommentar: Har lagt till API-Requests för DirectorController(SKRAC-131) och la till ExceptionHandling och HATEOAS för DirectorController(SKRAC-176, SKRAC-135). Därefter kikade på fler tester på DirectorRepository. 

Nor:

* SKRAC-157 
* SKRAC-159
* Kommentar: Har endast lagt till logging till Actor-repository.



### Göra till nästa gång*

Fredrika:

* SKRAC-149
* SKRAC-177
* Kommentar: Lägga till logging för Director-repository (SKRAC-149). Lära sig swagger. Göra unit tester för Actor-controller (SKRAC-177).

Sebastian:

* SKRAC-175
* SKRAC-180
* Kommentar: Skapa HATEOAS för Genre-controller (SKRAC-175). Göra unit tester för Movie-controller (SKRAC-180).


Aron:

* SKRAC-186

* Kommentar: Kolla på filtrering/sök-funktioner i API. Läsa om swagger. Göra unit tester för Director-controller (SKRAC-186).

  

Nor:

* SKRAC-183
* SKRAC-149
* Kommentar: Kolla på filtrering/sök-funktioner i API. Läsa om swagger. Göra unit tester för Genre-controller (SKRAC-183). Lägga till tester för Director-repository (SKRAC-149).

# 2020-05-26

**Generalsekreterare:** Aron		

### Gjort färdigt tills idag*

Fredrika:

* SKRAC-127 
* Kommentar: Har gjort klart Skrac-127 som är en del av API Requestsen i MovieController.

Sebastian:

* SKRAC- 138
* Kommentar: Har gjort klart Skrac-138 som var PUT, POST och DELETE Requests för GenreControllern.


Aron:

* SKRAC-163
* SKRAC-155
* SKRAC-169
* Kommentar: Har lagt till tester för GetRequests för GenreRepository(Skrac-163), ActorRepository(Skrac-155) och MovieRepository(Skrac-169) , har också lagt till logger för GenericRepository(Skrac-145). 

Nor:
* SKRAC-122
* SKRAC-174
* Kommentar: Har lagt till Crud Requests i ActorAPI(Skrac-122) och även HATOEAS för Actor(Skrac-174).



### Göra till nästa gång*

Fredrika:
* SKRAC-128
* SKRAC-129
* SKRAC-173
* Kommentar: PutRequest och DeleteRequest för MovieController, SKRAC-128 och SKRAC-129. Därefter börja med HATEOAS för MovieController(Skrac-173).

Sebastian:

* SKRAC-165
* SKRAC-167
* SKRAC-175
* Kommentar: Lägga till logger till GenreRepository(SKRAC-165, SKRAC-167) och ExceptionHandling för GenreController(Skrac-136). Därefter börja med HATEOAS för GenreController(Skrac-175).


Aron:
* SKRAC-131
* SKRAC-176
* SKRAC-142
* Kommentar: Lägga till API-Requests för DirectorController(Skrac-131) och lägga till ExceptionHandling och HATEOAS för DirectorController(Skrac-176, Skrac-135). Därefter kika på fler tester på DirectorRepository.

  

Nor:
* SKRAC-155
* Kommentar: Lägga till fler tester för ActorRepository(Skrac-155).

# 2020-05-25

**Generalsekreterare:** Fredrika		

### Gjort färdigt tills idag*

Fredrika:

* xxx

Sebastian:

* xxx


Aron:

* xxx

Nor:

* xxx



### Göra till nästa gång*

Fredrika:

* SKRAC-126 och SKRAC-173.

Sebastian:

* SKRAC-139, SKRAC-140 och SKRAC-141.


Aron:

* SKRAC-145, SKRAC-169 (tester).

  

Nor:

* SKRAC-122 (apiRequest actor) SKRAC-155 (actor repotester).

# 2020-05-20

**Generalsekreterare:** Sebastian		

### Gjort färdigt tills idag*

Fredrika:

* Kollat hur man kan utvidga generisk controllermetod och researchs men inte fått det att fungera än.

Sebastian:

* Jag har gjort mapping skarc-107.


Anders:

* Jag har varit med när gruppen försökte fixa generisk controllermetod .

André:

* Jag har varit med när gruppen försökte fixa generisk controllermetod och fixade genre  skarc-120 .



### Göra till nästa gång*

Fredrika:

* Skrac-111 göra en controller metod för id och sen även göra skrac-116 göra en repometod för att hitta på id.

Sebastian:

* Börja kolla på HATEOAS skrac 115.


Anders:

* Skrac-114 göra en controller metod för id. 
* Kommer att behöva gå vid lunch idag.

André:

* Skrac-118 ,119 och 113 göra reop metoder för att get by id på movie och genre och skapa metod för det i genre controller.

# 2020-05-19

**Generalsekreterare:** Anders

### Gjort färdigt tills idag*

Fredrika:

* Jag gjorde klar SKRAC-105, -106

Sebastian:

* Jag har gjort SKRAC-103,117 och 112


Anders:

* Jag gjorde klart SKRAC-104, -110, -109

André:

* Jag har gjort SKRAC-108 



### Göra till nästa gång*

Fredrika:

* Ska göra vi gör a Nya issues så vi kan ärva in dom generiska klasserna som vi har i controllerCRUD  istället. Titta på HATEOS 

Sebastian:

* Jag ska göra SKRAC-107.


Anders:

* Avvaktar till eftermiddag då vi skall sitta och se hur vi skall gå vidare med min nästa issues likt Fredrica. Titta på HATEOS
* Kommer att behöva gå till lunch på Onsdag

André:

* Skall fortsätta med Samma sak som som Fredrika och Anders i eftermiddag

# 2020-05-18

**Generalsekreterare:** André

### Gjort färdigt tills idag*

Fredrika:

* Blivit introducerad till projektet.

Sebastian:

* Blivit introducerad till projektet.


Anders:

* Introducerade Fredrika och Sebastian

André:

* Introducerade Fredrika och Sebastian



### Göra till nästa gång*

Fredrika:

* Ska göra SKRAC-105 och börjar på SKRAC-111, SKRAC-116

Sebastian:

* Ska göra SKRAC-103 och börja på SKRAC-117


Anders:

* Ska göra SKRAC-104 och börja på SKRAC-110

André:

* Ska börja på SKRAC-108 när Fredrika är färdig med profile mappen

# 2020-05-15

**Generalsekreterare:** Andreas

### Gjort färdigt tills idag*

Anders:

* Gjort klart SKRAC-96 men fått en merge conflikt
* hjälpte till med fix för GetAll() i samtliga repos

Pierre:

* Gjort klart SKRAC-97 
* fix för GetAll() i samtliga repos 
* suttit med André och byggt vidare på ett test


Andreas:

* SKRAC-97 blev färdig med god hjälp av mina kompisar
* Hann inte läsa om HATEOS

André:

* Gjort klart SKRAC-85 tillsammans med Pierre



### Göra till nästa gång*

Anders:

* Lösa merge konflikten på SKRAC-96
* Gemensamt grupparbete

Pierre:

* Hjälpa Anders med konflikten på SKRAC-96
* Gemensamt grupparbete


Andreas:

* Hjälpa Anders med konflikten på SKRAC-96
* Gemensamt grupparbete

André:

* Hjälpa Anders med konflikten på SKRAC-96
* Gemensamt grupparbete

# 2020-05-14

**Generalsekreterare:** Anders

### Gjort färdigt tills idag*

Anders:

* Jag har gjort färdigt SKRAC-49
* Jag har påbörjat SKRAC-96

Pierre:

* Frånvarande


Andreas:

* Blev färdig med SKRAC-59, -98
* Jag har påbörjat  SKRAC-97

André:

* Gjorde färdigt SKRAC-57, -95



### Göra till nästa gång*

Anders:

* fortsätta med SKRAC-96
* Skall försöka hinna med att läsa om Hateoas

Pierre:

* Frånvarande


Andreas:

* Fortsätta med SKRAC-97
* Skall försöka hinna med att läsa om Hateoas

André:

* Vara med skapa en sprint en ny sprint med tester
* Ta SKRAC-85 samt Ta några nya issues om jag hinner
* Skall försöka hinna med att läsa om Hateoas och se vad vi skall implementera i den

# 2020-05-13

**Generalsekreterare:** Anders

### Gjort färdigt tills idag*

Anders:

* Jag har påbörjat SKRAC-49

Pierre:

* Gjort färdigt SKRAC-66, -65 och -101
* Undersökt hur vi skall gå vidare med Unit Tester


Andreas:

* Blev färdig med SKRAC-46
* Jag har påbörjat  SKRAC-59
* Glömde göra ny branch på SKRAC-46 som gick upp som SKRAC-59 , 
* Får ligga kvar och får åtgärdas i pushen på SKRAC-59

André:

* Gjorde färdigt SKRAC-90, 99, 100
* Jag hade problem med jira och hittade inga nya issues
* Problemet löst nu



### Göra till nästa gång*

Anders:

* fortsätta med SKRAC-49
* försöka ta någon ny issues

Pierre:

* Fortsätta med issues
* Börja med SKRAC-81 Tillsammans med Gruppmedlemmar 


Andreas:

* Fortsätta med SKRAC-59
* Börja med SKRAC-98

André:

* Fortsätta med SKRAC-55 
* Ta någon ny issues

# 2020-05-12

**Generalsekreterare:** André

### Gjort färdigt tills idag*

Anders:

* Har gjort 3 issues SKRAC-86, -91 och -94
* Github är löst. Kan det till 100%

Pierre:

* Gjort färdigt SKRAC-89, -82 och -92
* Uppdaterade alla Repository så att dom ärver från IRepository


Andreas:

* Blev färdig med SKRAC-87

André:

* Gjorde färdigt SKRAC-93 och -88, började på på -90



### Göra till nästa gång*

Anders:

* Ta någon ny issues

Pierre:

* Fortsätta med issues


Andreas:

* Tar SKRAC-59

André:

* Tar några issues

# 2020-05-11

**Generalsekreterare:** Pierre

### Göra till nästa gång

*Nästa standup imorgon cirka kl 11*

Anders:

* Börjar med https://myapi.atlassian.net/browse/SKRAC-86
* Testar om github namn är löst

Pierre:

* Börjar med https://myapi.atlassian.net/browse/SKRAC-82


Andreas:

* Börjar med https://myapi.atlassian.net/browse/SKRAC-87
* Börjar morgondagen cirkus 11

André:

* Börjar med https://myapi.atlassian.net/browse/SKRAC-93
* Börjar morgondagen cirkus 11



# 2020-05-08

**Generalsekreterare:** Andreas

### Gjort fram tills idag:

Anders:

* Har gjort klart alla issues som jag tagit till mig
* Jag har godkännt alla pullrequest jag haft på mig
* Fortsatt träna på git

André:

* Har gjort klart alla issues som jag tagit till mig
* Jag har godkännt alla pullrequest jag haft på mig

Andreas:

* Jag har försökt läsa på vad det andra i gruppen har gjort

Pierre: 

* Arbetat med sprint issues och pull requests


### Göra till nästa gång

Anders:

* Skapa ny Sprint och ta issues därifrån

Pierre:

* Skapa ny Sprint och ta issues därifrån


Andreas:

* Skapa ny Sprint och ta issues därifrån

André:

* Skapa ny Sprint och ta issues därifrån



# 2020-05-07

**Generalsekreterare:** Anders

### Gjort fram tills idag:

Anders:

* Jag har gjort klart SKRAC-51,-79 tills idag och två issues 

* SKRAC-67, -55 väntar på godkännande 

* Jag har tränat på git och Pierre har vägledigt mig.

André:

* Gjort klart SKRAC-80 under lektion. 
* Gjort klart SKRAC-62,-76 som väntar på godkännande.

Andreas:

* Jag har tränat på att bli pappa.

Pierre: 

* Varit med och dragit igång en sprint 

* Gjort klart SKRAC-73, 74, 78 

* Klar med SKRAC-56 som väntar på godkännande 

### Göra till nästa gång

Anders:

* Fortsätta träna på git  göra klart några issues till från våran sprint

Pierre:

* Kolla på pull request 

* Ta nya issues från våran sprint

Andreas:

* Ska bli pappa
* Tar en eller fler issues i mån av tid

André:

* Ta nya issues från våran sprint



# 2020-05-06

**Generalsekreterare:** André

### Gjort fram tills idag

Anders:

* Övat på git
* Var med och godkände förhållningsregler

André:

* Var med och skriv våra förhållningsregler
* Skapade nya issues på Jira
* Testade att skapa ny branch och jobba med det på GitHub

Andreas:

* Var med och skriv våra förhållningsregler
* Skapade nya issues på Jira
* Testade att skapa ny branch och jobba med det på GitHub

Pierre: 

* Var med och planerade förhållningsregler

* Testade med branches i github
* Var med och skrev Jira issues 

### Göra till nästa gång

Anders:

* Träna på git 

* Ta issues från våran Sprint

Pierre:

* Påbörja en Sprint
* Börja jobba på sprint

Andreas:

* Ska bli pappa
* Tar en eller fler issues i mån av tid

André:

* Ta issues från sprint 



# 2020-05-01

**Generalsekreterare:** Pierre

### Gjort fram tills idag

Anders:

* Skapade Fake model till projektet
* Skapade interface IEntity
* Byggde metoder FakeRepository

André:

* Lade till HorrorContext i Model folder
* Byggde metoder FakeRepository
* Fixade i Startup, gjorde om till Mvc projekt

Andreas:

* Skapade IRepository interface i Services folder
* Startade upp FakeRepository med metoder för att byggas på
* Byggde metoder FakeRepository

Pierre: 

* Skapade Controller för vår fake class och byggde GetAll metod
* Byggde metoder i FakeRepository
* Lade till en DbInitializer för att seeda test data