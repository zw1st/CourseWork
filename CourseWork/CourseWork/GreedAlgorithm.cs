namespace CourseWork;

/// <summary>
/// Класс-реализатор
/// </summary>
public class GreedAlgorithm
{
    private int _sum;
    private Dictionary<Coin, int> _coins = new();
    private int _amount;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="sum"></param>
    /// <param name="coins"></param>
    public GreedAlgorithm(int sum, Coin[] coins)
    {
        _sum = sum;
        coins = BubbleSort(coins);
        for (int i = 0; i < coins.Length; i++)
        {
            _coins.Add(coins[i], 0);
        }
        _amount = 0;
    }
    /// <summary>
    /// Метод для выбора номинала
    /// </summary>
    /// <returns></returns>
    public Coin? ChooseNominal()
    {
        foreach (Coin i in _coins.Keys)
        {
            if (_sum >= i.Nominal)
            {
                return i;
            }
        }
        return null;
    }
    /// <summary>
    /// Метод установки состояния
    /// </summary>
    /// <param name="obj"></param>
    public void SetState(Status obj)
    {
        _sum = obj.Sum;
        _coins = obj.Coins;
        _amount = obj.Amount;
    }
    /// <summary>
    /// Метод создания состояния
    /// </summary>
    /// <returns></returns>
    public Status CreateState()
    {
        Status obj = new Status(_sum, _coins, _amount);
        return obj;
    }
    /// <summary>
    /// Проверка на возможность сделать шаг алгоритма
    /// </summary>
    /// <returns></returns>
    public bool AbleToStep()
    {
        Coin? step = ChooseNominal();
        if (step == null)
        {
            return false;
        }
        return true;
    }
    /// <summary>
    /// Метод для шага алгоритма
    /// </summary>
    public void MakeStep()
    {
        Coin? step = ChooseNominal();
        _sum -= step.Nominal;
        _coins[step] += 1;
        _amount += 1;
    }
    /// <summary>
    /// Внутренний метод для сортировки номиналов
    /// </summary>
    /// <param name="coins"></param>
    /// <returns></returns>
    private Coin[] BubbleSort(Coin[] coins)
    {
        for(int i = coins.Length - 1; i > 0; i--)
        {
            for(int j = 0; j < i; j++)
            {
                if (coins[j].Nominal < coins[j + 1].Nominal)
                {
                    Coin temp = coins[j];
                    coins[j] = coins[j + 1];
                    coins[j + 1] = temp;
                }
            }
        }

        return coins;
    }
}


