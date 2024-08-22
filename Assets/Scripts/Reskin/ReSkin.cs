using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSkin : MonoBehaviour
{
    private static ReSkin instance;
    public static ReSkin Instance {get => instance;}

    public NewSkinSO newSkin;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
        newSkin = Resources.Load<NewSkinSO>("NewSkin");
    }

    public void StartReSkin(GameObject obj, int index)
    {
        obj.GetComponent<SpriteRenderer>().sprite = newSkin.listNewSkin[index];
    }    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
