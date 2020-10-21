using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleAss : MonoBehaviour
{
    private Animator anim;
    public float timer;
    public float randStart;
    public float randFinish;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        timer = Random.Range(randStart, randFinish);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (anim.GetBool("idleMove") == false)
            {
                anim.SetBool("idleAss", true);
            }
            if (timer <= -5)
            {
                anim.SetBool("idleAss", false);
                timer = Random.Range(randStart, randFinish);
            }
        }
    }
}
