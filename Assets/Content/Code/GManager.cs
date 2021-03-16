using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{

    public GameObject ScrollView_Lower;
    private bool p = false;
   

    public GameObject Undo;
    private bool f = false;

    public GameObject[] Obj_AmDmEm;
    int sc = 0;
    public void OnClickTurn()
    {
        if (p == false)
        {
           
          
                ScrollView_Lower.gameObject.SetActive(false);
                
            
         p = true;
        }
        else if (p == true)
        {
          
                ScrollView_Lower.gameObject.SetActive(true);
          
            p = false;
        }
    }

    public void OnClickUndo()
    {
        if (f == false)
        {
            Undo.gameObject.SetActive(true);
            f = true;
        }
        else if (f == true)
        {
            Undo.gameObject.SetActive(false);
            f = false;
        }
    }
    public void OnClickAmDmEm()
    {
       
        if (sc == 0)
        {
            Obj_AmDmEm[0].transform.localPosition = new Vector3(Obj_AmDmEm[0].transform.localPosition.x -15, Obj_AmDmEm[0].transform.localPosition.y);
            for (int i = 1; i <= 3; i++)
            {
                Obj_AmDmEm[i].transform.localPosition = new Vector3(Obj_AmDmEm[i].transform.localPosition.x + 15, Obj_AmDmEm[i].transform.localPosition.y);
            }
            sc++;
        }
       else if (sc == 1)
        {
            Obj_AmDmEm[1].transform.localPosition = new Vector3(Obj_AmDmEm[1].transform.localPosition.x - 15, Obj_AmDmEm[1].transform.localPosition.y);
            Obj_AmDmEm[0].transform.localPosition = new Vector3(Obj_AmDmEm[0].transform.localPosition.x - 15, Obj_AmDmEm[0].transform.localPosition.y);
            for (int i = 2; i <= 3; i++)
            {
                Obj_AmDmEm[i].transform.localPosition = new Vector3(Obj_AmDmEm[i].transform.localPosition.x + 15, Obj_AmDmEm[i].transform.localPosition.y);
            }
            sc++;
        }
        else if (sc == 2)
        {
            Obj_AmDmEm[3].transform.localPosition = new Vector3(Obj_AmDmEm[3].transform.localPosition.x + 30, Obj_AmDmEm[3].transform.localPosition.y);
            sc++;
        }       
    }
}
