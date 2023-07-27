using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]bool[] acertijo = new bool[3];
    [SerializeField] GameObject canvas;
    
    void Update()
    {
        
    }
    public void Botton1()
    {
        if (acertijo[0])
        {
            acertijo[0] = false;
        }
        else
        {
            acertijo[0] = true;
        }
    }
    public void Botton2()
    {
        if (acertijo[1])
        {
            acertijo[1] = false;
        }
        else
        {
            acertijo[1] = true;
        }
    }
    public void Botton3()
    {
        if (acertijo[2])
        {
            acertijo[2] = false;
        }
        else
        {
            acertijo[2] = true;
        }
    }
    public void Confirmar()
    {
        if (acertijo[0] && acertijo[1] == false && acertijo[2])
        {
            canvas.SetActive(false);
            Time.timeScale = 1;
        }
    }

}
