using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : MonoBehaviour
{

    public GameObject Prefab;
    public Transform pos;
    GameObject player1, player2;

    // Use this for initialization
    void Start()
    {
        player1 = Instantiate(Prefab, pos.position, Quaternion.identity);
        player1.GetComponent<mov>().horizontal="Horizontal";
        player1.GetComponent<mov>().vertical = "Vertical";

        player2 = Instantiate(Prefab, pos.position, Quaternion.identity);
        player2.GetComponent<mov>().horizontal="Horizontal2";
        player2.GetComponent<mov>().vertical="Vertical2";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
