using BoardGamesRentalApplication.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BoardGamesRentalApplication.DAL.MySqlDb
{
    public class MySqlDbInitializer : DropCreateDatabaseAlways<MySqlDbContext>
    {
        protected override void Seed(MySqlDbContext context)
        {
            base.Seed(context);

            IList<BoardGameCategory> defaultBoardGameCategories = new List<BoardGameCategory>();

            defaultBoardGameCategories.Add(new BoardGameCategory() { Name = "Familijne" });
            defaultBoardGameCategories.Add(new BoardGameCategory() { Name = "Ekonomiczne" });
            defaultBoardGameCategories.Add(new BoardGameCategory() { Name = "Strategiczne" });
            defaultBoardGameCategories.Add(new BoardGameCategory() { Name = "Wojenne" });
            defaultBoardGameCategories.Add(new BoardGameCategory() { Name = "Kooperacyjne" });
            defaultBoardGameCategories.Add(new BoardGameCategory() { Name = "Dla dzieci" });
            defaultBoardGameCategories.Add(new BoardGameCategory() { Name = "Karciane" });
            defaultBoardGameCategories.Add(new BoardGameCategory() { Name = "Logiczne" });
            defaultBoardGameCategories.Add(new BoardGameCategory() { Name = "Edukacyjne" });
            defaultBoardGameCategories.Add(new BoardGameCategory() { Name = "Ko�ciane" });

            context.BoardGameCategories.AddRange(defaultBoardGameCategories);

            IList<BoardGameEvaluation> defaultBoardGameEvaluations = new List<BoardGameEvaluation>();

            defaultBoardGameEvaluations.Add(new BoardGameEvaluation() { Name = "�wietna" });
            defaultBoardGameEvaluations.Add(new BoardGameEvaluation() { Name = "Bardzo dobra" });
            defaultBoardGameEvaluations.Add(new BoardGameEvaluation() { Name = "Dobra" });
            defaultBoardGameEvaluations.Add(new BoardGameEvaluation() { Name = "Przeci�tna" });
            defaultBoardGameEvaluations.Add(new BoardGameEvaluation() { Name = "S�aba" });
            defaultBoardGameEvaluations.Add(new BoardGameEvaluation() { Name = "Fatalna" });

            context.BoardGameEvaluations.AddRange(defaultBoardGameEvaluations);

            IList<BoardGamePublisher> defaultBoardGamePublishers = new List<BoardGamePublisher>();

            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Rebel" });
            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Trefl" });
            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Galakta" });
            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Lacerta" });
            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Hobbity" });
            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Phalanx" });
            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Gigamic" });
            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Bard" });
            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Nasza Ksi�garnia" });
            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Adamigo" });
            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Axel" });
            defaultBoardGamePublishers.Add(new BoardGamePublisher() { Name = "Egmont" });

            context.BoardGamePublishers.AddRange(defaultBoardGamePublishers);

            IList<BoardGameState> defaultBoardGameStates = new List<BoardGameState>();

            defaultBoardGameStates.Add(new BoardGameState() { Name = "Bardzo dobry" });
            defaultBoardGameStates.Add(new BoardGameState() { Name = "Dobry" });
            defaultBoardGameStates.Add(new BoardGameState() { Name = "Uszkodzony" });

            context.BoardGameStates.AddRange(defaultBoardGameStates);

            IList<BoardGame> defaultBoardGames = new List<BoardGame>();

            defaultBoardGames.Add(new BoardGame() { Name = "Warcaby"
                                                    , Description = "Warcaby to klasyczna gra towarzyska znana na ca�ym �wiecie od niemal�e o�miuset lat. Celem gry jest �zbicie� wszystkich pionk�w przeciwnika."
                                                    , Content = "Plansza do gry 24 pionki w dw�ch kolorach (czarnym i bia�ym)"
                                                    , MinimumAge = 5
                                                    , GameTimeInMinutes = 15
                                                    , MinPlayerCount = 2
                                                    , MaxPlayerCount = 2
                                                    , RentalCostPerDay = 6.50M
                                                    , Quantity = 0
                                                    , BoardGamePublisherId = 10
                                                    , BoardGamePublisher = defaultBoardGamePublishers[9]
                                                    , BoardGameStateId = 2
                                                    , BoardGameState = defaultBoardGameStates[1]
                                                    , BoardGameCategoryId = 1
                                                    , BoardGameCategory = defaultBoardGameCategories[0]
                                                    , ImagePath = "/images/games/warcaby-list.png"
                                                    , DetailsImagePath = "/images/games/warcaby.png"});

            defaultBoardGames.Add(new BoardGame() { Name = "Rattus: Szczuro�ap"
                                                    , Description = @"Gra dzi�ki kt�rej nauka staje si� zabaw�!
�etony z literkami uk�adamy zakryte na stole,
plansz� z piramid� uk�adamy przed graj�cymi.Uczestnicy zabawy maj� za zadanie zbudowa� na planszy piramid� z liter.Odkrywaj� kolejne literki i dok�adaj� na plansz�,
musz� przy tym zachowa� odpowiedni� kolejno�� liter.Gra pomaga w nauce poprawnego nazywania liter i w nauce kolejno�ci liter
w polskim alfabecie.
"
                                                    , Content = "32 �etony literek plansza 4 pionki instrukcja"
                                                    , MinimumAge = 5
                                                    , GameTimeInMinutes = 35
                                                    , MinPlayerCount = 2
                                                    , MaxPlayerCount = 4
                                                    , RentalCostPerDay = 3.50M
                                                    , Quantity = 3
                                                    , BoardGamePublisherId = 2
                                                    , BoardGamePublisher = defaultBoardGamePublishers[1]
                                                    , BoardGameStateId = 1
                                                    , BoardGameState = defaultBoardGameStates[0]
                                                    , BoardGameCategoryId = 2
                                                    , BoardGameCategory = defaultBoardGameCategories[1]
                                                    , ImagePath = "/images/games/rattus-list.png"
                                                    , DetailsImagePath = "/images/games/rattus.png" });

            defaultBoardGames.Add(new BoardGame() { Name = "Gemino"
                                                    , Description = "Gemino to bardzo przyjemna gra logiczna dla ca�ej rodziny. Proste zasady (podobne do k�ko i krzy�yk) umo�liwiaj� ciekaw�, wci�gaj�c� rozgrywk�. Dzi�ki temu, do gry ch�tnie zasi�d� zar�wno rodzice, dzieci, jak i dziadkowie. Aby wygra�, trzeba planowa� swoje ruchy, blokowa� i przechytrzy� przeciwnik�w na dw�ch planszach jednocze�nie!"
                                                    , Content = "2 dwustronne plansze 56 p�ytek instrukcja"
                                                    , MinimumAge = 7
                                                    , GameTimeInMinutes = 70
                                                    , MinPlayerCount = 2
                                                    , MaxPlayerCount = 4
                                                    , RentalCostPerDay = 2.50M
                                                    , Quantity = 2
                                                    , BoardGamePublisherId = 3
                                                    , BoardGamePublisher = defaultBoardGamePublishers[2]
                                                    , BoardGameStateId = 3
                                                    , BoardGameState = defaultBoardGameStates[2]
                                                    , BoardGameCategoryId = 3
                                                    , BoardGameCategory = defaultBoardGameCategories[2]
                                                    , ImagePath = "/images/games/gemino-list.png"
                                                    , DetailsImagePath = "/images/games/gemino.png"});

            defaultBoardGames.Add(new BoardGame() { Name = "Wyspa Skye"
                                                    , Description = "Mi�kki piasek na pla�ach, �agodne wzg�rza i pot�ne �a�cuchy g�rskie. Tak,�ten wspania�y krajobraz mo�e oczarowa� ka�dego. Niech ten sielankowy obraz jednak ci� nie zmyli. Setki lat temu by� to teren, na kt�rym a� pi�� klan�w walczy�o o dominacj�. Ka�dy z nich zawzi�cie walczy� o przej�cie ka�dego, nawet najmniejszego skrawka ziemi, jednocze�nie pr�buj�c sprzeda� tereny o ma�ej u�yteczno�ci."
                                                    , Content = @"plansza do gry 16 �eton�w punktacji 78 �eton�w terenu 1 worek 5 znacznik�w punktacji 6 �eton�w odrzucenia 6 parawan�w 1 znacznik rund 1 �eton gracza rozpoczynaj�cego 73 monety instrukcja"
                                                    , MinimumAge = 10
                                                    , GameTimeInMinutes = 35
                                                    , MinPlayerCount = 4
                                                    , MaxPlayerCount = 6
                                                    , RentalCostPerDay = 6.50M
                                                    , Quantity = 0
                                                    , BoardGamePublisherId = 3
                                                    , BoardGamePublisher = defaultBoardGamePublishers[2]
                                                    , BoardGameStateId = 3
                                                    , BoardGameState = defaultBoardGameStates[2]
                                                    , BoardGameCategoryId = 4
                                                    , BoardGameCategory = defaultBoardGameCategories[3]
                                                    , ImagePath = "/images/games/wyspaskye-list.png"
                                                    , DetailsImagePath = "/images/games/wyspaskye.png"});

            defaultBoardGames.Add(new BoardGame() { Name = "Res Arcana (edycja polska)"
                                                    , Description = @"W wysokiej wie�y s�ynny alchemik przygotowuje magiczne eliksiry, zlewaj�c ze sob� wielobarwne ciecze nie z tego �wiata, kt�re przechowuje w ozdobnych flakonach. W �wi�tym gaju druid uciera w skupieniu zio�a potrzebne do pradawnego rytua�u, a skryty w ciemno�ciach katakumb nekromanta przywo�uje ko�cianego smoka... Witamy w �wiecie�Res Arcana! To tutaj �ycie, �mier�, wigor, spok�j i z�oto stanowi� esencje niezb�dne tym wszystkim, kt�rzy paraj� si� sztuk� magii.�"
                                                    , Content = "40 kart artefakt�w 10 kart mag�w 10 kart monument�w 150 drewnianych znacznik�w esencji 5 p�ytek enklaw mocy(dwustronnych) 8 magicznych przedmiot�w znacznik pierwszego gracza 12 �eton�w esencji 5x 4 karty pomocy + p�ytka podsumowania instrukcja"
                                                    , MinimumAge = 15
                                                    , GameTimeInMinutes = 10
                                                    , MinPlayerCount = 2
                                                    , MaxPlayerCount = 5
                                                    , RentalCostPerDay = 9.50M
                                                    , Quantity = 1
                                                    , BoardGamePublisherId = 3
                                                    , BoardGamePublisher = defaultBoardGamePublishers[2]
                                                    , BoardGameStateId = 3
                                                    , BoardGameState = defaultBoardGameStates[2]
                                                    , BoardGameCategoryId = 5
                                                    , BoardGameCategory = defaultBoardGameCategories[4]
                                                    , ImagePath = "/images/games/resarcana-list.png"
                                                    , DetailsImagePath = "/images/games/resarcana.png"});

            defaultBoardGames.Add(new BoardGame() { Name = "Wszystko albo nic"
                                                    , Description = "Wszystko albo nic to gra kooperacyjna, czyli oparta na wsp�pracy. Macie wsp�lny cel, odniesiecie wi�c wsp�lne zwyci�stwo albo... wsp�lnie przegracie. Podczas gry b�dziecie wyk�ada� na st� karty akcji o odpowiednich warto�ciach i kolorach. Celem ich wyk�adania jest spe�nienie warunk�w, opisanych na kartach zada�. Wygracie, je�li uda si� Wam wykona� wszystkie zadania! Zadania wydaj� si� proste, ale wcale nie b�dzie �atwo je wykona�.Podczas gry obowi�zuje zakaz komunikowania si� ze sob� na temat kolor�w i warto�ci posiadanych przez Was kart, co znacznie utrudni wykonanie zada� oraz dostarczy wielkich emocji!"
                                                    , Content = "56 kart akcji 50 kart zada� instrukcja"
                                                    , MinimumAge = 18
                                                    , GameTimeInMinutes = 45
                                                    , MinPlayerCount = 2
                                                    , MaxPlayerCount = 4
                                                    , RentalCostPerDay = 3.50M
                                                    , Quantity = 3
                                                    , BoardGamePublisherId = 3
                                                    , BoardGamePublisher = defaultBoardGamePublishers[2]
                                                    , BoardGameStateId = 3
                                                    , BoardGameState = defaultBoardGameStates[2]
                                                    , BoardGameCategoryId = 6
                                                    , BoardGameCategory = defaultBoardGameCategories[5]
                                                    , ImagePath = "/images/games/wszystkoalbonic-list.png"
                                                    , DetailsImagePath = "/images/games/wszystkoalbonic.png"});

            defaultBoardGames.Add(new BoardGame() { Name = "Chi�czyk"
                                                    , Description = "Jest to popularna gra planszowa, przeznaczona dla dw�ch, trzech lub czterech os�b. To doskona�a gra towarzyska, idealna na niedzielne popo�udnia czy deszczowe dni. Uwielbiaj� j� zar�wno dzieci jak i doro�li. Polega na tym, aby jak najszybciej przej�� czterema pionkami przez wszystkie pola rozmieszczone dooko�a planszy. Ma by� to przebycie drogi z pozycji pocz�tkowej (tzw. �baza�) do pozycji ko�cowej (tzw. �domek�) - szybciej ni� pozostali gracze. Ten zawodnik, kt�ry jako pierwszy umie�ci swoje pionki w �domku�, ten wygrywa."
                                                    , Content = "plansza, 16 pionk�w (po 4 pionki w kolorze: ��tym, zielonym, niebieskim, czerwonym), kostka do gry"
                                                    , MinimumAge = 3
                                                    , GameTimeInMinutes = 30
                                                    , MinPlayerCount = 2
                                                    , MaxPlayerCount = 6
                                                    , RentalCostPerDay = 1.50M
                                                    , Quantity = 5
                                                    , BoardGamePublisherId = 2
                                                    , BoardGamePublisher = defaultBoardGamePublishers[1]
                                                    , BoardGameStateId = 1
                                                    , BoardGameState = defaultBoardGameStates[0]
                                                    , BoardGameCategoryId = 3
                                                    , BoardGameCategory = defaultBoardGameCategories[2]
                                                    , ImagePath = "/images/games/chinczyk.png"
                                                    , DetailsImagePath = "/images/games/chinczyk.png"});

            context.BoardGames.AddRange(defaultBoardGames);

            byte[] implicitPassword;
            string explicitPassword = "1234321PasswordHere";
            byte[] salt = new byte[32];
            byte[] implicitWorkerPassword;
            string workerPassword = "Pracownik123"; 
            byte[] salt2 = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
                rng.GetBytes(salt2);
            }
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] password = Encoding.UTF8.GetBytes(explicitPassword);
                byte[] saltedPassword = password.Concat(salt).ToArray();
                implicitPassword = sha512.ComputeHash(saltedPassword);

                byte[] password2 = Encoding.UTF8.GetBytes(workerPassword);
                byte[] saltedPassword2 = password2.Concat(salt2).ToArray();
                implicitWorkerPassword = sha512.ComputeHash(saltedPassword2);
            }

            User adminUser = new User
            {
                Email = "bielikba@wp.pl",
                Username = "ADMINISTRATOR",
                Salt = salt,
                Password = Convert.ToBase64String(implicitPassword),
                FirstName = "Ja",
                LastName = "Admin",
                UserType = UserType.Administrator,
                CreateDate = DateTime.Now,
                LastLogin = DateTime.MinValue
            };
            context.Users.Add(adminUser);

            User worker = new User
            {
                Email = "contact.me@wp.pl",
                Username = "Pracownik",
                Salt = salt2,
                Password = Convert.ToBase64String(implicitWorkerPassword),
                FirstName = "Jan",
                LastName = "Kowalski",
                UserType = UserType.Employee,
                CreateDate = DateTime.Now,
                LastLogin = DateTime.MinValue
            };
            context.Users.Add(worker);

            IList<ReservationStatus> defaultReservationStatuses = new List<ReservationStatus>();

            defaultReservationStatuses.Add(new ReservationStatus() { Name = "Rozpocz�ta" });
            defaultReservationStatuses.Add(new ReservationStatus() { Name = "Zako�czona" });
            defaultReservationStatuses.Add(new ReservationStatus() { Name = "Przetrzymanie" });

            context.ReservationStatuses.AddRange(defaultReservationStatuses);

            IList<DiscountCodeStatus> discountCodeStatuses = new List<DiscountCodeStatus>();

            discountCodeStatuses.Add(new DiscountCodeStatus { Name = "Niedost�pny" });
            discountCodeStatuses.Add(new DiscountCodeStatus { Name = "Dost�pny" });
            discountCodeStatuses.Add(new DiscountCodeStatus { Name = "U�yty" });

            context.DiscountCodeStatuses.AddRange(discountCodeStatuses);

            IList<BoardGameNote> boardGameNotes = new List<BoardGameNote>();

            boardGameNotes.Add(new BoardGameNote { Author = "Zbigniew", Content = "�wietna gra polecam! Gra�em w ni� ca�� noc", BoardGameId = 1, BoardGame = defaultBoardGames[0] });
            boardGameNotes.Add(new BoardGameNote { Author = "Ula", Content = "Kocham t� gre! Jest rewelacyjna. Nie moge si� doczeka� kolejnej parti", BoardGameId = 2, BoardGame = defaultBoardGames[1] });
            boardGameNotes.Add(new BoardGameNote { Author = "Cichy gracz", Content = "Najlepsza gra na �wiecie", BoardGameId = 1, BoardGame = defaultBoardGames[0] });

            context.BoardGameNotes.AddRange(boardGameNotes);
        }
    }
}
