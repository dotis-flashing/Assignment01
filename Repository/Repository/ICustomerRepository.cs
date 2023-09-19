using BussinessObject.Entity;


namespace Repository.Repository
{
    public interface ICustomerRepository
    {
        Customer Login(string email, string password);
    }
}
