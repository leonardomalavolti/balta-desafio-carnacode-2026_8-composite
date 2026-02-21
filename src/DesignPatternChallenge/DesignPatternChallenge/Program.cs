using DesignPatternChallenge.Composite;
using DesignPatternChallenge.Leaf;
using DesignPatternChallenge.Services;

Console.WriteLine("=== Sistema de Menus CMS ===\n");

var manager = new MenuManager();

manager.Add(new MenuItem("Home", "/", "🏠"));

var products = new MenuGroup("Produtos", "📦");
products.Add(new MenuItem("Todos", "/produtos"));
products.Add(new MenuItem("Categorias", "/categorias"));
products.Add(new MenuItem("Ofertas", "/ofertas"));

var clothing = new MenuGroup("Roupas", "👕");
clothing.Add(new MenuItem("Camisetas", "/roupas/camisetas"));
clothing.Add(new MenuItem("Calças", "/roupas/calcas"));

products.Add(clothing);
manager.Add(products);

var admin = new MenuGroup("Administração", "⚙️");
admin.Add(new MenuItem("Usuários", "/admin/usuarios"));
admin.Add(new MenuItem("Configurações", "/admin/config"));

manager.Add(admin);
manager.RenderMenu();


Console.WriteLine($"\nTotal de itens: {manager.GetTotalItems()}");

var found = manager.FindByUrl("/roupas/camisetas");
if (found != null)
    Console.WriteLine($"\n✓ Encontrado: {found.Title}");

Console.WriteLine("\nDesabilitando Produtos...");
products.Disable();

manager.RenderMenu();

Console.ReadKey();