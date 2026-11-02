using UnityEngine;
using TMPro;

public enum QuestState
{
    NotStated,
    InPrgress,
    ReadyToComplete,
    Completed,
}

public class Quest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TextMeshProUGUI questText;
    private Quest currentQuest;

    void Start()
    {
        Completed,
    }
    [System.Serializable]
    public class Quest
    {
        public string questName = "아이템 수집";
        public string targetItemName = "사과";
        public int targetAmount = 3;

        [HideInInspector] public int currentAmount;
        [HideInInspector] public QuestState state = QuestState.NotStated;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartQuest(Quest newQuest)
    {
        currentQuest = newQuest;
        currentQuest.currentAmount = 0;
        currentQuest.state = QuestState.InPrgress;

        Debug.Log(currentQuest.questName + "퀘스트 시작!");
    }
}
