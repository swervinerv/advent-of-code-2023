using System.Collections.Generic;
using System.Linq;
using AdventOfCode2023.AoC4.Classes;
using AdventOfCode2023.Helpers;

namespace AdventOfCode2023;

public class AoC4b
{
    public static int Solve(string input)
    {
        var returnValue = 0;

        var cards = new List<Card>();
        var lines = input.ParseToArrayByNewLine();

        foreach (var line in lines)
        {
            cards.Add(new Card(line));
        }

        var cardCount = Enumerable.Range(0, cards.Count).ToDictionary(_ => _, _ => 1);
        for (var cardIndex = 0; cardIndex < cards.Count; cardIndex++)
        {
            var card = cards[cardIndex];

            for (var x = 1; x <= card.WinningNumberCount; x++)
            {
                cardCount[cardIndex + x] = cardCount[cardIndex + x] + cardCount[cardIndex];
            }
        }

        returnValue = cardCount.Values.Sum();

        return returnValue;
    }
}

