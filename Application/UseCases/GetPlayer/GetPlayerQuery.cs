namespace BasqAPI.Application.UseCases.GetPlayer
{
    public class GetPlayerQuery
    {
        public Guid PlayerId { get; }

        public GetPlayerQuery(Guid playerId)
        {
            PlayerId = playerId;
        }
    }
}
