public enum BulletType {
    PISTOL,
    SHOTGUN,
    RIFLE,
    SNIPER,
}
public enum BuffType {
    POWERUP,
    POWERLOSS,
    CURENCY,
}
public enum WeaponType {
    KNIFE,
    GRENATE,
    LANDMINE,
    PISTOL,
    SHOTGUN,
    RIFLE,
    SNIPER,
}
public enum ItemType {
    WEAPON,
    BULLET,
    ARMOR,
    HEALTH,
    BUFF,
}
public class Player: MonoBehaviour {
    [Header("Player UI")]
    GameObject UI;
    [Header("Attributes")]
    float hp;
    float maxHp;
    int armor;
    int maxArmor;
    [Header("Buffs")]
    Buff[] playerBuffs;
    Crosshair crosshair;

    public void TakeDamage() {}
}
public class Buff: ScriptableObject {
    BuffType type;
    strung name;
    int value;
    Sprite icon;
    float duration;
    bool stackable;
    int maxStacks
}
public class Bullet: ScriptableObject {
    BulletType type;
    float damage;
    int range;
    int speed;
    int weight;
    GameObject prefab;
    Sprite icon;
}
public class BulletController: MonoBehaviour {
    private void OnCollisionEnter() {
        DoDamage();
    }
}
public class Weapon: ScriptableObject {
    WeaponType type;
    Bullet bullet;
    int maxBullets;
    int magazineSize;
    int weight;
    GameObject prefab;
    Sprite icon;
}
public class WeaponController: MonoBehaviour {
    Weapon weapon;

    public void FireBullet() {}

}
public class Item: ScriptableObject {
    ItemType type;

}
public class Crosshair: MonoBehaviour {
    public GameObject GetTarget() {
        return null;
    }
}