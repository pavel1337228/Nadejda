using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotMove : MonoBehaviour
{

    private RectTransform Char;
    private GameObject[] massive;
    private Animator anim;
    private int i;
    public float timer;
    private int lastI;
    private float fliper;
    public float randStart;
    public float randFinish;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Char = GetComponent<RectTransform>();
        massive = GameObject.FindGameObjectsWithTag("Dot");
        i = Random.Range(0, massive.Length);
        timer = Random.Range(randStart, randFinish);
    }

    void Flip()
    {
        if (fliper <= Char.transform.position.x)
        {
            Char.transform.rotation = Quaternion.Euler(0,0,0);
        }
        if (fliper >= Char.transform.position.x)
        {
            Char.transform.rotation = Quaternion.Euler(0,-180,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            fliper = Char.transform.position.x;
            if (Char.transform.position != massive[i].GetComponent<RectTransform>().transform.position)
            {
                Char.transform.position = Vector3.MoveTowards(Char.transform.position, massive[i].GetComponent<RectTransform>().transform.position, Time.deltaTime*0.8f);
                anim.SetBool("idleMove", true);
                Flip();
                lastI = i;
            }
            if (Char.transform.position == massive[i].GetComponent<RectTransform>().transform.position)
            {
                anim.SetBool("idleMove", false);
               
                i = Random.Range(0, massive.Length);
                while (i == lastI)
                {
                    i = Random.Range(0, massive.Length);
                }   
                timer = Random.Range(randStart, randFinish);
            }
        }
                //Char.anchoredPosition = Mathf.Lerp(Char.anchoredPosition, massive[2].GetComponent<RectTransform>(), Time.deltaTime*2);
        //Char.anchoredPosition = new Vector2(massive[2].GetComponent<RectTransform>().anchoredPosition, massive[2].GetComponent<RectTransform>().anchoredPosition);
    }
}
