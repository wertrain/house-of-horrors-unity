using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("Prefabs/Room/1Door Room");

        // プレハブを元にオブジェクトを生成する
        GameObject instance = Instantiate(obj,
                                    new Vector3(5.0f, 0.0f, 0.0f),
                                    Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
