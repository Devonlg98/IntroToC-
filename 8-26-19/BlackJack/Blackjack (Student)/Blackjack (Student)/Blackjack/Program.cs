using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            char command;
            int money = 100;                // amount of money the player starts with 
            int cardCountD = 0;
            int cardCount = 0;              // number of cards the player has been dealt

            // game loop. To exit, the player can choose to quit at the end of each hand
            while (true)
            {
                // reset the number of cards in the player's hand
                Card[] cards = new Card[10];
                Card[] cardsD = new Card[10];
                cardCount = 0;
                cardCountD = 0;
                int bet = 0;
                Console.WriteLine($"Current Balance ${money}");
                Console.WriteLine("How much would you like to bet this hand? ");

               
                bool success = int.TryParse(Console.ReadLine(), out bet);
                if(success == false)
                {
                    Console.Clear();
                    Console.WriteLine("Illegal input.");
                    continue;
                }
                if (bet > money)
                {
                    Console.Clear();
                    Console.WriteLine("You are too broke!");
                    continue;
                }

                int dealer = 0;
                Console.Clear();
                Console.WriteLine($"Current Balance ${money} |Current bet ${bet}");
                Console.WriteLine(" ");
                Console.WriteLine("Dealer's Cards");
                cardsD[cardCountD++] = DealCard();
                //Console.WriteLine("Dealers Card");
                PrintCardsD(cardsD, cardCountD);
                dealer = CalculateDealer(cardsD, cardCountD);

                Console.WriteLine(" ");
                Console.WriteLine("Your Cards");
                // deal the first card and increment the card count
                cards[cardCount++] = DealCard();
                // print all cards in the player's hand to the console
                PrintCards(cards, cardCount);
                // calculate the sum of all cards in the player's hand
                int total = CalculateTotal(cards, cardCount);
                // player can keep drawing cards until total is over 21
                while (total < 21)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("(H)it or (S)tand? ");
                    success = char.TryParse(Console.ReadLine(), out command);                                        
                    if (success == false)
                    {
                        Console.WriteLine("Illegal input.");  
                        continue;
                    }
                    
                    // if player wants a new card, deal card
                    if (command == 'h' || command == 'H')
                    {
                        // draw a new card, output to console, calculate total
                        Console.Clear();
                        Console.WriteLine($"Current Balance ${money} |Current bet ${bet}"); Console.WriteLine(" ");
                        Console.WriteLine("Dealer's Cards");
                        PrintCardsD(cardsD, cardCountD);
                        Console.WriteLine(" ");



                        //cardsD[cardCountD++] = DealCard();
                        //string dealerHand = cardCountD.ToString();
                        //dealerHand = cardCountD.ToString();

                        Console.WriteLine("Your Cards");
                        cards[cardCount++] = DealCard();
                        PrintCards(cards, cardCount);
                        total = CalculateTotal(cards, cardCount);
                    }
                    else
                    {
                        // any input except 'hit' will be interpreted as 'stand'
                        break;
                    }
                }
                while (CalculateDealer(cardsD, cardCountD) < 17)
                {
                    //cardsD[cardCountD++] = DealCard();
                    //PrintCards(cardsD, cardCountD);
                    cardsD[cardCountD++] = DealCard();

                }
                dealer = CalculateDealer(cardsD, cardCountD);

                // this is a super simple blackjack program, so just simulate the dealer's hand
                // this will just generate a believable random number for the dealer

                // check the dealer's and player's totals against each other to see who won
                
                if (total > 21)
                {
                    Console.Clear();
                    money -= bet;
                    Console.WriteLine($"Current Balance ${money} |Current bet ${bet}"); Console.WriteLine(" ");
                    Console.WriteLine($"Dealer's Cards");
                    PrintCardsD(cardsD, cardCountD);
                    Console.WriteLine(" ");
                    Console.WriteLine($"Your Cards");
                    PrintCards(cards, cardCount);
                    Console.WriteLine(" ");
                    Console.WriteLine("You busted, Dealer wins.");
                }
                else if (dealer > 21)
                {
                    Console.Clear();
                    money += bet;
                    Console.WriteLine($"Current Balance ${money} |Current bet ${bet}"); Console.WriteLine(" ");
                    Console.WriteLine($"Dealer's Cards");
                    PrintCardsD(cardsD, cardCountD);
                    Console.WriteLine(" ");
                    Console.WriteLine($"Your Cards");
                    PrintCards(cards, cardCount);
                    Console.WriteLine(" ");
                    Console.WriteLine("Dealer busts, you win.");
                }
                else if(dealer == total)
                {
                    Console.Clear();
                    Console.WriteLine($"Current Balance ${money} |Current bet ${bet}"); Console.WriteLine(" ");
                    Console.WriteLine($"Dealer's Cards");
                    PrintCardsD(cardsD, cardCountD);
                    Console.WriteLine(" ");
                    Console.WriteLine($"Your Cards");
                    PrintCards(cards, cardCount);
                    Console.WriteLine(" ");
                    Console.WriteLine("You Tied");
                }
                else if (dealer > total)
                {
                    Console.Clear();
                    money -= bet;
                    Console.WriteLine($"Current Balance ${money} |Current bet ${bet}"); Console.WriteLine(" ");
                    Console.WriteLine($"Dealer's Cards");
                    PrintCardsD(cardsD, cardCountD);
                    Console.WriteLine(" ");
                    Console.WriteLine($"Your Cards");
                    PrintCards(cards, cardCount);
                    Console.WriteLine(" ");
                    Console.WriteLine("Dealer wins.");
                }
                else
                {
                    Console.Clear();
                    money += bet;
                    Console.WriteLine($"Current Balance ${money} |Current bet ${bet}"); Console.WriteLine(" ");
                    Console.WriteLine($"Dealer's Cards");
                    PrintCardsD(cardsD, cardCountD);
                    Console.WriteLine(" ");
                    Console.WriteLine($"Your Cards");
                    PrintCards(cards, cardCount);
                    Console.WriteLine(" ");
                    Console.WriteLine("You win.");
                }

                Console.WriteLine("You have {0} in the bank.", money);
                Console.WriteLine("Play again? (Y/N)");
                //char command;
                success = char.TryParse(Console.ReadLine(), out command);
                Console.Clear();
                if (!(command == 'y' || command == 'Y'))
                    break;
            }
        }

        // Function to deal a new random card. 
        // A random value from 1 to 52 is generated, then we use math to 
        // calculate the suit and value of the card
        static Card DealCard()
        {            
            int cardIndex = random.Next() % 52;        // card index, a value from 0 to 51 inclusive
            int suit = cardIndex % 4;
            int value = (cardIndex % 13)+1;         // the value of the card, from 1 to 13h


            return new Card( (Card.Suit)suit, value );
        }

        // Calculates the sum of the value of the cards in the array
        // The first ace is read as 11, and any following ace has a value of 1
        // Other face cards have a value of 10
        // If there is an ace in the cards and the total exceeds 21, then we recount
        // the whole array again but this time all ace cards get a value of 1
        static int CalculateDealer(Card[] cardArray, int size)
        {
            bool hasAce = false;
            bool isFirstTime = true;
            int dealer = 0;

            for (int i = 0; i < size; i++)
            {
                if (cardArray[i].value == 1)
                {
                    if (hasAce == true)
                        dealer += 1;
                    else
                        dealer += 11;
                    hasAce = true;
                }
                else if (cardArray[i].value < 10)
                {
                    dealer += cardArray[i].value;
                }
                else
                {
                    dealer += 10;
                }

                if (dealer > 21 && hasAce && isFirstTime)
                {
                    // if its the first time we've counted, we have an ace in the deck, and
                    // the total value is over 21, then count the whole array again (this time
                    // all aces will have a score of 1 so the total may not go over 21)
                    i = -1;
                    dealer = 0;
                    isFirstTime = false;
                }
            }
            return dealer;
        }

        static int CalculateTotal(Card[] cardArray, int size)
        {
            bool hasAce = false;
            bool isFirstTime = true;
            int total = 0;

            for (int i = 0; i < size; i++)
            {
                if (cardArray[i].value == 1)
                {
                    if (hasAce == true)
                        total += 1;
                    else
                        total += 11;
                    hasAce = true;
                }
                else if (cardArray[i].value < 10)
                {
                    total += cardArray[i].value;
                }
                else
                {
                    total += 10;
                }

                if (total > 21 && hasAce && isFirstTime)
                {
                    // if its the first time we've counted, we have an ace in the deck, and
                    // the total value is over 21, then count the whole array again (this time
                    // all aces will have a score of 1 so the total may not go over 21)
                    i = -1;
                    total = 0;
                    isFirstTime = false;
                }
            }
            return total;
        }

        // This function will step through the cards in the input card array
        // and draw each card to the console.
        // We call the 'calculateTotal' function to get the sum of all cards in the array
        static void PrintCards(Card[] cardArray, int size)
        {

            for (int i = 0; i <= size; i++)
            {
                if (cardArray[i] == null)
                    break;
                Console.Write(cardArray[i].Print());
            }
            Console.WriteLine();
            
            int total = CalculateTotal(cardArray, size);

            Console.WriteLine($"Your Current total: {total}");
            //Console.WriteLine($"Current dealer total: {dealer}");
        }

        static void PrintCardsD(Card[] cardArray, int size)
        {

            for (int i = 0; i <= size; i++)
            {
                if (cardArray[i] == null)
                    break;
                Console.Write(cardArray[i].Print());
            }
            Console.WriteLine();

            int dealer = CalculateDealer(cardArray, size);
            Console.WriteLine($"Current dealer total: {dealer}");
        }

    }
}
