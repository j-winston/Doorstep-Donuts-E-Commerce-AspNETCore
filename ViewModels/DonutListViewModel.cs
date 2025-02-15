using e_commerce.Models;

namespace e_commerce.ViewModels;

public class DonutListViewModel
{
    public IEnumerable<Donut>? Donuts { get; }
    public string? CurrentCategory { get; }


    public DonutListViewModel(IEnumerable<Donut>? donuts, string currentCategory)
    {
        if (donuts != null)
        {
            Donuts = donuts;

        }

        CurrentCategory = currentCategory;
    }
}


