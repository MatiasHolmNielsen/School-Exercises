PersonService & PersonServiceClientDesktop

💡 Projektformål

Bygge et komplet C# system bestående af:

En RESTful Web API, der kommunikerer med en SQL Server database

En Windows Forms desktop-klient, der taler med API'et

📊 Arkitekturoversigt

🔹 Backend: PersonService

Teknologier: ASP.NET Core Web API, MS SQL Server, ADO.NET (SqlClient)

Formål: Tilbyde CRUD-operationer over HTTP til persondata

Lagopdeling:

PersonData: Direkte databaseadgang

BusinesslogicLayer: Forretningslogik og validering

DTOs / ModelConversion: Adskiller interne modeller fra API-eksponering

PersonRestService: API-kontrollere

✅ Testet med:

Swagger UI (GET/POST afprøvet)

xUnit testprojekt (test af databaseadgang)

🔹 Frontend: PersonServiceClientDesktop

Teknologier: C# WinForms (.NET 8), HttpClient, Newtonsoft.Json

Formål: Brugergrænseflade der kommunikerer med Web API'et

Lagopdeling:

GuiLayer: WinForms brugerflade

BusinesslogicLayer: Håndtering af applikationslogik

Servicelayer: HTTP kommunikation via HttpClient

ModelLayer: Person-model brugt lokalt i klienten

✅ Funktioner:

Hent alle personer fra databasen (GET)

Opret og gem ny person (POST)

Visuel feedback og fejlbeskeder

🌟 Læring og erfaring

Hvordan man bygger et REST API med ASP.NET Core

Hvordan man opretter forbindelse til en SQL database med SqlClient

Hvordan man opretter et WinForms GUI der kommunikerer med et Web API

Lagdelt arkitektur og "separation of concerns"

Kommunikation over HTTP og JSON mellem frontend og backend

🔮 Testflow

Start Web API (verificér med Swagger)

Start desktopklient

Klik "Get" for at hente personer fra API og database

Udfyld formular og klik "Save" for at oprette ny person

Genindlæs listen for at se den opdaterede database

📆 Fremtidige forbedringer (optionelle)

PUT og DELETE funktionalitet (opdater og slet personer)

Bedre inputvalidering og fejlbeskeder

Bedre UI layout og styling i WinForms

Logning, autentificering, eller ekstra testdækning