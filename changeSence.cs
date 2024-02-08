using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UIToolkitDemo
{
    public class changeSence : MonoBehaviour
    {
        public string sceneNameToLoad; // Tên của scene mà bạn muốn chuyển đến

        public void LoadScene()
        {
            SceneManager.LoadScene(sceneNameToLoad); // Load scene với tên được chỉ định
        }

    }
}
