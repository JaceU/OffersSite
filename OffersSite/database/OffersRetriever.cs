using Microsoft.EntityFrameworkCore;

namespace OffersSite;

public class OffersRetriever
{
    public OffersContext Context;

    public OffersRetriever()
    {
        Context = new OffersContext();
    }
    public List<User> getUsers()
    {
        return Context.Users.ToList();
    }
    
    public List<User> getUsersById(int id)
    {
        return Context.Users.Where(x => x.Id == id).ToList();
    }
    
    public List<User> getUsersByName(string name)
    {
        return Context.Users.Where(x => x.Name == name).ToList();
    }
}