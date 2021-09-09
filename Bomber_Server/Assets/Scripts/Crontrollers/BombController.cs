using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    private const float EXPLODE_SCALE = 3f;
    private const float EXPLODE_TIME = 3f;
    private const float EXPLODE_DURATION = 0.1f;
    [SerializeField] private GameObject sphere;
    private float time = 0;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        time += Time.deltaTime;
        if (time > EXPLODE_TIME)
        {
            GetComponent<Collider>().enabled = true;
            if (time - EXPLODE_TIME > EXPLODE_DURATION)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerController>();
        player!.Death();
    }
}