using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    public Text PlauerGoldUI;
    public int PlayerGold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlauerGoldUI.text = PlayerGold.ToString();
    }
}
