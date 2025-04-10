using System;

class Program {

    static int attempts = 0;

    static void Main(string[] args) {

        Welcome();
        PlayGame();
        ByeBye();

    }

    static void Welcome() {

        Console.WriteLine("\n Вітаю у грі 'Бот-числозагадувач'");

    }

    static void PlayGame() {

    Random rand = new Random(); 
    int botNumber = rand.Next(1, 11);
    int player = 0;
    attempts = 0;

    while (botNumber > 0) {

        System.Console.WriteLine("\n Введіть число: ");
        player = Convert.ToInt32(Console.ReadLine());
        attempts++;

    if (player == botNumber) {

        Console.WriteLine("\n Вірно, ви перемогли бота!");
        break;

    }

    else if (player > botNumber) {

        Console.WriteLine("\n «Підказка - Ваше число менше за те що загадав бот»");
        continue;

    }

    else if (player < botNumber) {

        Console.WriteLine("\n «Підказка - Ваше число більше за те що загадав бот»");
        continue;

        }
    }
}

    static void ByeBye() {

        Console.WriteLine("\n Дякую за тестування гри!");
        Console.WriteLine($"\n Всього спроб було використано - {attempts}");

    }
}
