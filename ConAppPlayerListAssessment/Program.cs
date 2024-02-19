// See https://aka.ms/new-console-template for more information

using ConAppPlayerListAssessment;
using System;

class Program
{
    static void Main()
    {
        ManagePlayer managePlayer = new ManagePlayer();
        //get all players
        Console.WriteLine("All Players: ");
        var allPlayers = managePlayer.GetPlayers();
        PrintPlayer(allPlayers);

        //get player by id
        int playerIdToFind = 1;
        Console.WriteLine($"\n Player with Id {playerIdToFind}:");
        var playerById = managePlayer.GetPlayerById(playerIdToFind);
        PrintPlayer(playerById);
    }

    static void PrintPlayer(List<Player> players)
    {
        foreach ( var player in players )
        {
            PrintPlayer(player);
        }
    }

    static void PrintPlayer(Player player)
    {
        if(player != null )
        {
            Console.WriteLine($"Id: {player.Id},Name:{player.Name},Age:{player.Age}");

        }
        else
        {
            Console.WriteLine("Player not found.");
        }

    }

}