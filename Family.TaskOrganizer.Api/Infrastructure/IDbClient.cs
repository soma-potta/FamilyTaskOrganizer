namespace Family.TaskOrganizer.Api.Infrastructure
{
    public interface IDbClient<T> where T : class
    {
        T GetClient();
    }
}
