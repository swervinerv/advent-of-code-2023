using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2023.AoC2.Classes;

public class Game
{
    private readonly int value;
    private readonly List<BagPull> bagPulls = new();

    public int GameValue
        => this.value;

    public Game(string gameDetails)
    {
        var splitGameAndInputs = gameDetails.Split(':');

        this.value = int.Parse(splitGameAndInputs[0].Trim().Split(' ')[1]);

        this.bagPulls.AddRange(splitGameAndInputs[1].Trim()
            .Split(';')
            .Select(_ => new BagPull(_)));
    }

    public int GetCubePowers()
    {
        var blue = this.bagPulls.Max(_ => _.BlueCount);
        var green = this.bagPulls.Max(_ => _.GreenCount);
        var red = this.bagPulls.Max(_ => _.RedCount);

        return blue * green * red;
    }

    public bool IsValid()
        => !this.bagPulls.Any(_ => !_.IsValid());
}

