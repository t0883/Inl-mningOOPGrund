namespace OOPGrundInlämning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Skapar variablerna för programmet längst uppe så dom finns med hela tiden i programmet
            Console.CursorVisible = false;
            bool appRunning = true;

            int wallet = 0;
            int oneThousand = 0;
            int fiveHundred = 0;
            int oneHundred = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;

            //Lite kläder som läggs till i klädes listan så man inte behöver manuellt gå in och lägga till varje gång man startar programmet
            Clothes.garnments.Add(new Clothes("Jacket", 1000, "Winterjacket", "Red"));
            Clothes.garnments.Add(new Clothes("Pants", 500, "Outdoor pants for hiking", "Green"));
            Clothes.garnments.Add(new Clothes("Sweater", 400, "Christmas sweater", "White"));
            Clothes.garnments.Add(new Clothes("Hoodie", 400, "Wutan Clan hoodie", "Black and yellow"));
            Clothes.garnments.Add(new Clothes("T-Shirt", 100, "Guns and roses t-shirt", "Black"));

            //Lite mat som läggs till i mat listan så man inte behöver manuellt gå in och lägga till varje gång man startar programmet
            Food.foods.Add(new Food("Sandwich", 35, "Grilled sandwich with tomatoes", "Taste like a regualar sandwich"));
            Food.foods.Add(new Food("Sallad", 85, "Sallad with lettuce, cucumbers, tomatoe and olives", "Taste like kaninmat"));
            Food.foods.Add(new Food("Hot dog", 45, "Hot dog with ketchup and grilled onions", "Taste like god himself grilled the hot dog"));
            Food.foods.Add(new Food("Hamburger", 120, "Hamburger with cheese and a pickel", "Hamburger that beats the McD cheeseburger in a taste test"));
            Food.foods.Add(new Food("Soup", 75, "Tomatoe soup made of tomatoes", "Taste like the tomatoe soup you got from school"));

            //Lite dricka som läggs till i dricka listan så man inte behöver manuellt gå in och lägga till varje gång man startar programmet
            Drink.drinks.Add(new Drink("Coca-Cola Zero", 15, "Looks like cola", "Taste like cola"));
            Drink.drinks.Add(new Drink("Fanta Exotic", 19, "Looks like a Bloody Mary", "Taste like something exotic"));
            Drink.drinks.Add(new Drink("Pepsi Max", 15, "Looks like cola", "Taste like a better version of Coca-Cola"));
            Drink.drinks.Add(new Drink("Redbull", 25, "Looks like something that gives you wings", "Taste like something that could give you wings"));
            Drink.drinks.Add(new Drink("Water", 10, "Transparent liquid", "Taste like water..."));


            do
            {
                //Huvudmenyn för maskinen. Här kan man lägga till saker och starta upp maskinen för försäljning
                Console.WriteLine("--------------------------------");
                Console.WriteLine("           Main menu");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Add items to the vendingmachine.");
                Console.WriteLine("Press 1. for clothes.");
                Console.WriteLine("Press 2. for food.");
                Console.WriteLine("Press 3. for drinks.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Press 4. to boot up vendingmachine.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Press 5. to exit the vendingmachine application.");
                Console.WriteLine("--------------------------------");

                bool invalidSelection = true;

                ConsoleKeyInfo userInput;

                //Loop för användar inputen.
                do
                {
                    userInput = Console.ReadKey(true);

                    if (
                        userInput.Key == ConsoleKey.D1 ||
                        userInput.Key == ConsoleKey.NumPad1 ||
                        userInput.Key == ConsoleKey.D2 ||
                        userInput.Key == ConsoleKey.NumPad2 ||
                        userInput.Key == ConsoleKey.D3 ||
                        userInput.Key == ConsoleKey.NumPad3 ||
                        userInput.Key == ConsoleKey.D4 ||
                        userInput.Key == ConsoleKey.NumPad4 ||
                        userInput.Key == ConsoleKey.D5 ||
                        userInput.Key == ConsoleKey.NumPad5)
                    {
                        invalidSelection = false;
                    }

                } while (invalidSelection);

                Console.Clear();
                Console.CursorVisible = true;

                switch (userInput.Key)
                {
                    //Lägga till kläder i maskinen.
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        try
                        {

                            Console.Write("Enter the name of the item: ");
                            string clothesItem = Console.ReadLine();
                            if (clothesItem != "")
                            {
                                Console.Write("Enter price of the item in SEK: ");
                                int clothesPrice = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter a description of the item: ");
                                string clothesDescription = Console.ReadLine();
                                Console.Write("Enter a color of the item: ");
                                string clothesColor = Console.ReadLine();
                                Clothes.garnments.Add(new Clothes(clothesItem, clothesPrice, clothesDescription, clothesColor));
                                Console.Clear();
                                Console.WriteLine($"{clothesItem} has been added to the vendingmachine. {clothesItem} is listed at {clothesPrice} SEK.");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("No item was added to the vending machine!");
                            }
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            //Console.WriteLine(e.Message);
                            Console.WriteLine("When adding a price of the item please use numbers.");
                            break;
                        }

                        break;

                    //Lägga till mat i maskinen.
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        try
                        {

                            Console.Write("Enter the name of the item: ");
                            string foodItem = Console.ReadLine();
                            if (foodItem != "")
                            {
                                Console.Write("Enter price of the item in SEK: ");
                                int foodPrice = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter a description of the item: ");
                                string foodDescription = Console.ReadLine();
                                Console.Write("Enter a color of the item: ");
                                string foodTaste = Console.ReadLine();
                                Food.foods.Add(new Food(foodItem, foodPrice, foodDescription, foodTaste));
                                Console.Clear();
                                Console.WriteLine($"{foodItem} has been added to the vendingmachine. {foodItem} is listed at {foodPrice} SEK.");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("No item was added to the vending machine!");
                            }
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            //Console.WriteLine(e.Message);
                            Console.WriteLine("When adding a price of the item please use numbers.");
                            break;
                        }

                        break;

                    //Lägga till dricka i maskinen.
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        try
                        {

                            Console.Write("Enter the name of the item: ");
                            string drinkItem = Console.ReadLine();
                            if (drinkItem != "")
                            {
                                Console.Write("Enter price of the item in SEK: ");
                                int drinkPrice = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter a description of the item: ");
                                string drinkDescription = Console.ReadLine();
                                Console.Write("Enter a color of the item: ");
                                string drinkTaste = Console.ReadLine();
                                Drink.drinks.Add(new Drink(drinkItem, drinkPrice, drinkDescription, drinkTaste));
                                Console.Clear();
                                Console.WriteLine($"{drinkItem} has been added to the vendingmachine. {drinkItem} is listed at {drinkPrice} SEK.");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("No item was added to the vending machine!");
                            }
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            //Console.WriteLine(e.Message);
                            Console.WriteLine("When adding a price of the item please use numbers.");
                            break;
                        }

                        break;

                    //Starta upp maskinen och kommer in i en ny loop.
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        bool vendingmachineOpen = true;

                        do
                        {
                            do
                            {
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Welcome to the shop!");
                                if (wallet != 0)
                                {
                                    Console.WriteLine($"You currently have {wallet} SEK to use.");
                                }
                                else
                                {
                                    Console.WriteLine($"You currently have {wallet} SEK to use. Please insert money to start shopping.");
                                }
                                Console.WriteLine("Please press one of the following buttons to acces the item menu.");
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("1. Clothes.");
                                Console.WriteLine("2. Food.");
                                Console.WriteLine("3. Drink.");
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("4. Add money.");
                                Console.WriteLine("5. Return cash.");
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("6. End session and go back.");
                                Console.WriteLine("--------------------------------");
                                userInput = Console.ReadKey(true);

                                if (
                                    userInput.Key == ConsoleKey.D1 ||
                                    userInput.Key == ConsoleKey.NumPad1 ||
                                    userInput.Key == ConsoleKey.D2 ||
                                    userInput.Key == ConsoleKey.NumPad2 ||
                                    userInput.Key == ConsoleKey.D3 ||
                                    userInput.Key == ConsoleKey.NumPad3 ||
                                    userInput.Key == ConsoleKey.D4 ||
                                    userInput.Key == ConsoleKey.NumPad4 ||
                                    userInput.Key == ConsoleKey.D5 ||
                                    userInput.Key == ConsoleKey.NumPad5 ||
                                    userInput.Key == ConsoleKey.D6 ||
                                    userInput.Key == ConsoleKey.NumPad6)
                                {
                                    invalidSelection = false;
                                }

                            } while (invalidSelection);

                            Console.Clear();
                            Console.CursorVisible = true;

                            switch (userInput.Key)
                            {
                                //Klädes menyn.
                                case ConsoleKey.D1:
                                case ConsoleKey.NumPad1:

                                    foreach (Clothes garnment in Clothes.garnments)
                                    {
                                        Console.WriteLine($"{garnment.name} costs {garnment.price} SEK.");
                                        garnment.Description();
                                    }
                                    Console.Write("Do you wish to buy something? (Y/N) ");
                                    string purchaseClothes = Console.ReadLine();
                                    purchaseClothes.ToUpper();
                                    if (purchaseClothes == "Y")
                                    {
                                        Console.Write("Enter the name of the item you wish to buy: ");
                                        string buyItem = Console.ReadLine();

                                        foreach (Clothes garnment in Clothes.garnments)
                                        {
                                            if (garnment.name == buyItem && wallet >= garnment.price)
                                            {
                                                Console.Clear();
                                                wallet -= garnment.price;
                                                garnment.Buy();
                                                garnment.Use();
                                                Clothes.garnments.Remove(garnment);
                                                break;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Rejectet. Not enough cash in the machine.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                    }
                                    break;

                                //Mat menyn.
                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:

                                    foreach (Food food in Food.foods)
                                    {
                                        Console.WriteLine($"{food.name} costs {food.price}.");
                                        food.Description();
                                    }
                                    Console.Write("Do you wish to buy something? (Y/N) ");
                                    string purchaseFood = Console.ReadLine();
                                    purchaseFood.ToUpper();
                                    if (purchaseFood == "Y")
                                    {
                                        Console.Write("Enter the name of the item you wish to buy: ");
                                        string buyItem = Console.ReadLine();

                                        foreach (Food food in Food.foods)
                                        {
                                            if (food.name == buyItem && wallet >= food.price)
                                            {
                                                Console.Clear();
                                                wallet -= food.price;
                                                food.Buy();
                                                food.Use();
                                                Food.foods.Remove(food);
                                                break;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Rejectet. Not enough cash in the machine.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                    }
                                    break;

                                //Drick menyn.
                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:

                                    foreach (Drink drink in Drink.drinks)
                                    {
                                        Console.WriteLine($"{drink.name} costs {drink.price}.");
                                        drink.Description();
                                    }
                                    Console.Write("Do you wish to buy something? (Y/N) ");
                                    string purchaseDrink = Console.ReadLine();
                                    purchaseDrink.ToUpper();
                                    if (purchaseDrink == "Y")
                                    {
                                        Console.Write("Enter the name of the item you wish to buy: ");
                                        string buyItem = Console.ReadLine();

                                        foreach (Drink drink in Drink.drinks)
                                        {
                                            if (drink.name == buyItem && wallet >= drink.price)
                                            {
                                                Console.Clear();
                                                wallet -= drink.price;
                                                drink.Buy();
                                                drink.Use();
                                                Drink.drinks.Remove(drink);
                                                break;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Rejectet. Not enough cash in the machine.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                    }
                                    break;

                                //Sätta in pengar i maskien. Använder mig av en try catch för att inte crasha programmet.
                                case ConsoleKey.D4:
                                case ConsoleKey.NumPad4:

                                    Console.Clear();
                                    Console.Write("Please insert cash to the machine: ");
                                    try
                                    {
                                        wallet += Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("The machine only accept cash in numbers. Please try again");
                                        break;

                                    }

                                    break;

                                //While loop som går igenom wallet och räknar hur mycket av varje valör som ska lämnas tillbaka till kunden.
                                case ConsoleKey.D5:
                                case ConsoleKey.NumPad5:

                                    Console.Clear();
                                    while (wallet >= 1000)
                                    {
                                        oneThousand++;
                                        wallet -= 1000;
                                    }
                                    while (wallet >= 500)
                                    {
                                        fiveHundred++;
                                        wallet -= 500;
                                    }
                                    while (wallet >= 100)
                                    {
                                        oneHundred++;
                                        wallet -= 100;
                                    }
                                    while (wallet >= 50)
                                    {
                                        fifty++;
                                        wallet -= 50;
                                    }
                                    while (wallet >= 20)
                                    {
                                        twenty++;
                                        wallet -= 20;
                                    }
                                    while (wallet >= 10)
                                    {
                                        ten++;
                                        wallet -= 10;
                                    }
                                    while (wallet >= 5)
                                    {
                                        five++;
                                        wallet -= 5;
                                    }
                                    while (wallet >= 1)
                                    {
                                        one++;
                                        wallet -= 1;
                                    }
                                    if (oneThousand != 0)
                                    {
                                        Console.WriteLine($"You have now been returned {oneThousand} one thousand bill(s).");
                                    }
                                    if (fiveHundred != 0)
                                    {
                                        Console.WriteLine($"You have now been returned {fiveHundred} fivehundred bill(s).");
                                    }
                                    if (oneHundred != 0)
                                    {
                                        Console.WriteLine($"You have now been returned {oneHundred} onehundred bill(s).");
                                    }
                                    if (fifty != 0)
                                    {
                                        Console.WriteLine($"You have now been returned {fifty} fifty bill(s).");
                                    }
                                    if (twenty != 0)
                                    {
                                        Console.WriteLine($"You have now been returned {twenty} twenty bill(s).");
                                    }
                                    if (ten != 0)
                                    {
                                        Console.WriteLine($"You have now been returned {ten} ten coin(s).");
                                    }
                                    if (five != 0)
                                    {
                                        Console.WriteLine($"You have now been returned {five} five coin(s).");
                                    }
                                    if (one != 0)
                                    {
                                        Console.WriteLine($"You have now been returned {one} one coin(s).");
                                    }
                                    //Efter programmet har kollat igenom allt så återställs värdet. 
                                    one = 0;
                                    five = 0;
                                    ten = 0;
                                    twenty = 0;
                                    fifty = 0;
                                    oneHundred = 0;
                                    fiveHundred = 0;
                                    oneThousand = 0;
                                    break;

                                //Ett sätt att stänga av maskinen och komma tillbaka till huvudmenyn.
                                case ConsoleKey.D6:
                                case ConsoleKey.NumPad6:
                                    if (wallet != 0)
                                    {
                                        Console.WriteLine("You need to return your money before you leave the store!");
                                    }
                                    else
                                    {
                                        vendingmachineOpen = false;
                                    }
                                    break;
                            }


                        } while (vendingmachineOpen);
                        break;

                    //Ett sätt att stänga av programmet.
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:

                        appRunning = false;

                        break;
                }
            } while (appRunning);
        }
    }
}
