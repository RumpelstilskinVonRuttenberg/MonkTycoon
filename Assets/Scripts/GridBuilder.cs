using System.Collections.Generic;
using CodeMonkey.Utils;
using Grid;
using UnityEngine;

public class GridBuilder : MonoBehaviour
{
    [SerializeField] private GridPlaceable gridPlaceable;
    
    private GridXZ<GridObject> grid;
    private GridPlaceable.Dir dir = GridPlaceable.Dir.Down;
    private void Awake()
    {
        int gridWidth = 10;
        int gridHeigh = 10;
        float cellSize = 10f;
        grid = new GridXZ<GridObject>(gridWidth, gridHeigh, cellSize, Vector3.zero, (GridXZ<GridObject> g, int x, int z)=>new GridObject(g, x, z), this.transform);
    }
    public class GridObject
    {
        private GridXZ<GridObject> grid;
        private int x;
        private int z;
        private Transform transform;

        public GridObject(GridXZ<GridObject> grid, int x, int z) {
            this.grid = grid;
            this.x = x;
            this.z = z;
        }

        public void SetTransform(Transform transform)
        {
            this.transform = transform;
            grid.TriggerGridObjectChanged(x, z);
        }

        public void ClearTransform()
        {
            transform = null;
            grid.TriggerGridObjectChanged(x, z);
        }

        public bool CanBuild()
        {
            return transform == null;
        }

        public override string ToString()
        {
            return x + ", " + z + "\n" + transform ;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.GetXZ(Mouse3D.GetMouseWorldPosition(), out int x, out int z);

            List<Vector2Int> gridPositionList = gridPlaceable.GetGridPositionList(new Vector2Int(x, z), GridPlaceable.Dir.Down);

            bool canBuild = true;
            foreach (Vector2Int gridPosition in gridPositionList)
            {
                if(!grid.GetGridObject(gridPosition.x, gridPosition.y).CanBuild())
                {
                    canBuild = false;
                    break;
                }
            }
            
            if (canBuild)
            {
                Transform buildTransform = Instantiate(gridPlaceable.prefab, grid.GetWorldPosition(x, z), Quaternion.identity);

                foreach (var gridPosition in gridPositionList)
                {
                    grid.GetGridObject(gridPosition.x, gridPosition.y).SetTransform(buildTransform);
                }
            }
            else
            {
                UtilsClass.CreateWorldTextPopup("Cannot build here", Mouse3D.GetMouseWorldPosition());
            }
        }
    }
}


