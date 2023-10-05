using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class LanguageManager : MonoBehaviour
{
    Languages language;

    public List<LanguageText> l_Languagetexts = new();
    public void Start()
    {
        LanguageText lt1 = new("", "New Game", "Nuevo Juego");
        LanguageText lt2 = new("", "Options", "Opciones");
        LanguageText lt3 = new("", "Exit", "Salir");
        LanguageText lt4 = new("", "Return", "Regresar");
        LanguageText lt5 = new("", "Volume", "Volumen");



        l_Languagetexts.Add(lt1);
        l_Languagetexts.Add(lt2);
        l_Languagetexts.Add(lt3);
        l_Languagetexts.Add(lt4);
        l_Languagetexts.Add(lt5);
    }
    public Languages CurrentLanguage()
    {
        return language;
    }

    public void ChangeLanguage(Languages newlanguage)
    {
        language = newlanguage;
    }
}
