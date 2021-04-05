using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
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
    public float float_;
    public float fr;
    public float gr;
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
            Obj_AmDmEm[0].transform.localPosition = new Vector3(Obj_AmDmEm[0].transform.localPosition.x - 50, Obj_AmDmEm[0].transform.localPosition.y);
            for (int i = 1; i <= 3; i++)
            {
                Obj_AmDmEm[i].transform.localPosition = new Vector3(Obj_AmDmEm[i].transform.localPosition.x + 50, Obj_AmDmEm[i].transform.localPosition.y);
            }
            sc++;
        }
        else if (sc == 1)
        {            
            Obj_AmDmEm[1].transform.localPosition = new Vector3(Obj_AmDmEm[1].transform.localPosition.x - 66.6f, Obj_AmDmEm[1].transform.localPosition.y);
            sc++;
        }
        else if (sc == 2)
        {
            Debug.Log("f");
            Obj_AmDmEm[2].transform.localPosition = new Vector3(Obj_AmDmEm[2].transform.localPosition.x - 33.6f, Obj_AmDmEm[1].transform.localPosition.y);


            sc++;
        }
    }

    public GameObject Am;
    RectTransform Am_rt;
    public GameObject Ruler;
    RectTransform Ruler_rt;

    public GameObject DM;
    RectTransform DM_rt;

    public GameObject EM;
    RectTransform EM_rt;
    public int r;
    public int f_;

    
    public void TransitionCHRD()
    {
        SceneManager.LoadScene("Layout_CHRD");
    }
    public void TransitionMLD()
    {
        SceneManager.LoadScene("Layout_MLD");
    }
    public void TransitionARR()
    {
        SceneManager.LoadScene("Layout_ARR");
    }

    public GameObject Mld_Panel;
    public int g = 0;
    public void CallMld_Panel() 
    {
        Debug.Log(g);
        if (g == 0)
        {
            Mld_Panel.gameObject.SetActive(true);
            g = 1;
        }
        else if (g == 1)
        {
            Mld_Panel.gameObject.SetActive(false);
            g = 0;           
        }
    }
    public GameObject Mixer;
    public void CallMld_Mixer()
    {
        Debug.Log(g);
        if (g ==0)
        {
            Mixer.gameObject.SetActive(true);
            g = 1;
        }
        else if (g ==1)
        {
           Mixer.gameObject.SetActive(false);
            g = 0;
        }
    }
    public GameObject MixerPanel01;
    int k = 0;
    public void CallPanelMixer01()
    {
        Debug.Log(g);
        if (k ==0)
        {
            MixerPanel01.gameObject.SetActive(true);
            k = 1;
        }
        else if (g ==1)
        {
            MixerPanel01.gameObject.SetActive(false);
            k = 0;
        }
    }
    public GameObject MixerPanel02;
    public void CallPanelMixer02()
    {
        if (k ==0)
        {
            MixerPanel02.gameObject.SetActive(true);
            k = 1;
        }
        else if (k ==1)
        {
            MixerPanel02.gameObject.SetActive(false);
            k = 0;
        }
    }
    private void Start()
    {
        //Ruler_rt = Ruler.GetComponent<RectTransform>();
        //Am_rt = Am.GetComponent<RectTransform>();       
        //DM_rt = DM.GetComponent<RectTransform>();
        //EM_rt = EM.GetComponent<RectTransform>();
        rt = Ref.GetComponent<RectTransform>();
    }

    public GameObject Ref;
    public RectTransform rt;
    private int number;
    public float Scale = 92.5125f;
    public float Froar;
    //posX увеличиваем на 50 за каждые +2 scale 
    public bool numberTrue;
    public void ScaleInc()
    {
      //  Scale = Ref.transform.localScale.x * 50;
      
        numberTrue = true;
    }    
    public void ScaleDec()
    {
       // Scale = Ref.transform.localScale.x * 50;
      //  Ref.GetComponent<RectTransform>().sizeDelta = new Vector2(50-Scale, Ref.GetComponent<RectTransform>().sizeDelta.y);
        numberTrue = true;
    }
    public void MoveRight()
    {
        Froar = rt.sizeDelta.x/2;

        Debug.Log(rt.sizeDelta.x);
        if (number <= 14)
        {
            number++;
           
            Ref.GetComponent<RectTransform>().transform.localPosition = new Vector3(Ref.transform.localPosition.x + Scale, Ref.transform.localPosition.y);
            Debug.Log(Ref.transform.localPosition.x);
        }
        if (number == 15)
        {

            Ref.GetComponent<RectTransform>().transform.localPosition = new Vector3(Ref.transform.localPosition.x + Scale -100, Ref.transform.localPosition.y);
        }
    }
    public void MoveLeft()
    {
        if (number >= 1)
        {
            number--;

            Ref.GetComponent<RectTransform>().transform.localPosition = new Vector3(Ref.transform.localPosition.x - Scale, Ref.transform.localPosition.y);
            Debug.Log(Ref.transform.localPosition.x);
        }       
    }
    private void Update()
    {
        
            /*
            Am_rt.sizeDelta = new Vector2(Ruler_rt.sizeDelta.x/16*r,Am_rt.sizeDelta.y);            
            EM_rt.sizeDelta = new Vector2(Ruler_rt.sizeDelta.x/16*(16-r+f_), Am_rt.sizeDelta.y);
            EM_rt.sizeDelta = new Vector2(Ruler_rt.sizeDelta.x / 16 * (16 - r+f_), Am_rt.sizeDelta.y);
            */
           
      
    }

}
