using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    Languages language;

    public Languages CurrentLanguage()
    {
        return language;
    }

    public void ChangeLanguage(Languages newlanguage)
    {
        language = newlanguage;
    }
}
