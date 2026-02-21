using DesignPatternChallenge.Components;

namespace DesignPatternChallenge.Composite;

public class MenuGroup : MenuComponent
{
    private readonly List<MenuComponent> _children = new();

    public MenuGroup(string title, string icon = "")
        : base(title, icon) { }

    public override void Add(MenuComponent component)
        => _children.Add(component);

    public override void Remove(MenuComponent component)
        => _children.Remove(component);

    public override void Render(int indent = 0)
    {
        var indentation = new string(' ', indent * 2);
        var status = IsActive ? "✓" : "✗";
        Console.WriteLine($"{indentation}[{status}] {Icon} {Title} ▼");

        foreach (var child in _children)
        {
            child.Render(indent + 1);
        }
    }

    public override int CountItems()
    {
        int count = 0;
        foreach (var child in _children)
        {
            count += child.CountItems();
        }
        return count;
    }

    public override void Disable()
    {
        IsActive = false;
        foreach (var child in _children)
        {
            child.Disable();
        }
    }

    public override MenuComponent FindByUrl(string url)
    {
        foreach (var child in _children)
        {
            var found = child.FindByUrl(url);
            if (found != null)
                return found;
        }
        return null;
    }
}
