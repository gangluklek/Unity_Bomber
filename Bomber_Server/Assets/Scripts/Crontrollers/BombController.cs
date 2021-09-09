using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    [SerializeField] private Bomb bombPrefab;
    private Dictionary<int, Bomb> bombs = new Dictionary<int, Bomb>();
    private int curentBombIndex = 0;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public Bomb Create()
    {
        var bomb = Instantiate(bombPrefab);
        var id = curentBombIndex++;
        bomb.Setup(this, id);
        bombs.Add(id, bomb);
        return bomb;
    }

    public void Delete(Bomb bomb)
    {
        Destroy(bomb.gameObject);
    }
}