using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
  [SerializeField] private float moveSpeed;
  [SerializeField] private float xMax;
  [SerializeField] private float xMin;
  [SerializeField] private float zMax;
  [SerializeField] private float zMin;
  public int Hp;
  public int maxHp = 5;
  public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
      Hp = 5;
      slider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.D) && this.transform.position.x < xMax)
      {
          transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
      }
      if(Input.GetKey(KeyCode.A) && this.transform.position.x > xMin)
      {
          transform.Translate(new Vector3(-moveSpeed, 0, 0) * Time.deltaTime);
      }
      if(Input.GetKey(KeyCode.W) && this.transform.position.z < zMax)
      {
          transform.Translate(new Vector3(0, 0, moveSpeed) * Time.deltaTime);
      }
      if(Input.GetKey(KeyCode.S) && this.transform.position.z > zMin)
      {
          transform.Translate(new Vector3(0, 0, -moveSpeed) * Time.deltaTime);
      }
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.CompareTag("Enemy"))
      {
        Hp--;
        if(Hp <= 0)
        {
            Destroy(this.gameObject);
        }
        slider.value = (float)Hp / (float)maxHp;
      }
    }

    private void OnDestroy()
    {
      SceneManager.LoadScene("End");
    }
}
