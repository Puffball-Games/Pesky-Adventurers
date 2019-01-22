using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Keeps track of all castle upgrades
public class CastleUpgradeManager : MonoBehaviour
{
    public static CastleUpgradeManager instance;

    //TODO: make this a more efficient upgrade lookup
    public HashSet<CastleUpgrade> acquiredUpgrades = new HashSet<CastleUpgrade>();

    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool UpgradeCastle (CastleUpgrade upgrade) { 
        if (UserObject.instance.gold < upgrade.Cost() || !upgrade.CanAdditionalUpgrade()) {
            return false;
        } else {
            UserObject.instance.gold -= upgrade.Cost();

            if (!acquiredUpgrades.Contains(upgrade)) {
                acquiredUpgrades.Add(upgrade);
            } else {
                upgrade.IncrementUpgradeLevel();
            }

            ApplyCastleUpgrade(upgrade);

            return true;
        }
    }

    private void ApplyCastleUpgrade(CastleUpgrade upgrade) {
        //TODO: update userobject max health + various other effects
    }
}

//TODO: Decided what a castle upgrade looks like
public interface CastleUpgrade {
    int HealthIncrease();
    int Cost();
    bool CanAdditionalUpgrade();
    void IncrementUpgradeLevel();
    string GetDescription();
}
