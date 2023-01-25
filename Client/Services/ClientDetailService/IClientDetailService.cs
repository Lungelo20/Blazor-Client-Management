namespace RTT.Client.Services.ClientDetailService
{
    public interface IClientDetailService
    {
        List<ClientDetails> ClientDetail { get; set; }
        List<ClientContact> ClientContacts { get; set; }
        Task GetAddresses();
        Task GetContacts();
        Task GetAllClients();
        Task<ClientDetails>  GetAClient(int id);
        Task AddClient(ClientDetails clientDetails);
        Task UpdateClient(ClientDetails clientDetails);
        Task DeleteClient(int id);
    }
}
