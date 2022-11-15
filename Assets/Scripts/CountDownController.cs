using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownController : MonoBehaviour
{
    public int i_CountDownTime;
    public TMP_Text m_CountDownDisplay;

    [SerializeField] private GameObject m_HudPanel;
    [SerializeField] private GameObject m_Player;

    public static CountDownController instance;

    private void Awake()
    {
        instance = this;

        m_Player.SetActive(false);
    }

    private void Start()
    {

        StartCoroutine(CountDownToStart());
        
    }

   public IEnumerator CountDownToStart()
    {
        while(i_CountDownTime > 0)
        {
            m_CountDownDisplay.text = i_CountDownTime.ToString();
            yield return new WaitForSeconds(1f);
            i_CountDownTime--;
        }
        m_CountDownDisplay.text = "Tap!!";

        yield return new WaitForSeconds(1f);
        m_HudPanel.gameObject.SetActive(false);
       
        m_Player.SetActive(true);


    }
}

        

       

        
       


