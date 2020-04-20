using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{
#if UNITY_EDITOR
    [MenuItem("GameObject/UI/Progress Bar")]
    public static void AddLinearProgressBar()
    {
        GameObject obj = Instantiate(Resources.Load<GameObject>("UI/Progress Bar"));
        obj.transform.SetParent(Selection.activeGameObject.transform,false);
    }
#endif
    public int minium;
    public int maxium;
    public int current;
    public Image mask;
    public Image fill;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        float currentOffset = current - minium;
        float maxiumOffset = maxium - minium;
        float fillAmount = currentOffset / maxiumOffset;
        fill.fillAmount = fillAmount;

        fill.color = color;
    }
}
