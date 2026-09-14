namespace SistemaPedidos;

/// <summary>
/// Sistema simple de pedidos usando List&lt;Pedido&gt;.
/// </summary>
public class PedidoService
{
    private readonly List<Pedido> _pedidos = new();
    private int _siguienteId = 1;

    public Pedido Crear(string cliente, decimal total)
    {
        if (string.IsNullOrWhiteSpace(cliente))
            throw new ArgumentException("El cliente es requerido.");

        if (total < 0)
            throw new ArgumentException("El total no puede ser negativo.");

        var pedido = new Pedido
        {
            Id = _siguienteId++,
            Cliente = cliente.Trim(),
            Total = total
        };

        _pedidos.Add(pedido);
        return pedido;
    }

    public List<Pedido> Listar()
    {
        return new List<Pedido>(_pedidos);
    }

    public Pedido? ObtenerPorId(int id)
    {
        return _pedidos.FirstOrDefault(p => p.Id == id);
    }

    public bool Eliminar(int id)
    {
        var pedido = ObtenerPorId(id);
        if (pedido is null)
            return false;

        _pedidos.Remove(pedido);
        return true;
    }

    public decimal TotalGeneral()
    {
        return _pedidos.Sum(p => p.Total);
    }
}
