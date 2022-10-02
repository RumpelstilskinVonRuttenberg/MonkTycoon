using UnityEngine;
using CodeMonkey.Utils;


public class GridTester : MonoBehaviour
{
    [SerializeField] private HeatMapVisual heatMapVisual;
    [SerializeField] private HeatMapBoolVisual heatMapBoolVisual;
    [SerializeField] private HeatMapGenericVisual heatMapGenericVisual;
    private Grid<HeatMapGridObject> grid;
    
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid<HeatMapGridObject>(20, 10, 10f, Vector3.zero, (Grid<HeatMapGridObject> g, int x, int y) => new HeatMapGridObject( g, x, y));
        
        //heatMapVisual.SetGrid(grid);
        //heatMapBoolVisual.SetGrid(grid);
        heatMapGenericVisual.SetGrid(grid);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = UtilsClass.GetMouseWorldPosition();
            grid.GetGridObject(position);
            HeatMapGridObject heatMapGridObject = grid.GetGridObject(position);

            if (heatMapGridObject != null)
            {
                heatMapGridObject.AddValue(5);
            }
        }
    }
}

public class HeatMapGridObject
{
    private const int MIN = 0;
    private const int MAX = 100;

    private Grid<HeatMapGridObject> grid;
    private int x;
    private int y;
    private  int value;

    public HeatMapGridObject(Grid<HeatMapGridObject> grid, int x, int y)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
    }

    public void AddValue(int addValue)
    {
        value = Mathf.Clamp(value + addValue, MIN, MAX);
        grid.TriggedGridObjectChanged(x, y);
    }

    public float GetValueNormalized()
    {
        return (float)value / MAX;
    }

    public override string ToString()
    {
        return value.ToString();
    }
}
