using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoGame : MonoBehaviour
{
  private GameObject data;
  private Data dataCs;

    // Start is called before the first frame update
    void Start()
    {
      data = GameObject.Find("Data");
      dataCs = data.GetComponent<Data>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.Space))
      {
        dataCs.score = 0;
        SceneManager.LoadScene("SampleScene");
      }
    }
}
