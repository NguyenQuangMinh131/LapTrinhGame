using UnityEngine;
using UnityEngine.Events; 

public class PlayerHealthUnityEvent : MonoBehaviour
{
    // Định nghĩa 1 Event có tham số là int (để gửi số máu)
    [System.Serializable] 
    public class HealthEvent : UnityEvent<int> { }

    [Header("Event Settings")]
    // Khai báo biến Event để hiện ra ngoài Inspector
    public HealthEvent OnHealthChanged; 
    public UnityEvent OnDeath;

    [Header("Stats")]
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        OnHealthChanged.Invoke(currentHealth);
    }

    void Update()
    {
        // Bấm K để trừ máu
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(10);
        }
    }

    void TakeDamage(int damage)
    {
        if (currentHealth <= 0) return;
        currentHealth -= damage;
        OnHealthChanged.Invoke(currentHealth);

        if (currentHealth <= 0)
        {
            OnDeath.Invoke();
        }
    }
}