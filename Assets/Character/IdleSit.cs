using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleSit : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public float time = 10f;
    private bool siter;
    private bool siter1;
    private float timeSit;
    private float timeSitUp = 5f;
    private float timeFSit = 1.25f;
    // Update is called once per frame

    void Sit()
    {
        time = time - Time.deltaTime;
        if (time <= 0f)
        {
            animator.SetBool("Sit", true);
            siter = true;
            time = Random.Range(120f, 900f);
        }
        //bool sitf = animator.GetBool("Sit");
        if (siter == true)
        {
            timeFSit = timeFSit - Time.deltaTime;
            if (timeFSit <= 0f)
            {
                animator.SetFloat("Multi", 0f);
                siter = false;
                siter1 = true;
                timeSit = Random.Range(5f, 100f);
                timeFSit = 1.25f;
            }
        }

        if (siter1 == true)
        {
            timeSit = timeSit - Time.deltaTime;
            if (timeSit <= 0f)
            {
                timeSitUp = timeSitUp - Time.deltaTime;
                animator.SetFloat("Multi", 1f);
                if (timeSitUp <= 0f)
                {
                    siter1 = false;
                    timeSit = Random.Range(5f, 100f);
                    animator.SetBool("Sit", false);
                    timeSitUp = 5f;
                }
            }
        }
    }

    void Update()
    {
        Sit();
    }
}
