namespace CourseWork;

/// <summary>
/// Класс-визуализатор
/// </summary>
public class Drawing
{
    private readonly int? _pictureWidth;
    private readonly int? _pictureHeight;
    private readonly int _drawingCoinDiameter = 50;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="pictureWidth"></param>
    /// <param name="pictureHeight"></param>
    public Drawing(int pictureWidth, int pictureHeight)
    {
        _pictureWidth = pictureWidth;
        _pictureHeight = pictureHeight;
    }

    /// <summary>
    /// Метод отрисовки состояния
    /// </summary>
    /// <param name="g"></param>
    /// <param name="status"></param>
    /// <param name="finalStatus"></param>
    public void DrawStatus(Graphics g, Status status, Status finalStatus)
    {
        Pen pen = new Pen(Color.Black, 4);
        Brush numberBrush = new SolidBrush(Color.Black);
        Brush brush = new SolidBrush(Color.Gold);
        Coin[] coinArr = status.Coins.Keys.ToArray();
        Font font = new Font("Arial", 12);
        for (int i = 0; i < coinArr.Length; i++)
        {
            int? maxInLine = finalStatus.GetValue(coinArr[i].Nominal);
            for(int j = 0; j < status.Coins[coinArr[i]]; j++)
            {
                
                g.DrawEllipse(pen, j * (int)((_pictureWidth - 170) / maxInLine) + 130, i * 70 + 40,  _drawingCoinDiameter, _drawingCoinDiameter);
                g.FillEllipse(brush, j * (int)((_pictureWidth - 170) / maxInLine) + 130, i * 70 + 40, _drawingCoinDiameter, _drawingCoinDiameter);
                g.DrawString(coinArr[i].Nominal.ToString(), font, numberBrush, j * (int)((_pictureWidth - 170) / maxInLine) + 142, i * 70 + 52);
            }
            
        }       
    }
}
