namespace CourseWork;

/// <summary>
/// Класс-состояние
/// </summary>
public class Status
{
    public int Sum;
    public Dictionary<Coin, int> Coins = new Dictionary<Coin, int>();
    public int Amount;
    /// <summary>
    /// Пустой конструктор
    /// </summary>
    public Status()
    {
    }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="sum"></param>
    /// <param name="coins"></param>
    /// <param name="amount"></param>
    public Status(int sum, Dictionary<Coin, int> coins, int amount)
    {
        Sum = sum;
        for (int i = 0; i < coins.Keys.Count; i++)
        {
            Coins.Add(coins.Keys.ToList()[i], coins[coins.Keys.ToList()[i]]);
        }
        Amount = amount;
    }
    public int? GetValue(int key)
    {
        foreach(Coin coin in  Coins.Keys) 
        {
            if (coin.Nominal == key)
            {
                return Coins[coin];
            }
        }
        return null;
    }
    public int GetNominal(int ind)
    {
        return Coins.Keys.ToArray()[ind].Nominal;
    }
}
