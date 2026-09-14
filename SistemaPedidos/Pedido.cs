namespace SistemaPedidos;

public class Pedido
{
    public int Id { get; set; }
    public string Cliente { get; set; } = string.Empty;
    public decimal Total { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} | Cliente: {Cliente} | Total: {Total:C}";
    }
}
