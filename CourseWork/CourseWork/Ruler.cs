namespace CourseWork;

/// <summary>
/// Класс-управленец
/// </summary>
public class Ruler
{
    public Container container;
    StartParameters startParameters;
    GreedAlgorithm greedAlgorhitm;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="startParameters"></param>
    public Ruler(StartParameters startParameters)
    {
        container = new Container();
        this.startParameters = startParameters;
    }

    /// <summary>
    /// Метод, записывающий в контейнер все состояния алгоритма
    /// </summary>
    /// <returns></returns>
    public Container Perform()
    {
        greedAlgorhitm = new GreedAlgorithm(startParameters.Sum, startParameters.Coins);
        Status obj1 = greedAlgorhitm.CreateState();
        container.Add(obj1);
        while (greedAlgorhitm.AbleToStep()){
            greedAlgorhitm.MakeStep();
            Status obj = greedAlgorhitm.CreateState();

            container.Add(obj);
            
        }
        return container;
    }
}
