internal class Program
{
    private static void Main(string[] args)
    {
        // matriz 3 colunas e 5 linhas de numeros reais
        // o valor da 3a coluna é a média dos valores das duas primeiras

        double[,] matriz = new double[5, 3];

        // montagem das colunas 1 e 2 da matriz

        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                matriz[linha, coluna] += (linha * coluna) + 2;
            }
        }

        // montagem das colunas 3 da matriz

        for (int linha = 0; linha < 5; linha++)
        {
            matriz[linha, 2] += ((matriz[linha, 0] + matriz[linha, 1]) / 2);
        }

        // Impressao da matriz

        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.WriteLine($"Posição [{linha},{coluna}] - valor: {matriz[linha, coluna]}");
            }
        }

    }
}