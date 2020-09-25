using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Test : MonoBehaviour
{
    public class Boss
    {
        private int mp = 53;

        public void Magic()
        {

            mp -= 5;

            if (mp < 5)
            {
                UnityEngine.Debug.Log("MPが足りないため魔法が使えない。");

            }
            else
            {
                UnityEngine.Debug.Log("魔法攻撃をした。残りMPは" + mp);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        int[] array = {0, 1, 2, 3, 4};
        for (int i = 0; i < array.Length; i += 1)
        {
            UnityEngine.Debug.Log(array[i]);
        }

        for(int i = 4; i >= 0; i -= 1)
        {
            UnityEngine.Debug.Log(array[i]);
        }
        Boss boss = new Boss ();
        boss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
