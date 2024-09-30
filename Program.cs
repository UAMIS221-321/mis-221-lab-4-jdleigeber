string userInput = PizzaMenuChoice();

while(userInput != "4"){
    RouteEm(userInput);
    userInput = PizzaMenuChoice();
}
ExitSequence();

static string PizzaMenuChoice(){
    Console.Clear();
    Console.WriteLine("Enter 1 to display a plain topping-less pizza\nEnter 2 to display cheese pizza slice\nEnter 3 to display pepperoni pizza slice\nEnter 4 to exit");
    Console.Write("Enter your choice: ");
    return Console.ReadLine();
}

static void RouteEm(string userInput){
    switch (userInput){
        case "1":
        PlainPizza();
        break;

        case "2":
        CheesePizza();
        break;

        case "3":
        PepperoniPizza();
        break;

        case "4":
        break;

        default:
        RetrySequence();
        break;
    }
}

static void PlainPizza()
    {
        Random plainPizza = new Random();
        int pizzaRow = plainPizza.Next(8, 13);
        Random order = new Random();
        int orderNum = order.Next(0, 150);
        Console.WriteLine($"Order up for order number {orderNum}");

        for (int i = pizzaRow; i > 0; i--){
            for (int j = 0; j < i; j++){
                Console.Write("^ ");
            }
            Console.WriteLine();
        }
        ToppingKey();
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    static void CheesePizza()
    {
        Random cheesePizza = new Random();
        int pizzaRows = cheesePizza.Next(8, 13); 
        Random order = new Random();
        int orderNum = order.Next(0, 150);
        Console.WriteLine($"Order up for order number {orderNum}");
        for (int i = pizzaRows; i > 0; i--){
            for (int j = 0; j < i; j++){
                if (i == pizzaRows || i == 1 || j == 0 || j == i - 1){
                    Console.Write("^ ");
                }
                else{
                    Console.Write("# ");
                }
            }
            Console.WriteLine();
        }
        ToppingKey();
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    static void PepperoniPizza()
    {
        Random pepPizza = new Random();
        int pizzaRows = pepPizza.Next(8, 13);
        Random order = new Random();
        int orderNum = order.Next(0, 150);
        Console.WriteLine($"Order up for order number {orderNum}");
        for (int i = pizzaRows; i > 0; i--){
            for (int j = 0; j < i; j++){
                if (i == pizzaRows || i == 1 || j == 0 || j == i - 1){
                    Console.Write("^ ");
                }
                else{
                    if (j > 0 && j < i - 1 && pepPizza.Next(0, 5) == 0){
                        Console.Write("[] ");
                    }
                    else{
                        Console.Write("# ");
                    }
                }
            }
            Console.WriteLine();
        }
        ToppingKey();
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    static void ToppingKey(){
        Console.WriteLine("^ = bread\n# = cheese\n[] = pepperoni");
    }
    static void ExitSequence()
    {
        Console.WriteLine("Goodbye!");
    }

    static void RetrySequence()
    {
        Console.WriteLine("Invalid choice, please try again.");
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }