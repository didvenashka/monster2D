using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthhelper : MonoBehaviour
{
    public int MaxHealth = 100;
    public int Health = 100;
    public int Gold = 5;
    GameHelper _gameHelper;
    void Start()
    {
        _gameHelper = GameObject.FindObjectOfType<GameHelper>();
    }
    // Start is called before the first frame update
    public void GetHit(int damage)
    {
        int health = Health - damage;
        if (health <= 0)
        {
            _gameHelper.TakeGold(Gold);
            Destroy(gameObject);
        }
        Health = health;
        Debug.Log("Health=" + Health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
