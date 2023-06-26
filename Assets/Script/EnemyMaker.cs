using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
  [SerializeField] private GameObject enemyPrefab;
  [SerializeField] private float makeTime;
  private float waitTime;
  [SerializeField] private float enemyZ;
  [SerializeField] private float enemyX;
  private float ranX;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(waitTime < makeTime) //enemyが画面に現れるまでの時間を数える
      {
        waitTime = waitTime + Time.deltaTime; //waitTimeにフレーム間の値を足し続け、タイマー的役割を担わせる
      }
      else
      {
        ranX = Random.Range(enemyX * -1, enemyX); //ranXには-enemyXからenemyXまでのどれかの値が入る
        Instantiate(enemyPrefab, new Vector3(ranX, 0, enemyZ), enemyPrefab.transform.rotation);
        //オブジェクトを出現させる((enemyPrefabを、座標に、このrotationで))
        waitTime = 0; //waitTimeを0にすることでもう一度敵が出現するまでの時間を数えさせる
      }
    }
}
