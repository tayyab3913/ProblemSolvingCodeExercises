using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCell : MonoBehaviour
{
    public List<GameObject> cellOptions;
    private Cell.Status activeStatus;
    Cell cellScript = new Cell();
    // Start is called before the first frame update
    void Start()
    {
        SetState(cellScript.GetStatus());
        cellScript.onStatusUpdate += SetState;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetState(Cell.Status status)
    {
        for (int i = 0; i < cellOptions.Count; i++)
        {
            if ((int)status == i)
            {
                cellOptions[i].SetActive(true);
            } else
            {
                cellOptions[i].SetActive(false);
            }
        }
    }

    private void OnMouseDown()
    {
        cellScript.SetStatus(Cell.Status.cross); 
    }

    private void OnDestroy()
    {
        cellScript.onStatusUpdate -= SetState;
    }
}
