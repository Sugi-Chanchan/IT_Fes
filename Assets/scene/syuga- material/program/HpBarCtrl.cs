using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class HpBarCtrl : MonoBehaviour
{
    public float _hp = 500;
    Slider _slider;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    void Update()
    {
        // HP上昇
        if (_hp == 0)
        {
            // 最大を超えたら0に戻す
            _hp = 100;
        }

        // HPゲージに値を設定
        _slider.value = _hp;
    }
}