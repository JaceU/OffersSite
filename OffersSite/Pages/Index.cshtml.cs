using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OffersSite.Pages;

public class IndexModel : PageModel
{
    [ViewData]
    public List<User> Users { get; set; }
    private readonly ILogger<IndexModel> _logger;
    private OffersRetriever Retriever;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Retriever = new OffersRetriever();
        Users = Retriever.getUsers();
    }
    
    public void OnGetSearchForm()
    {
        Retriever = new OffersRetriever();
        Users = Retriever.getUsersByName(Request.Query["NameSearch"]);
    }
}