using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRandDrop : MonoBehaviour
{

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public float time = 10f; // Время изменения значения скорости!
    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        if (time <= 0f)
        {
            float rand = Random.Range(0.2f, 2f); // Границы той скорости с рандома
            animator.SetFloat("Random", rand);
            time = 10;
        }
    }
}
