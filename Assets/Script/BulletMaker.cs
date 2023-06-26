using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMaker : MonoBehaviour
{
  [SerializeField] private float bulletSpeed;
  [SerializeField] private float lifeTime;
  [SerializeField] private GameObject bulletPrefab;
  private GameObject bullet;
  private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
      {
        bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
        //InstantiateでbulletPrefabを出現させ、出現させたオブジェクトをbulletに代入

        rb = bullet.GetComponent<Rigidbody>(); //bulletのrigidbodyを取得
        rb.AddForce(transform.forward * bulletSpeed); //力を加える

        Destroy(bullet, lifeTime); //bulletをlifeTime秒後に壊す
      }
    }
}
