using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  Data class that holds onto user stats including:
*   Gold
*   Towers
*   Golem upgrades (?)
*/
public class UserObject : MonoBehaviour
{
    public static UserObject instance;

    //User variables
    public int gold = 0;

    public const int defaultUserMaxHealth = 10;
    private int userMaxHealth = defaultUserMaxHealth;
    private int userHealth = defaultUserMaxHealth;
    public TowerManager manager;
    public GameObject golem;

    // Enforce the singleton pattern. Only allow one main castle or "user" to exist at one point in time.
    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

    }

    public int GetUserMaxHealth() {
        return userMaxHealth;
    }

    public int GetUserHealth() {
        return userHealth;
    }

    public void SetUserMaxHealth(int maxHealth) {
        if (maxHealth > defaultUserMaxHealth) {
            userMaxHealth = maxHealth;
        }
    }

    public void ReplenishHealth() {
        userHealth = userMaxHealth;
    }
}
