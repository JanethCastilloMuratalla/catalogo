namespace SistemaPedidos;

/// <summary>
/// Parte 1: lógica sobre una lista de enteros.
/// </summary>
public static class Logica
{
    /// <summary>
    /// Encuentra el número que más se repite.
    /// Si hay empate, devuelve el mayor.
    /// </summary>
    public static int NumeroMasRepetido(List<int> numeros)
    {
        if (numeros is null || numeros.Count == 0)
            throw new ArgumentException("La lista no puede estar vacía.");

        // 1) Contar frecuencias
        var frecuencias = new Dictionary<int, int>();
        foreach (var num in numeros)
        {
            if (!frecuencias.ContainsKey(num))
                frecuencias[num] = 0;

            frecuencias[num]++;
        }

        // 2) Buscar la mayor frecuencia; en empate, el número mayor
        int mejorNumero = numeros[0];
        int maxFrecuencia = 0;

        foreach (var (numero, frecuencia) in frecuencias)
        {
            if (frecuencia > maxFrecuencia ||
                (frecuencia == maxFrecuencia && numero > mejorNumero))
            {
                maxFrecuencia = frecuencia;
                mejorNumero = numero;
            }
        }

        return mejorNumero;
    }
}
