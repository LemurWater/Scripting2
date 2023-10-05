public class LanguageText
{
    private string korean;
    private string english;
    private string spanish;

    public LanguageText(string korean, string english, string spanish)
    {
        Korean = korean;
        English = english;
        Spanish = spanish;
    }

    public string Korean { get => korean; set => korean = value; }
    public string English { get => english; set => english = value; }
    public string Spanish { get => spanish; set => spanish = value; }
}
