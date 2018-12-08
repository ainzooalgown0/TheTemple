using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrbManager : MonoBehaviour
{

    //　オブジェクト参照
    private GameObject gameManager; //ゲームマネジャー

    // Use this for initialization
    void Start()
    {

        Debug.Log("デバッグスタート！！");

        gameManager = GameObject.Find("GameManager");

    }

    // Update is called once per frame
    void Update()
    {
        //string filename = "test.jpg";
        //testZikan(filename);
        Debug.Log("デバッグスタート！！");
    }

    //オーブ取得
    public void TouchOrb()
    {
        if (Input.GetMouseButton(0) == false)
        {
            return;
        }

        gameManager.GetComponent<GameManager>().GetOrb();
        Destroy(this.gameObject);
    }


//    public void buttonClick()
//    {
//#if UNITY_ANDROID
//        // Textコンポーネント郡を取得します。
//        var components = this.gameObject.GetComponentsInChildren<Text>();
//        // テキストを文字の状態によって変更するようにします。
//        components[0].text = comp
//                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       onents[0].text == "Button" ? "Changed" : "Button";



//#endif
//    }

//    public void testZikan(filename)
//    {
//#if UNITY_ANDROID
//        string fullPath = "jar:file://" + Application.dataPath + "/!/assets/" + filename;
//        WWW www = new WWW(fullPath);
//        while (!www.isDone)
//        {
//        }
//        FilePath = Application.persistentDataPath + filename;
//        File.WriteAllBytes(toPath, www.bytes);
//#endif
    //}
}
