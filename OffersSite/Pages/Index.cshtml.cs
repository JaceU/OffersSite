using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OffersSite.Pages;

public class IndexModel : PageModel
{
    public List<User> Users;
    private readonly ILogger<IndexModel> _logger;
    private OffersContext Context;

    public IndexModel(ILogger<IndexModel> logger, OffersContext context)
    {
        _logger = logger;
        Context = context;
    }

    public void OnGet()
    {
    }
}