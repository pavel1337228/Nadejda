using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CaveMining : MonoBehaviour
{	

	public GameObject player;
	public GameObject stone;
	private RectTransform playerrt;
	private RectTransform stonert;

    void Start()
    {
    	playerrt = player.GetComponent<RectTransform>();
    	stonert = stone.GetComponent<RectTransform>();    
    }

    void Update()
    {
    	playerrt.anchoredPosition = stonert.anchoredPosition * Time.deltaTime;	    
    }

    public void OnClick()
    {
    	playerrt.anchoredPosition = stonert.anchoredPosition * Time.deltaTime;
    }
}
