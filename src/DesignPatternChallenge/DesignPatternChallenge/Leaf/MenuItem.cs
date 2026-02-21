using DesignPatternChallenge.Components;

namespace DesignPatternChallenge.Leaf;

public class MenuItem : MenuComponent
{
    public string Url { get; private set; }

    public MenuItem(string title, string url, string icon = "")
        : base(title, icon)
    {
        Url = url;
    }

    public override void Render(int indent = 0)
    {
        var indentation = new string(' ', indent * 2);
        var status = IsActive ? "✓" : "✗";
        Console.WriteLine($"{indentation}[{status}] {Icon} {Title} → {Url}");
    }

    public override int CountItems() => 1;

    public override void Disable()
        => IsActive = false;

    public override MenuComponent FindByUrl(string url)
        => Url == url ? this : null;
}