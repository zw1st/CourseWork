using System.Text;
namespace CourseWork;

/// <summary>
/// Класс-хранилище
/// </summary>
public class Container
{
    public List<Status> container = new List<Status>();
    private readonly string _statusSeparator = "|";
    private readonly string _keyValueSeparator = ":";
    private readonly string _dictElemsSeparator = ",";
    private readonly string _itemSeparator = ";";
    public int ind = 0;

    public void Add(Status status)
    {
        container.Add(status);
    }
    public Status Get(int id)
    {
        return container[id];
    }
    public int Length()
    {
        return container.Count;
    }
    public bool WriteFile(string path)
    {
        if (container.Count == 0)
        {
            return false;
        }
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        StringBuilder sb = new();
        foreach (Status status in container)
        {
            sb.Append(_itemSeparator);
            sb.Append(ind);
            sb.Append(_statusSeparator);
            sb.Append(status.Sum);
            sb.Append(_statusSeparator);
            int count = 0;
            int amount = 0;
            foreach(Coin coin in status.Coins.Keys)
            {
                sb.Append(coin.Nominal);
                sb.Append(_keyValueSeparator);
                sb.Append(status.Coins[coin]);
                if (count < 2)
                {
                    sb.Append(_dictElemsSeparator);
                }
                amount += status.Coins[coin];
                count++;
            }
            sb.Append(_statusSeparator + amount);
        }
        using FileStream fs = new(path, FileMode.Create);
        byte[] info = new UTF8Encoding(true).GetBytes(sb.ToString());
        fs.Write(info, 0, info.Length);
        return true;
    }
    
    public bool ReadFile(string path)
    {
        if (!File.Exists(path))
        {
            return false;
        }
        string bufferTextFromFile = "";
        using (FileStream fs = new(path, FileMode.Open))
        {
            byte[] b = new byte[fs.Length];
            UTF8Encoding temp = new(true);
            while (fs.Read(b, 0, b.Length) > 0)
            {
                bufferTextFromFile += temp.GetString(b);
            }
        }
        string[] strs = bufferTextFromFile.Split(_itemSeparator,
        StringSplitOptions.RemoveEmptyEntries);
        if (strs == null || strs.Length == 0)
        {
            return false;
        }
        container.Clear();
        foreach (string data in strs)
        {
            Status status = new Status();
            string[] record = data.Split(_statusSeparator,
            StringSplitOptions.RemoveEmptyEntries);
            if (record.Length != 4)
            {
                continue;
            }
            Dictionary<Coin, int> map = new Dictionary<Coin, int>();
            ind = Convert.ToInt32(record[0]);
            status.Sum = Convert.ToInt32(record[1]);
            string[] dict = record[2].Split(_dictElemsSeparator,
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string elem in dict)
            {
                string[] pair = elem.Split(_keyValueSeparator, StringSplitOptions.RemoveEmptyEntries);
                Coin coin = new Coin(Convert.ToInt32(pair[0]));
                map[coin] = Convert.ToInt32(pair[1]);

            }
            status.Coins = new Dictionary<Coin, int>(map);
            status.Amount = Convert.ToInt32(record[3]);
            container.Add(status);
        }
        return true;
    }
}
