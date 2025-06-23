using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PhraseSpear : AlgaUISleek
{
[UnityEngine.Serialization.FormerlySerializedAs("SchImage")]
    public Image LopKnife;
[UnityEngine.Serialization.FormerlySerializedAs("AdBtn")]    public Button ByVia;
[UnityEngine.Serialization.FormerlySerializedAs("ReviveText")]    public TextMeshProUGUI PhraseTear;
    // Start is called before the first frame update
    void Start()
    {
        ByVia.onClick.AddListener(ByViaFlute);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void Display()
    {
        base.Display();
        
        MindGazeFaculty.SetBool(CChoppy.Of_MyPhrase, true);
        Heal = 5;
        LopKnife.fillAmount = 1;
        PhraseTear.text = Heal.ToString();
        
        StartCoroutine(ExtolLeaf());
    }

    int Heal= 0;
    
    IEnumerator ExtolLeaf()
    {
        while (Heal >= 0)
        {
            switch (Heal)
            {
                case 5 : DOTween.To(() => LopKnife.fillAmount, x => LopKnife.fillAmount = x,  0.8f, 1.0f).SetEase(Ease.Linear).OnComplete(() => { }); break;
                case 4 : DOTween.To(() => LopKnife.fillAmount, x => LopKnife.fillAmount = x,  0.6f, 1.0f).SetEase(Ease.Linear).OnComplete(() => { }); break;
                case 3 : DOTween.To(() => LopKnife.fillAmount, x => LopKnife.fillAmount = x,  0.4f, 1.0f).SetEase(Ease.Linear).OnComplete(() => { }); break;
                case 2 : DOTween.To(() => LopKnife.fillAmount, x => LopKnife.fillAmount = x,  0.2f, 1.0f).SetEase(Ease.Linear).OnComplete(() => { }); break;
                case 1 : DOTween.To(() => LopKnife.fillAmount, x => LopKnife.fillAmount = x,  0f, 1.0f).SetEase(Ease.Linear).OnComplete(() => { }); break;
            }
            yield return new WaitForSeconds(1);
            Heal--;
            RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Countdown);
            if (Heal < 0)
            {
                SpoonUITrap(GetType().Name);
                HardyDesignHardyFaculty.Instance.FactorFoeQuery();
                HardyDesignHardyFaculty.Instance.FactorLethal();
                yield return new WaitForSeconds(0.2f);
                HardyDesignHardyFaculty.Instance.WhenTileHardySun();
                ByPeat.Equality.ItemMusicologistBy(10005, (success) =>
                {
                    if (success)
                    {
                        // 播放成功逻辑处理
                    }
                });
            }
                
            else
                PhraseTear.text = Heal.ToString();
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        
    }

    private void ByViaFlute()
    {
        //BX 复活位置的点位
        ByPeat.Equality.ItemMortalBy(10003, (success) =>
        {
            if (success)
            {
                // 播放成功逻辑处理
                //广告
                SpoonUITrap(GetType().Name);
                RaiseEka.HisEquality().ItemPuffin(RaiseWell.UIMusic.Sound_Revive);
                HardyDesignHardyFaculty.Instance.LethalPhrase();
            }
            else
            {
                
            }
        });
       
    }
}
