using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObject 
{
    private GridSystem gridSystem;
    private GridPosition gridPosition;
    private List<Unit> unitsAtGridPositionList;

    public GridObject(GridSystem gridSystem, GridPosition gridPosition)
    {
        this.gridSystem = gridSystem;
        this.gridPosition = gridPosition;
        unitsAtGridPositionList = new List<Unit>();
    }

    public void AddUnitAtGridPosition(Unit unit)
    {
        unitsAtGridPositionList.Add(unit);
    }

    public void RemoveUnitAtGridPosition(Unit unit)
    {
        unitsAtGridPositionList.Remove(unit);
    }

    public List<Unit> GetUnitsListAtGridPosition()
    {
        return unitsAtGridPositionList;
    }

    public override string ToString()
    {
        string unitString = "";
        foreach (Unit unit in unitsAtGridPositionList)
        {
            unitString += unit + "\n";
        }
        return gridPosition.ToString() + "\n" + unitString;
    }
}
