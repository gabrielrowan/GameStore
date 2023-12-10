using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
        new Game() {
            Id = 1,
            Name = "Street Fighter",
            Genre = "Fighting",
            Price = 19.99m,
            ReleaseDate = new DateTime(1991, 1, 1)
        },
            new Game() {
            Id = 2,
            Name = "Second Game",
            Genre = "Role Play",
            Price = 49.99m,
            ReleaseDate = new DateTime(1991, 2, 1)
        },
        new Game() {
            Id = 3,
            Name = "Game 3",
            Genre = "Fantasy",
            Price = 9.99m,
            ReleaseDate = new DateTime(1991, 3, 1)
        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }
}