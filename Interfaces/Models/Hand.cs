﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Lib.Interfaces;

namespace Common.Lib.Models
{
    public class Hand : IHand
    {
        private List<ICard> hand { get; set; }

        private IDeck deck { get; set; } 
        public Hand()
        {
            deck = new Deck();  //can we replace the deck with another new Deck() outside of the constructor?
            hand = new List<ICard>();
            // deal 2 initial cards
            this.dealCard();
            this.dealCard();

        }

        public void dealCard()
        {
            if (hand.Count() < 5)
            {
                hand.Add(deck.takeCard());
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("The maximum number of cards cannot exceed five  cards.");
            }
        }

        public ICard getCard(int position)
        {
            ICard tempCard = hand[position];
            return tempCard;
        }

        public int scoreHand()
        {
            int tally = 0;
            int numAces = 0;
            
            for (int i = 0; i < hand.Count(); i++)
            {
                if (hand[i].NumericValue >= 10 && hand[i].NumericValue <= 13)
                {
                    tally += 10;
                }
                else if (hand[i].NumericValue == 14)
                {
                    tally += 11;
                    numAces++;
                }
                else if (hand[i].NumericValue > 1 && hand[i].NumericValue <= 9)
                {
                    tally += hand[i].NumericValue;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Card value out of range");
                }
            }
            
            // Ace & facecard (or 10) = Blackjack
            if ((tally == 21) && (hand.Count() == 2))
            {
                return 99;
            }
            
            //change ace(s) from 11 to 1 if the hand is over  21
            while (numAces > 0 && tally > 21) 
            {
                tally -= 10;
                numAces--;
            }

            return tally;
        }
    }
}