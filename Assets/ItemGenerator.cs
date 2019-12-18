using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
    // CarPrefab
    public GameObject CarPrefab;
    // ConePrefab
    public GameObject ConePrefab;
    // CoinPrefab
    public GameObject CoinPrefab;
    // スタート地点
    private int StartPos = -160;
    //　ゴール地点
    private int GoalPos = 120;
    // アイテムを出すx方向の範囲
    private float posRange = 3.4f;
    
    // Use this for initialization
    void Start () {
        // 一定の距離ごとにアイテムを生成
        for (int i = StartPos; i < GoalPos; i += 15)
        {
            // どのアイテムを出すかランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                // コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(ConePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {
                // レーンごとにアイテムを生成
                for (int j = -1; j <= 1; j++)
                {
                    // アイテムの種類を決める。
                    int item = Random.Range(1, 11);
                    // アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    // 60%コイン配置:30%車配置:10%特になし。
                    if (1 <= item && item <= 6)
                    {
                        // コイン生成
                        GameObject coin = Instantiate(CoinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        // 車を生成
                        GameObject car = Instantiate(CarPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
