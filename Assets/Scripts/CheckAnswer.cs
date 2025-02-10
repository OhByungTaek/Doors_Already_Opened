using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CheckAnswer : MonoBehaviour
{
    public int Stage;

    public TextMeshProUGUI stageText;

    private void Start()
    {
        // 이전 Stage 값 불러오기
        Stage = PlayerPrefs.GetInt("Stage", 0);
        UpdateStageText();
    }
    private void UpdateStageText()
    {
        stageText.text = Stage.ToString(); // Stage 텍스트 설정
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Fail"))
        {
            Stage = 0;
            PlayerPrefs.SetInt("Stage", Stage);
            UpdateStageText();

            SceneManager.LoadScene("MainScene");

        }
        else if (collision.gameObject.CompareTag("Pass"))
        {
            Stage++;
            PlayerPrefs.SetInt("Stage", Stage);
            UpdateStageText();

            int randomNumber = Random.Range(1, 9);

            switch (randomNumber)
            {
                case 1:
                    SceneManager.LoadScene("gimik1Lab");
                    break;
                case 2:
                    SceneManager.LoadScene("gimik2Lab");
                    break;
                case 3:
                    SceneManager.LoadScene("gimik3Lab");
                    break;
                case 4:
                    SceneManager.LoadScene("gimik4Lab");
                    break;
                case 5:
                    SceneManager.LoadScene("gimik5Lab");
                    break;
                case 6:
                    SceneManager.LoadScene("gimik6Lab");
                    break;
                case 7:
                case 8:
                    SceneManager.LoadScene("MainScene");
                    break;

            }
        }
    }
}
