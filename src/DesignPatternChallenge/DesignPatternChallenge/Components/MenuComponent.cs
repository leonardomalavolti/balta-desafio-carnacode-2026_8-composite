namespace DesignPatternChallenge.Components;

public abstract class MenuComponent
{
    public string Title { get; protected set; }
    public string Icon { get; protected set; }
    public bool IsActive { get; protected set; } = true;

    protected MenuComponent(string title, string icon = "")
    {
        Title = title;
        Icon = icon;
    }

    public virtual void Add(MenuComponent component)
        => throw new NotSupportedException();

    public virtual void Remove(MenuComponent component)
        => throw new NotSupportedException();

    public abstract void Render(int indent = 0);

    public abstract int CountItems();

    public abstract void Disable();

    public abstract MenuComponent FindByUrl(string url);
}