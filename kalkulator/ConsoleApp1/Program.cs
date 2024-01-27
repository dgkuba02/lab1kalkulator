// See https://aka.ms/new-console-template for more information
        
        double a = 0;
        double b = 0;
        double c = 0;
        int state = 0;
        
        while(true)
        {
            a = 0;
            b = 0;
            c = 0;
            state = 0;
        
        
        Console.Write("Wpisz liczbę a: ");
        a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Wpisz liczbę b: ");
        b = Convert.ToDouble(Console.ReadLine());
    
        
        Console.WriteLine("Wpisz cyfrę odpowiadajacą temu jakie działanie chcesz wykonać:\n1. Dodawanie\n2. Odejmowanie\n3. Mnozenie\n4. Dzielenie");
        
        state = Convert.ToInt32(Console.ReadLine());
        
        if(state != 1 && state != 2 && state != 3 && state != 4 || state == 4 && b == 0 || state == 4 && a == 0)
        {
            Console.WriteLine("Błąd działania lub błędne liczby.");
            continue; 
        }
        
        switch(state)
        {
            case 1:
            c = a + b;
            break;
            
            case 2:
            c = a - b;
            break;
            
            case 3:
            c = a * b;
            break;
            
            case 4:
            c = a / b;
            break;
            
        }
        
        Console.WriteLine("Wynik to: " + Convert.ToString(c));
        
        Console.WriteLine("Wpisz 'koniec', aby zakonczyć program\nlub naciśnij enter, aby kontynuować.");
       
       if(Console.ReadLine() == "koniec")
       {
           Console.WriteLine("Do widzenia.");
           return;
       }
        Console.Clear();
       }
