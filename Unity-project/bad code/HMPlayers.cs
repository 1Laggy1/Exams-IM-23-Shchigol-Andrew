using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;
using TMPro;

public class HMPlayers : MonoBehaviour
{
    public float HMPlayersF;
    public GameObject gamemodeO;
    public GameObject difficultyO;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public string gm;
    public float difficulty;
    public TMP_Text Description;
    public MainMenu mn;
    //public var Button2;

    // Start is called before the first frame update
    void Start()
    {
        HMPlayersF = PlayerPrefs.GetFloat("HMPlayersF");
        difficulty = PlayerPrefs.GetFloat("difficulty");
        gm = PlayerPrefs.GetString("gm");
        //var Button2 = GetComponent<Button>().colors;
        if (HMPlayersF == 0)
        {
            HMPlayersF = 2;
            PlayerPrefs.SetFloat("HMPlayersF", 2);
            Button2.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
            Button3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button2.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
            Button3.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            Button4.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        }
        else if (HMPlayersF == 1)
        {
            Button1.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
            Button2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button1.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
            Button2.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            Button3.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            Button4.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            gamemodeO.SetActive(false);
            difficultyO.SetActive(true);
            if (difficulty == 1 || difficulty == 0)
            {
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    Description.text = "���� � ������. ������� ����� ����� ���������";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    Description.text = "��� � ������. ������� �������� ���������";
                }
                else
                {
                    Description.text = "Game with bots. The easiest difficulty is chosen";
                }
            }
            else if (difficulty == 2)
            {
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    Description.text = "���� � ������. ������� ������� ���������. ���������� ����� ���������.";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    Description.text = "��� � ������. ������� ������� ���������. ʳ������ ����� ��������.";
                }
                else
                {
                    Description.text = "Game with bots. The hard difficulty is chosen. Number of coins increased.";
                }
            }
            else if (difficulty == 3)
            {
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    Description.text = "���� � ������. ������� ����� ������� ���������. ���������� ����� ������ ���������.";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    Description.text = "��� � ������. ������� ������� ���������. ʳ������ ����� ������ ��������";
                }
                else
                {
                    Description.text = "Game with bots. The hard difficulty is chosen. The number of coins has very increased";
                }
            }
        }
        else if (HMPlayersF == 2)
        {
            //var color2 = Button2.GetComponent<Button>().colors;
            //color2.normalColor = new Color(0, 0, 0);
            //Button2.GetComponent<Button>().colors = color2;
            //var color3 = Button3.GetComponent<Button>().colors;
            //color3.normalColor = new Color(0, 0, 0);
            //Button2.GetComponent<Button>().colors = color3;
            Button2.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
            Button3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button2.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
            Button3.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            Button4.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            Button1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button1.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            gamemodeO.SetActive(true);
            difficultyO.SetActive(false);
            TranstlateDescription();
        }
        else if (HMPlayersF == 3)
        {
            //var color2 = Button2.GetComponent<Button>().colors;
            //color2.normalColor = new Color(0, 0, 0);
            //Button2.GetComponent<Button>().colors = color2;
            //var color3 = Button3.GetComponent<Button>().colors;
            //color3.normalColor = new Color(0, 0, 0);
            //Button2.GetComponent<Button>().colors = color3;
            Button2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button3.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
            Button4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button2.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            Button3.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
            Button4.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            Button1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button1.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            gamemodeO.SetActive(true);
            difficultyO.SetActive(false);
            TranstlateDescription();
        }
        else if (HMPlayersF == 4)
        {
            //var color2 = Button2.GetComponent<Button>().colors;
            //color2.normalColor = new Color(0, 0, 0);
            //Button2.GetComponent<Button>().colors = color2;
            //var color3 = Button3.GetComponent<Button>().colors;
            //color3.normalColor = new Color(0, 0, 0);
            //Button2.GetComponent<Button>().colors = color3;
            Button1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button1.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            Button2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Button4.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
            Button2.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            Button3.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
            Button4.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
            gamemodeO.SetActive(true);
            difficultyO.SetActive(false);
            TranstlateDescription();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Button1Click()
    {
        mn.vp.clip = mn.solo;
        HMPlayersF = 1;
        PlayerPrefs.SetFloat("HMPlayersF", 1);
        Button1.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
        Button2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button1.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
        Button2.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        Button3.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        Button4.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        gamemodeO.SetActive(false);
        difficultyO.SetActive(true);
        if (difficulty == 1 || difficulty == 0)
        {
            if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
            {
                Description.text = "���� � ������. ������� ����� ����� ���������";
            }
            else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
            {
                Description.text = "��� � ������. ������� �������� ���������";
            }
            else
            {
                Description.text = "Game with bots. The easiest difficulty is chosen";
            }
        }
        else if (difficulty == 2)
        {
            if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
            {
                Description.text = "���� � ������. ������� ������� ���������. ���������� ����� ���������.";
            }
            else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
            {
                Description.text = "��� � ������. ������� ������� ���������. ʳ������ ����� ��������.";
            }
            else
            {
                Description.text = "Game with bots. The hard difficulty is chosen. Number of coins increased.";
            }
        }
        else if (difficulty == 3)
        {
            if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
            {
                Description.text = "���� � ������. ������� ����� ������� ���������. ���������� ����� ������ ���������.";
            }
            else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
            {
                Description.text = "��� � ������. ������� ������� ���������. ʳ������ ����� ������ ��������";
            }
            else
            {
                Description.text = "Game with bots. The hard difficulty is chosen. The number of coins has very increased";
            }
        }
    }

    public void Button2Click()
    {
        mn.gmChange();
        HMPlayersF = 2;
        PlayerPrefs.SetFloat("HMPlayersF", 2);
        Button2.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
        Button3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button2.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
        Button3.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        Button4.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        Button1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button1.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        gamemodeO.SetActive(true);
        difficultyO.SetActive(false);
        TranstlateDescription();
    }
    public void Button3Click()
    {
        mn.gmChange();
        HMPlayersF = 3;
        PlayerPrefs.SetFloat("HMPlayersF", 3);
        Button2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button3.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
        Button4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button2.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        Button3.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
        Button4.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        Button1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button1.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        gamemodeO.SetActive(true);
        difficultyO.SetActive(false);
        TranstlateDescription();
    }
    public void Button4Click()
    {
        mn.gmChange();
        HMPlayersF = 4;
        PlayerPrefs.SetFloat("HMPlayersF", 4);
        Button2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button4.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
        Button2.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        Button3.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        Button4.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
        Button1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Button1.GetComponentInChildren<Text>().color = new Color32(0, 0, 0, 255);
        gamemodeO.SetActive(true);
        difficultyO.SetActive(false);
        TranstlateDescription();
    }

    private void TranstlateDescription()
    {
        gm = PlayerPrefs.GetString("gm");
        if (gm == "" || gm == "all")
        {
            if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
            {
                Description.text = "������� ��� ������ ���� circle";
            }
            else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
            {
                Description.text = "������ �� ������ ��� circle";
            }
            else
            {
                Description.text = "All circle game modes are selected";
            }
        }
        else if (gm == "dm")
        {
            if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
            {
                Description.text = "������ ����� deathmatch. ��������� �������� �������� ����.";
            }
            else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
            {
                Description.text = "������� ����� deathmatch. �������, ��� �����, ������ ����.";
            }
            else
            {
                Description.text = "Deathmatch mode selected. The last survivor gets a point.";
            }
        }
        else if (gm == "monetu")
        {
            if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
            {
                Description.text = "������ ����� coins.�������� ���� ���, � ���� �� ��������� ������� ������ ����� �����. ��������� �������� �� �������� ����.";
            }
            else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
            {
                Description.text = "������� ����� coins. ������ ���� ���, � ���� ���� ��������� ���� �������� �����. �������, ��� �����, �� ������ ����.";
            }
            else
            {
                Description.text = "Coins mode selected. The point is awarded to the one who has the most coins at the end of the time. The last survivor does not receive a point.";
            }
        }
    }

}
