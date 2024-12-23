int N = int.Parse(Console.ReadLine()!);
int R = int.Parse(Console.ReadLine()!);
int C = int.Parse(Console.ReadLine()!);
int T = int.Parse(Console.ReadLine()!);
int F = int.Parse(Console.ReadLine()!);

// Посоки на движение на коня
int[] dRow = { -2, -2, -1, -1, 1, 1, 2, 2 };
int[] dCol = { -1, 1, -2, 2, -2, 2, -1, 1 };

// Опашка за BFS (ред, колона, брой ходове)
Queue<(int row, int col, int moves)> queue = new Queue<(int, int, int)>();
queue.Enqueue((R, C, 0));

// Матрица за посещения
bool[,] visited = new bool[N, N];
visited[R, C] = true;

// BFS
while (queue.Count > 0)
{
    var (currentRow, currentCol, moves) = queue.Dequeue();

    // Проверка дали сме достигнали целта
    if (currentRow == T && currentCol == F)
    {
        Console.WriteLine(moves);
        return;
    }

    // Генериране на следващите позиции
    for (int i = 0; i < 8; i++)
    {
        int newRow = currentRow + dRow[i];
        int newCol = currentCol + dCol[i];

        // Проверка дали позицията е валидна и не е посетена
        if (newRow >= 0 && newRow < N && newCol >= 0 && newCol < N && !visited[newRow, newCol])
        {
            visited[newRow, newCol] = true;
            queue.Enqueue((newRow, newCol, moves + 1));
        }
    }
}

// Ако не може да се достигне целта (не би трябвало да се случи с валидни входни данни)
Console.WriteLine(-1);