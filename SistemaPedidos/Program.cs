using SistemaPedidos;

Console.WriteLine("=== Parte 1: Lógica ===\n");

var numeros = new List<int> { 3, 7, 2, 9, 7, 2, 5 };
var resultado = Logica.NumeroMasRepetido(numeros);

Console.WriteLine($"Arreglo: [{string.Join(", ", numeros)}]");
Console.WriteLine($"Número que más se repite (empate → mayor): {resultado}");
Console.WriteLine();
Console.WriteLine("Explicación paso a paso:");
Console.WriteLine("1. Contamos apariciones: 3→1, 7→2, 2→2, 9→1, 5→1");
Console.WriteLine("2. La frecuencia máxima es 2 (empatan 7 y 2)");
Console.WriteLine("3. En empate devolvemos el mayor → 7");

Console.WriteLine("\n=== Parte 2: Sistema de pedidos (List<Pedido>) ===\n");

var servicio = new PedidoService();

servicio.Crear("Ana", 150.50m);
servicio.Crear("Luis", 89.99m);
servicio.Crear("Ana", 40.00m);

Console.WriteLine("Pedidos creados:");
foreach (var pedido in servicio.Listar())
{
    Console.WriteLine($"  {pedido}");
}

Console.WriteLine();
var buscado = servicio.ObtenerPorId(2);
Console.WriteLine($"Buscar id 2: {buscado}");

Console.WriteLine($"Total general: {servicio.TotalGeneral():C}");

servicio.Eliminar(2);
Console.WriteLine("\nDespués de eliminar id 2:");
foreach (var pedido in servicio.Listar())
{
    Console.WriteLine($"  {pedido}");
}

Console.WriteLine($"Total general: {servicio.TotalGeneral():C}");
