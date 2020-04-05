using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    public Text PlauerGoldUI;
    public int PlayerGold;
    public GameObject GoldPrefab;
    public GameObject[] MonstersPrefabs;
    public Transform StartPosition;
    // Start is called before the first frame update
    void Start()
    {
        SpawnMonster();
    }
    public void TakeGold(int gold)
    {
        PlayerGold += gold;
        GameObject goldObj = Instantiate(GoldPrefab) as GameObject;
        goldObj.SetActive(!goldObj.activeSelf);
        Destroy(goldObj, 3);
    }
    // Update is called once per frame
    void Update()
    {
        PlauerGoldUI.text = PlayerGold.ToString();
    }
    public void SpawnMonster()
    {
        int index = 0;

        GameObject monsterObj = Instantiate(MonstersPrefabs[index]) as GameObject;
        monsterObj.SetActive(!monsterObj.activeSelf);
        monsterObj.transform.position = StartPosition.position;
    }
}
