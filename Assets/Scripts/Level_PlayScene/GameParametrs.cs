using UnityEngine.UI;

namespace GameParametr
{
    public static class GameParametrs
    {
        public static int hp; // здоровье игрока
        public static float speed = -0.1f; //скорость движения дороги и наших пративников
        public static float spawnTime = 1f; //время спавна противника 
        public static float curScore;
        public static float bestScore;
        public static Text record;//рекорд
        public static int hardLevel;
    }
}
