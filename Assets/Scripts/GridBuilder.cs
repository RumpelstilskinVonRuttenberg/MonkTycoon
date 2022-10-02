using System;
using CodeMonkey.Utils;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.InputSystem;

public class GridBuilder : MonoBehaviour
{
    [SerializeField] private Transform testTransform;
    
    private GridXZ<GridObject> grid;
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

            GridObject gridObject = grid.GetGridObject(x, z);

            if (gridObject.CanBuild())
            {
                Transform buildTransform = Instantiate(testTransform, grid.GetWorldPosition(x, z), Quaternion.identity);
                gridObject.SetTransform(buildTransform);
            }
            else
            {
                UtilsClass.CreateWorldTextPopup("Cannot build here", Mouse3D.GetMouseWorldPosition());
            }
        }
    }
}


