using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldMining : MonoBehaviour
{

    public GameObject HealthDam;
    private Statistic hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = HealthDam.GetComponent<Statistic>();
    }

    void OnMouseDown()
    {
        hp.health = hp.health - 34f;
        hp.mana += 34f;
    }

    // Update is called once per frame
    void Update()
    {

    }я
}
