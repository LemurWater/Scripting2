using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestFont : MonoBehaviour
{
    public List<TextMeshProUGUI> l_texts;

    public List<TMP_FontAsset> l_fonts;
    public static int size;
    public TMP_FontAsset currentFont;
    [Range(1, 255)]
    public byte index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        size = l_fonts.Count;
        UpdateFont2();
    }

    void UpdateFont()
    {
        foreach(var text in l_texts)
        {
            text.font = currentFont;
        }
    }
    void UpdateFont2()
    {
        foreach (var text in l_texts)
        {
            text.font = l_fonts[index];
        }
    }
}
