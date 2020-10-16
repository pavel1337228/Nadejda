using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotMove : MonoBehaviour
{

    private RectTransform Char;
    private GameObject[] massive;
    private int i;

    // Start is called before the first frame update
    void Start()
    {
        Char = GetComponent<RectTransform>();
        massive = GameObject.FindGameObjectsWithTag("Dot");
        i = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Char.transform.position != massive[i].GetComponent<RectTransform>().transform.position)
        {
            Char.transform.position = Vector3.MoveTowards(Char.transform.position, massive[i].GetComponent<RectTransform>().transform.position, Time.deltaTime);
        }
        if (Char.transform.position == massive[i].GetComponent<RectTransform>().transform.position)
        {
            i = Random.Range(0, 3);
        }
        //Char.anchoredPosition = Mathf.Lerp(Char.anchoredPosition, massive[2].GetComponent<RectTransform>(), Time.deltaTime*2);
        //Char.anchoredPosition = new Vector2(massive[2].GetComponent<RectTransform>().anchoredPosition, massive[2].GetComponent<RectTransform>().anchoredPosition);
    }
}
