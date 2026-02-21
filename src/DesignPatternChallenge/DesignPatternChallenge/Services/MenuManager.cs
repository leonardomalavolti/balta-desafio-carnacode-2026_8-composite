using DesignPatternChallenge.Components;

namespace DesignPatternChallenge.Services;

public class MenuManager
{
    private readonly List<MenuComponent> _rootComponents = new();

    public void Add(MenuComponent component)
        => _rootComponents.Add(component);

    public void RenderMenu()
    {
        Console.WriteLine("=== Menu Principal ===\n");

        foreach (var component in _rootComponents)
        {
            component.Render();
        }
    }

    public int GetTotalItems()
    {
        int count = 0;
        foreach (var component in _rootComponents)
        {
            count += component.CountItems();
        }
        return count;
    }

    public MenuComponent FindByUrl(string url)
    {
        foreach (var component in _rootComponents)
        {
            var found = component.FindByUrl(url);
            if (found != null)
                return found;
        }
        return null;
    }
}