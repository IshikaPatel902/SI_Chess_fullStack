using SI_chess.Models;

namespace SI_chess.DAO
{
    public interface IChess
    {
        Task<int> InsertMatches(Matches m);
        Task<Matches> GetMatchesById(int id);

        Task<List<Players>> GetPlayersByCountry(string country);

        Task<List<PlayerPerformance>> GetPlayerPerformance();

        Task<List<PlayerPerformance>> GetPlayerWithHighestWon();
    }
}
