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
                                                    , Quantity = 0
                                                    , BoardGamePublisherId = 10
                                                    , BoardGamePublisher = defaultBoardGamePublishers[9]
                                                    , BoardGameStateId = 2
                                                    , BoardGameState = defaultBoardGameStates[1]
                                                    , BoardGameCategoryId = 1
                                                    , BoardGameCategory = defaultBoardGameCategories[0]});

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
                                                    , Quantity = 3
                                                    , BoardGamePublisherId = 2
                                                    , BoardGamePublisher = defaultBoardGamePublishers[1]
                                                    , BoardGameStateId = 1
                                                    , BoardGameState = defaultBoardGameStates[0]
                                                    , BoardGameCategoryId = 2
                                                    , BoardGameCategory = defaultBoardGameCategories[1] });

            defaultBoardGames.Add(new BoardGame() { Name = "Gemino"
                                                    , Description = "Gemino to bardzo przyjemna gra logiczna dla ca�ej rodziny. Proste zasady (podobne do k�ko i krzy�yk) umo�liwiaj� ciekaw�, wci�gaj�c� rozgrywk�. Dzi�ki temu, do gry ch�tnie zasi�d� zar�wno rodzice, dzieci, jak i dziadkowie. Aby wygra�, trzeba planowa� swoje ruchy, blokowa� i przechytrzy� przeciwnik�w na dw�ch planszach jednocze�nie!"
                                                    , Content = "2 dwustronne plansze 56 p�ytek instrukcja"
                                                    , MinimumAge = 7
                                                    , GameTimeInMinutes = 70
                                                    , MinPlayerCount = 2
                                                    , MaxPlayerCount = 4
                                                    , Quantity = 2
                                                    , BoardGamePublisherId = 3
                                                    , BoardGamePublisher = defaultBoardGamePublishers[2]
                                                    , BoardGameStateId = 3
                                                    , BoardGameState = defaultBoardGameStates[2]
                                                    , BoardGameCategoryId = 3
                                                    , BoardGameCategory = defaultBoardGameCategories[2] });

            defaultBoardGames.Add(new BoardGame() { Name = "Fourth Name"
                                                    , Description = "Fourth Description"
                                                    , Content = "Fourth Content"
                                                    , MinimumAge = 10
                                                    , GameTimeInMinutes = 35
                                                    , MinPlayerCount = 4
                                                    , MaxPlayerCount = 6
                                                    , Quantity = 0
                                                    , BoardGamePublisherId = 3
                                                    , BoardGamePublisher = defaultBoardGamePublishers[2]
                                                    , BoardGameStateId = 3
                                                    , BoardGameState = defaultBoardGameStates[2]
                                                    , BoardGameCategoryId = 4
                                                    , BoardGameCategory = defaultBoardGameCategories[3] });

            defaultBoardGames.Add(new BoardGame() { Name = "Fifth Name"
                                                    , Description = "Fifth Description"
                                                    , Content = "Fifth Content"
                                                    , MinimumAge = 15
                                                    , GameTimeInMinutes = 10
                                                    , MinPlayerCount = 2
                                                    , MaxPlayerCount = 5
                                                    , Quantity = 1
                                                    , BoardGamePublisherId = 3
                                                    , BoardGamePublisher = defaultBoardGamePublishers[2]
                                                    , BoardGameStateId = 3
                                                    , BoardGameState = defaultBoardGameStates[2]
                                                    , BoardGameCategoryId = 5
                                                    , BoardGameCategory = defaultBoardGameCategories[4] });

            defaultBoardGames.Add(new BoardGame() { Name = "Sixth Name"
                                                    , Description = "Sixth Description"
                                                    , Content = "Sixth Content"
                                                    , MinimumAge = 18
                                                    , GameTimeInMinutes = 45
                                                    , MinPlayerCount = 2
                                                    , MaxPlayerCount = 6
                                                    , Quantity = 3
                                                    , BoardGamePublisherId = 3
                                                    , BoardGamePublisher = defaultBoardGamePublishers[2]
                                                    , BoardGameStateId = 3
                                                    , BoardGameState = defaultBoardGameStates[2]
                                                    , BoardGameCategoryId = 6
                                                    , BoardGameCategory = defaultBoardGameCategories[5] });

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
        }
    }
}
