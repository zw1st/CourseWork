namespace CourseWork;

/// <summary>
/// Класс-параметр
/// </summary>
public class StartParameters
{
    public Coin[] Coins;
    public int Sum;
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="sum"></param>
    /// <param name="coins"></param>
    public StartParameters(int sum, params Coin[] coins)
    {
        Coins = coins;
        Sum = sum;
    }
}
