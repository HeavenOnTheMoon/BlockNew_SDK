using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Image = UnityEngine.UI.Image;
using TMPro;

public class CrudeCobalt : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Mask")]
    public GameObject Five;
[UnityEngine.Serialization.FormerlySerializedAs("BG")]    public GameObject BG;
[UnityEngine.Serialization.FormerlySerializedAs("targetList")]    public List<GameObject> SeldomName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
        Five.GetComponent<Image>().color = new UnityEngine.Color(0f,0f,0f,0.62f);
        BG.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 1);
        BG.transform.localScale = new Vector3(0, 0, 0);
        
    }

    public void Folk(List<GameObject> GamepanelBlockGroupList) 
    {

        for (int i = 0; i < GamepanelBlockGroupList.Count; i++)
        {
            GamepanelBlockGroupList[i].transform.localScale = new Vector3(0,0,0);
            if (HardyDesignCrudeFaculty.Instance.Cobalt.ContainsKey(i + 2))
            {
                SeldomName[i].SetActive(true);
                SeldomName[i].GetComponent<Image>().sprite = GamepanelBlockGroupList[i].transform.GetComponent<Image>().sprite;
                SeldomName[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = HardyDesignCrudeFaculty.Instance.Cobalt[i + 2];
            }
            else 
            {
                SeldomName[i].SetActive(false);
            }
        }
    }

    public void FordFlowerbed(List<GameObject> GamepanelBlockGroupList,System.Action finish = null) 
    {
        Folk(GamepanelBlockGroupList);
        BG.transform.DOScale(1, 0.5f).SetEase(Ease.OutBack).OnComplete(()=> 
        {
            BG.transform.DOScale(1, 1f).OnComplete(() => 
            {
                BG.GetComponent<Image>().DOFade(0, 0.6f);
                Five.GetComponent<Image>().DOFade(0, 0.6f);
                for (int i = 0; i < SeldomName.Count; i++)
                {
                    int A = 0;
                    A = i;
                    GameObject Utah= Instantiate(SeldomName[i],this.transform);
                    Utah.transform.position = SeldomName[i].transform.position;
                    SeldomName[i].SetActive(false);

                    if (Utah.activeSelf)
                    {
                        Utah.transform.DOMove(GamepanelBlockGroupList[i].transform.position, 0.6f).SetEase(Ease.InQuad).OnComplete(() =>
                        {
                            Destroy(Utah);
                            this.gameObject.SetActive(false);
                            if(A == SeldomName.Count - 1)
                                finish();
                        });
                    }
                    else 
                    {
                        Utah.transform.DOMove(GamepanelBlockGroupList[i].transform.position, 0.6f).SetEase(Ease.InQuad).OnComplete(() =>
                        {
                            Destroy(Utah);
                            if(A == SeldomName.Count - 1)
                                finish();
                        });
                    }
                }
            });
        });
        
    }

}
