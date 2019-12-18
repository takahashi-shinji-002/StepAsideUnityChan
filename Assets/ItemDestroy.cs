using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {

    // CarPrefab
    public GameObject CarPrefab;
    // ConePrefab
    public GameObject ConePrefab;
    // CoinPrefab
    public GameObject CoinPrefab;

    // オブジェクト
    private GameObject unitychan;

    // Use this for initialization
    void Start () {
        // オブジェクトの取得。
        this.unitychan = GameObject.Find("unitychan");
    }
	
	// Update is called once per frame
	void Update () {
        if (unitychan.transform.position.z -6.0f > gameObject.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
